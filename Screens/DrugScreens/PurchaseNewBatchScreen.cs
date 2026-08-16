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
    public partial class PurchaseNewBatchScreen : Form
    {
        public PurchaseNewBatchScreen()
        {
            InitializeComponent();
        }
        private List<(stDrugInfo DrugInfo, stPurchaseInvoiceDetailInfo DetailInfo)> _batchItems =
    new List<(stDrugInfo, stPurchaseInvoiceDetailInfo)>();

        private class BatchDisplayRow
        {
            public int RowNumber { get; set; }
            public string DrugName { get; set; }
            public int Quantity { get; set; }
            public decimal UnitPrice { get; set; }
            public decimal TotalPrice { get; set; }
        }

        private void _RefreshGrid()
        {
            List<BatchDisplayRow> rows = _batchItems.Select((item, index) => new BatchDisplayRow
            {
                RowNumber = index + 1,
                DrugName = item.DrugInfo.DrugName,
                Quantity = item.DetailInfo.Quantity,
                UnitPrice = item.DetailInfo.UnitPurchasePrice,
                TotalPrice = item.DetailInfo.TotalPrice
            }).ToList();

            dgvInvoiceItems.AutoGenerateColumns = false;
            dgvInvoiceItems.DataSource = null;
            dgvInvoiceItems.DataSource = rows;
        }
        private void PurchaseNewBatchScreen_Load(object sender, EventArgs e)
        {
            clsCurrentSession.CurrentPharmacistID = 1;
            // 1. تعيين تاريخ الفاتورة (تلقائي، غير قابل للتعديل)
            dtpInvoiceDate.Value = DateTime.Now;
            dtpInvoiceDate.Enabled = false;

            // 2. تعيين تاريخ الانتهاء الافتراضي
            dtpExpiryDate.MinDate = DateTime.Today.AddMonths(6);
            dtpExpiryDate.Value = DateTime.Today.AddMonths(6);

            // 3. تحميل بيانات الصيدلي
            LoadCurrentPharmacistInfo();

            // 4. تحميل قائمة الموردين (بالهاتف)
            try
            {
                var phones = clsSupplierBL.GetAllPhones();
                cmbSupplierPhones.DataSource = phones;
                cmbSupplierPhones.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Tedarikçi listesi yüklenirken hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // 5. تحميل قائمة الأدوية
            try
            {
                var drugs = clsDrugBL.GetAllDrugs();
                cmbNamesOfDrugs.DataSource = drugs;
                cmbNamesOfDrugs.DisplayMember = "DrugName";
                cmbNamesOfDrugs.ValueMember = "DrugID";

                if (drugs.Count > 0)
                {
                    cmbNamesOfDrugs.SelectedIndex = 0;
                    LoadCurrentStockForSelectedDrug(); // ← يُعرض المخزون الحالي
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"İlaç listesi yüklenirken hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCurrentPharmacistInfo()
        {
            try
            {
                if (clsCurrentSession.CurrentPharmacistID > 0)
                {
                    var pharmacist = clsPharmacistBL.GetPharmacistByID(clsCurrentSession.CurrentPharmacistID);
                    if (pharmacist.PharmacistID != -1)
                    {
                        txtPharmacistFullName.Text = $"{pharmacist.FirstName} {pharmacist.LastName}".Trim();
                        txtPharmacistPhone.Text = pharmacist.Phone;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eczacı bilgisi yüklenirken hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCurrentStockForSelectedDrug()
        {
            if (cmbNamesOfDrugs.SelectedItem == null)
                return;

            stDrugInfo selectedDrug = (stDrugInfo)cmbNamesOfDrugs.SelectedItem;

            try
            {
                int currentStock = clsDrugBL.GetCurrentStockByDrugID(selectedDrug.DrugID);
                lblCurrentStockValue.Text = currentStock.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Mevcut stok yüklenirken hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearDrugSelection_Click(object sender, EventArgs e)
        {
            cmbNamesOfDrugs.SelectedIndex = -1;
            lblCurrentStockValue.Text = "0";
        }

        private void cmbNamesOfDrugs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamesOfDrugs.SelectedItem == null)
            {
                lblCurrentStockValue.Text = "0";
                return;
            }

            stDrugInfo selectedDrug = (stDrugInfo)cmbNamesOfDrugs.SelectedItem;

            try
            {
                int currentStock = clsDrugBL.GetCurrentStockByDrugID(selectedDrug.DrugID);
                lblCurrentStockValue.Text = currentStock.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Mevcut stok yüklenirken hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblCurrentStockValue.Text = "0";
            }
        }

        private void btnSearchDrug_Click(object sender, EventArgs e)
        {
            string searchText = txtDrugNameToSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("İlaç Adı Giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                stDrugInfo drug = clsDrugBL.GetDrugByName(searchText);

                if (drug.DrugID != -1)
                {
                    // ← البحث بالاسم واختيار العنصر المطابق
                    foreach (stDrugInfo item in cmbNamesOfDrugs.Items)
                    {
                        if (item.DrugName.Equals(drug.DrugName, StringComparison.OrdinalIgnoreCase))
                        {
                            cmbNamesOfDrugs.SelectedItem = item;
                            break;
                        }
                    }
                    txtDrugNameToSearch.Clear();
                }
                else
                {
                    MessageBox.Show("İlaç bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Arama sırasında hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalculateTotal_Click(object sender, EventArgs e)
        {
            decimal total = nudNewQuantity.Value * numUnitPrice.Value;
            txtTotalPrice.Text = total.ToString("0.00");
        }

        private void btnAddDrugToInvoice_Click(object sender, EventArgs e)
        {
            // 1. التحقق من اختيار الدواء
            if (cmbNamesOfDrugs.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir ilaç seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. التحقق من اختيار المورد
            if (cmbSupplierPhones.SelectedItem == null || string.IsNullOrEmpty(txtSupplierPhone.Text.Trim()))
            {
                MessageBox.Show("Lütfen bir tedarikçi seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. التحقق من الكمية والسعر
            if (nudNewQuantity.Value <= 0 || numUnitPrice.Value <= 0)
            {
                MessageBox.Show("Miktar ve birim fiyat sıfırdan büyük olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 4. جلب الدواء المختار
            stDrugInfo selectedDrug = (stDrugInfo)cmbNamesOfDrugs.SelectedItem;

            // 5. إنشاء تفاصيل الدفعة
            stPurchaseInvoiceDetailInfo detail = new stPurchaseInvoiceDetailInfo();
            detail.DrugID = selectedDrug.DrugID;
            detail.Quantity = Convert.ToInt32(nudNewQuantity.Value);
            detail.UnitPurchasePrice = numUnitPrice.Value;
            detail.TotalPrice = nudNewQuantity.Value * numUnitPrice.Value; // ← حساب مباشر (أمان)
            detail.ExpiryDate = dtpExpiryDate.Value;

            // 6. إضافة للقائمة وتحديث الشبكة
            _batchItems.Add((selectedDrug, detail));
            _RefreshGrid();

            // 7. تفريغ حقول الإدخال (استعداداً للدفعة التالية)
            nudNewQuantity.Value = 0;
            numUnitPrice.Value = 0;
            txtTotalPrice.Clear();
        }

        private void btnSearchSupplier_Click(object sender, EventArgs e)
        {
            string searchText = txtSearchSupplierPhone.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                return;
            }

            try
            {
                stSupplierInfo supplier = clsSupplierBL.GetSupplierByPhone(searchText);

                if (supplier.SupplierID != -1)
                {
                    cmbSupplierPhones.SelectedItem = supplier.Phone;
                    // ← الحقول الأخرى تُملأ تلقائياً عبر SelectedIndexChanged
                }
                else
                {
                    MessageBox.Show("Tedarikçi bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Arama sırasında hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbSupplierPhones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSupplierPhones.SelectedIndex == -1 || cmbSupplierPhones.SelectedItem == null)
            {
                ClearSupplierFields();
                return;
            }

            string selectedPhone = cmbSupplierPhones.SelectedItem.ToString();

            try
            {
                stSupplierInfo supplier = clsSupplierBL.GetSupplierByPhone(selectedPhone);

                if (supplier.SupplierID != -1)
                {
                    txtSupplierFullName.Text = $"{supplier.FirstName} {supplier.LastName}".Trim();
                    txtSupplierEmail.Text = supplier.Email;
                    txtSupplierPhone.Text = supplier.Phone;
                }
                else
                {
                    MessageBox.Show("Tedarikçi bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearSupplierFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Tedarikçi bilgisi yüklenirken hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearSupplierFields();
            }
        }

        private void ClearSupplierFields()
        {
            txtSupplierFullName.Clear();
            txtSupplierEmail.Clear();
            txtSupplierPhone.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (_batchItems.Count == 0)
            {
                this.Close();
                return;
            }

            DialogResult result = MessageBox.Show(
                "İşlemi iptal etmek istediğinize emin misiniz? Eklenen ürünler kaybolacak.",
                "İptal Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                _batchItems.Clear();
                _RefreshGrid();
                this.Close();
            }
        }

        private void btnSaveInvoice_Click(object sender, EventArgs e)
        {
            // 1. فحص وجود عناصر
            if (_batchItems.Count == 0)
            {
                MessageBox.Show("Faturaya eklenmiş ürün bulunmamaktadır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. فحص اختيار المورد
            if (string.IsNullOrEmpty(txtSupplierPhone.Text.Trim()))
            {
                MessageBox.Show("Lütfen bir tedarikçi seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 3. جلب بيانات المورد
                stSupplierInfo supplier = clsSupplierBL.GetSupplierByPhone(txtSupplierPhone.Text.Trim());
                if (supplier.SupplierID == -1)
                {
                    MessageBox.Show("Tedarikçi bilgisi alınamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 4. تجهيز بيانات الفاتورة الرئيسية
                stPurchaseInvoiceInfo invoiceInfo = new stPurchaseInvoiceInfo
                {
                    SupplierID = supplier.SupplierID,
                    PharmacistID = clsCurrentSession.CurrentPharmacistID,
                    InvoiceDate = DateTime.Now,
                    TotalAmount = _batchItems.Sum(i => i.DetailInfo.TotalPrice)
                };

                // 5. استخراج قائمة التفاصيل
                List<stPurchaseInvoiceDetailInfo> details = _batchItems.Select(i => i.DetailInfo).ToList();

                // 6. التحقق المنطقي
                string validationError = clsDrugBL.ValidatePurchaseInvoice(invoiceInfo, details);
                if (validationError != null)
                {
                    MessageBox.Show(validationError, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 7. تأكيد الحفظ
                DialogResult confirm = MessageBox.Show(
                    "Faturayı kaydetmek istediğinize emin misiniz?",
                    "Onay",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirm == DialogResult.No)
                    return;

                // 8. الحفظ
                bool isSaved = clsDrugBL.SaveNewStockPurchase(invoiceInfo, details);

                if (isSaved)
                {
                    MessageBox.Show("Stok girişi başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _batchItems.Clear();
                    _RefreshGrid();
                }
                else
                {
                    MessageBox.Show("Fatura kaydedilemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kaydetme sırasında hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsmiDeleteItem_Click(object sender, EventArgs e)
        {
            if (_batchItems.Count == 0)
            {
                MessageBox.Show(
                    "Henüz ürün eklenmedi. Silinecek bir öğe yok.",
                    "Bilgi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            if (dgvInvoiceItems.CurrentRow == null)
                return;

            var displayRow = dgvInvoiceItems.CurrentRow.DataBoundItem as BatchDisplayRow;
            if (displayRow == null)
                return;

            int indexToRemove = displayRow.RowNumber - 1;

            if (indexToRemove < 0 || indexToRemove >= _batchItems.Count)
                return;

            string drugName = _batchItems[indexToRemove].DrugInfo.DrugName;

            DialogResult result = MessageBox.Show(
                $"[{displayRow.RowNumber}] numaralı ürünü ({drugName}) silmek istediğinize emin misiniz?",
                "Ürün Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                _batchItems.RemoveAt(indexToRemove);
                _RefreshGrid();
            }
        }

        private void tsmiEditItem_Click(object sender, EventArgs e)
        {
            if (_batchItems.Count == 0)
            {
                MessageBox.Show(
                    "Henüz ürün eklenmedi. Düzenlenecek bir öğe yok.",
                    "Bilgi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            if (dgvInvoiceItems.CurrentRow == null)
                return;

            var displayRow = dgvInvoiceItems.CurrentRow.DataBoundItem as BatchDisplayRow;
            if (displayRow == null)
                return;

            int indexToEdit = displayRow.RowNumber - 1;

            if (indexToEdit < 0 || indexToEdit >= _batchItems.Count)
                return;

            // 1. استخراج العنصر الأصلي
            var item = _batchItems[indexToEdit];

            // 2. ملء الحقول بالقيم الحالية
            foreach (stDrugInfo drug in cmbNamesOfDrugs.Items)
            {
                if (drug.DrugID == item.DrugInfo.DrugID)
                {
                    cmbNamesOfDrugs.SelectedItem = drug;
                    break;
                }
            }

            nudNewQuantity.Value = item.DetailInfo.Quantity;
            numUnitPrice.Value = item.DetailInfo.UnitPurchasePrice;
            dtpExpiryDate.Value = item.DetailInfo.ExpiryDate;
            txtTotalPrice.Text = item.DetailInfo.TotalPrice.ToString("0.00");

            // 3. حذف العنصر من القائمة
            _batchItems.RemoveAt(indexToEdit);
            _RefreshGrid();
        }
    }
}
