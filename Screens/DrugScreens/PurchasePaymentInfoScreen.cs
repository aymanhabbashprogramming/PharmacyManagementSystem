using Pharmacy.BusinessLogic;
using PharmacyApp.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static PharmacyApp.DataAccess.clsDrugData;
using static PharmacyApp.DataAccess.clsSupplierData;

namespace Pharmacy.Screens.DrugScreens
{
    public partial class PurchasePaymentInfoScreen : Form
    {
        private stDrugInfo _currentDrugInfo;
        private List<int> _currentConflictingDrugIDs;

        public stPurchaseInvoiceDetailInfo ResultDetailInfo { get; private set; }
        public stSupplierInfo ResultSupplierInfo { get; private set; }

        public stDrugInfo ResultDrugInfo { get; private set; }
        public List<int> ResultConflictingDrugIDs { get; private set; }

        public PurchasePaymentInfoScreen()
        {
            InitializeComponent();
        }

        public PurchasePaymentInfoScreen(stDrugInfo drugInfo, List<int> conflictingDrugIDs) : this()
        {
            _currentDrugInfo = drugInfo;
            _currentConflictingDrugIDs = conflictingDrugIDs;
            _FillDrugSummary(drugInfo);
        }

        private void PurchasePaymentInfoScreen_Load(object sender, EventArgs e)
        {
            dtpExpiryDate.MinDate = DateTime.Today.AddMonths(6);
            dtpExpiryDate.Value = DateTime.Today.AddMonths(6);

            dtpInvoiceDate.Value = DateTime.Now;
            dtpInvoiceDate.Enabled = false;

            LoadCurrentPharmacistInfo();

            try
            {
                var phones = clsSupplierBL.GetAllPhones();
                cmbSupplierPhones.DataSource = phones;
                cmbSupplierPhones.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Tedarikçi listesi yüklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CalculateTotalPrice();
        }

        private void dtpExpiryDate_ValueChanged(object sender, EventArgs e)
        {
            txtConsumptionDate.Text = dtpExpiryDate.Value.ToString("dd.MM.yyyy");
        }

        private void _FillDrugSummary(stDrugInfo drugInfo)
        {
            txtDrugName.Text = drugInfo.DrugName;
            txtDrugCategory.Text = clsDrugBL.GetCategoryNameByID(drugInfo.DrugCategoryID);
            txtRestrictionStatus.Text = drugInfo.IsRestricted ? "Kısıtlı" : "Kısıtlı Değil";
        }

        private void CalculateTotalPrice()
        {
            decimal total = numQuantity.Value * numUnitPrice.Value;
            txtTotalPrice.Text = total.ToString("0.00");
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
                MessageBox.Show($"Eczacı bilgileri alınırken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                var supplier = clsSupplierBL.GetSupplierByPhone(selectedPhone);

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
                MessageBox.Show($"Tedarikçi bilgileri alınırken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearSupplierFields();
            }
        }

        private void ClearSupplierFields()
        {
            txtSupplierFullName.Clear();
            txtSupplierEmail.Clear();
            txtSupplierPhone.Clear();
        }

        private void btnEditDrugDetails_Click(object sender, EventArgs e)
        {
            DrugInfoScreen frm = new DrugInfoScreen(_currentDrugInfo, _currentConflictingDrugIDs);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                _currentDrugInfo = frm.ResultDrugInfo;
                _currentConflictingDrugIDs = frm.ResultConflictingDrugIDs;
                _FillDrugSummary(_currentDrugInfo);
            }
        }

        private void btnSearchSupplier_Click(object sender, EventArgs e)
        {
            string searchText = txtSearchSupplierByPhone.Text.Trim();

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
                }
                else
                {
                    MessageBox.Show("Tedarikçi bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Arama sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisableControl(Form form, string controlName)
        {
            Control ctrl = form.Controls.Find(controlName, true).FirstOrDefault();
            if (ctrl != null)
            {
                if (ctrl is DataGridView dgv)
                {
                    dgv.ReadOnly = true;
                }
                else
                {
                    ctrl.Enabled = false;
                }
            }
        }

        private void btnShowDrugDetails_Click(object sender, EventArgs e)
        {
            DrugInfoScreen frm = new DrugInfoScreen(_currentDrugInfo, _currentConflictingDrugIDs);

            DisableControl(frm, "txtDrugName");
            DisableControl(frm, "cmbCategories");
            DisableControl(frm, "chkIsRestricted");
            DisableControl(frm, "nudRefillIntervalDays");
            DisableControl(frm, "txtUsageInstructions");
            DisableControl(frm, "dgvDrugConflicts");
            DisableControl(frm, "btnConfirmAndProceed");
            DisableControl(frm, "txtNewCategory");
            DisableControl(frm, "btnAddNewCategory");
            DisableControl(frm, "txtSearchCategory");
            DisableControl(frm, "btnSearchCategory");

            frm.ShowDialog();
        }

        private void btnConfirmAndProceed_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSupplierPhone.Text.Trim()))
            {
                MessageBox.Show("Lütfen bir tedarikçi seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numQuantity.Value <= 0 || numUnitPrice.Value <= 0)
            {
                MessageBox.Show("Lütfen geçerli bir miktar ve fiyat giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            stPurchaseInvoiceDetailInfo detailInfo = new stPurchaseInvoiceDetailInfo();
            detailInfo.Quantity = Convert.ToInt32(numQuantity.Value);
            detailInfo.UnitPurchasePrice = numUnitPrice.Value;
            detailInfo.TotalPrice = Convert.ToDecimal(txtTotalPrice.Text);
            detailInfo.ExpiryDate = dtpExpiryDate.Value;

            stSupplierInfo supplierInfo = clsSupplierBL.GetSupplierByPhone(txtSupplierPhone.Text.Trim());

            if (supplierInfo.SupplierID == -1)
            {
                MessageBox.Show("Seçilen tedarikçi bilgileri alınamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult confirmResult = MessageBox.Show(
                "Ana satın alma sayfasına geçmek istiyor musunuz?",
                "Onay",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmResult == DialogResult.No)
            {
                return;
            }

            ResultDrugInfo = _currentDrugInfo;
            ResultConflictingDrugIDs = _currentConflictingDrugIDs;

            ResultDetailInfo = detailInfo;
            ResultSupplierInfo = supplierInfo;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnCalculateTotal_Click(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }
    }
}