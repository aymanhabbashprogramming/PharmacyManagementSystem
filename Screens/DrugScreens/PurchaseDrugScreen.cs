using Pharmacy.BusinessLogic;
using PharmacyApp.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PharmacyApp.DataAccess.clsDrugData;
using static PharmacyApp.DataAccess.clsSupplierData;

namespace Pharmacy.Screens.DrugScreens
{
    public partial class PurchaseDrugScreen : Form
    {
        private List<(stDrugInfo DrugInfo, stPurchaseInvoiceDetailInfo DetailInfo, List<int> ConflictingDrugIDs, stSupplierInfo SupplierInfo)> _purchaseItems =
            new List<(stDrugInfo, stPurchaseInvoiceDetailInfo, List<int>, stSupplierInfo)>();

        private class PurchaseDisplayRow
        {
            public int RowNumber { get; set; }
            public string DrugName { get; set; }
            public int Quantity { get; set; }
            public decimal UnitPrice { get; set; }
            public decimal TotalPrice { get; set; }
        }

        public PurchaseDrugScreen()
        {
            InitializeComponent();
        }

        private void PurchaseDrugScreen_Load(object sender, EventArgs e)
        {
            clsCurrentSession.CurrentPharmacistID = 1;
        }

        private void btnAddNewDrug_Click(object sender, EventArgs e)
        {
            DrugInfoScreen drugFrm = new DrugInfoScreen();
            DialogResult drugResult = drugFrm.ShowDialog();

            if (drugResult == DialogResult.OK)
            {
                PurchasePaymentInfoScreen paymentFrm = new PurchasePaymentInfoScreen(drugFrm.ResultDrugInfo, drugFrm.ResultConflictingDrugIDs);
                DialogResult paymentResult = paymentFrm.ShowDialog();

                if (paymentResult == DialogResult.OK)
                {
                    var item = (
                        paymentFrm.ResultDrugInfo,
                        paymentFrm.ResultDetailInfo,
                        paymentFrm.ResultConflictingDrugIDs,
                        paymentFrm.ResultSupplierInfo
                    );
                    _purchaseItems.Add(item);
                    _RefreshGrid();
                }
            }
        }

        private void _RefreshGrid()
        {
            List<PurchaseDisplayRow> rows = _purchaseItems.Select((item, index) => new PurchaseDisplayRow
            {
                RowNumber = index + 1,
                DrugName = item.DrugInfo.DrugName,
                Quantity = item.DetailInfo.Quantity,
                UnitPrice = item.DetailInfo.UnitPurchasePrice,
                TotalPrice = item.DetailInfo.TotalPrice
            }).ToList();

            dgvInvoiceItems.AutoGenerateColumns = false;
            dgvInvoiceItems.DataSource = rows;

            lblAddedProductCount.Text = _purchaseItems.Count.ToString();
            lblInvoiceTotal.Text = _purchaseItems.Sum(i => i.DetailInfo.TotalPrice).ToString("0.00");
        }

        private void btnConfirmAndSave_Click(object sender, EventArgs e)
        {
            if (_purchaseItems.Count == 0)
            {
                MessageBox.Show("Hiçbir ilaç eklenmedi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                stPurchaseInvoiceInfo invoiceInfo = new stPurchaseInvoiceInfo
                {
                    SupplierID = _purchaseItems.First().SupplierInfo.SupplierID,
                    PharmacistID = clsCurrentSession.CurrentPharmacistID,
                    InvoiceDate = DateTime.Now,
                    TotalAmount = _purchaseItems.Sum(i => i.DetailInfo.TotalPrice)
                };

                var itemsList = _purchaseItems.Select(i => (i.DrugInfo, i.DetailInfo, i.ConflictingDrugIDs)).ToList();

                var detailsList = _purchaseItems.Select(i => i.DetailInfo).ToList();
                string validationError = clsDrugBL.ValidatePurchaseInvoice(invoiceInfo, detailsList);
                if (validationError != null)
                {
                    MessageBox.Show(validationError, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult confirmResult = MessageBox.Show(
                    "Faturayı kaydetmek istediğinize emin misiniz?",
                    "Kaydı Onayla",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmResult == DialogResult.No)
                {
                    return;
                }

                bool isSaved = clsDrugBL.SaveNewDrugPurchase(invoiceInfo, itemsList);

                if (isSaved)
                {
                    MessageBox.Show("Satın alma işlemi ve fatura başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _purchaseItems.Clear();
                    _RefreshGrid();
                }
                else
                {
                    MessageBox.Show("Fatura veritabanına kaydedilemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kaydetme sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tüm faturayı iptal etmek istediğinize emin misiniz?", "İptal Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _purchaseItems.Clear();
                _RefreshGrid();
                this.Close();
            }
        }

        private void tsmiDeleteItem_Click(object sender, EventArgs e)
        {
            if (_purchaseItems.Count == 0)
            {
                MessageBox.Show("Listeniz henüz boş, silinecek ürün bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvInvoiceItems.CurrentRow == null)
                return;

            var displayRow = dgvInvoiceItems.CurrentRow.DataBoundItem as PurchaseDisplayRow;
            if (displayRow == null)
                return;

            int indexToRemove = displayRow.RowNumber - 1;

            if (indexToRemove < 0 || indexToRemove >= _purchaseItems.Count)
                return;

            string drugName = _purchaseItems[indexToRemove].DrugInfo.DrugName;

            DialogResult result = MessageBox.Show(
                $"[{displayRow.RowNumber}] numaralı ürünü ({drugName}) silmek istediğinize emin misiniz?",
                "Ürün Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                _purchaseItems.RemoveAt(indexToRemove);
                _RefreshGrid(); 
            }
        }




    }
}