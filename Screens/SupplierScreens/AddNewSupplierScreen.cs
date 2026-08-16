using System;
using System.Windows.Forms;
using PharmacyApp.Business;
using static PharmacyApp.DataAccess.clsSupplierData;

namespace Pharmacy.Screens.SupplierScreens
{
    public partial class AddNewSupplierScreen : Form
    {
        public AddNewSupplierScreen()
        {
            InitializeComponent();
        }

        private bool _ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Lütfen ad alanını doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Lütfen soyad alanını doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Lütfen telefon alanını doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Lütfen e-posta alanını doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            return true;
        }

        private void _ClearForm()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            cbIsActive.Checked = true;
            txtFirstName.Focus();
        }

        private void btnAddNewSupplier_Click(object sender, EventArgs e)
        {
            if (!_ValidateFields())
            {
                return;
            }

            try
            {
                if (clsSupplierBL.IsPhoneExists(txtPhone.Text.Trim()))
                {
                    MessageBox.Show("Bu telefon numarası başka bir tedarikçiye ait!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPhone.Focus();
                    return;
                }

                if (clsSupplierBL.IsEmailExists(txtEmail.Text.Trim()))
                {
                    MessageBox.Show("Bu e-posta adresi başka bir tedarikçiye ait!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Focus();
                    return;
                }

                stSupplierInfo supplierInfo = new stSupplierInfo
                {
                    FirstName = txtFirstName.Text.Trim(),
                    LastName = txtLastName.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    IsActive = cbIsActive.Checked
                };

                int newID = clsSupplierBL.AddNewSupplier(supplierInfo);

                if (newID != -1)
                {
                    MessageBox.Show($"Tedarikçi başarıyla eklendi! (ID: {newID})", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _ClearForm();
                }
                else
                {
                    MessageBox.Show("Tedarikçi ekleme işlemi başarısız oldu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Sistem hatası: {ex.Message}", "Beklenmeyen Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _ClearForm();
        }

        private void AddNewSupplierScreen_Load(object sender, EventArgs e)
        {
            cbIsActive.Checked = true;
        }
    }
}