using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PharmacyApp.Business;
using static PharmacyApp.DataAccess.clsSupplierData;

namespace Pharmacy.Screens.SupplierScreens
{
    public partial class UpdateSupplierScreen : Form
    {
        private int _supplierID = -1;
        private bool _isCurrentActive = false;

        public UpdateSupplierScreen()
        {
            InitializeComponent();
        }

        private void UpdateSupplierScreen_Load(object sender, EventArgs e)
        {
            _LoadEmailsList();
            _SetFormState(false);
        }

        private void _LoadEmailsList()
        {
            try
            {
                cmbEmails.Items.Clear();
                List<string> emails = clsSupplierBL.GetAllEmails();
                foreach (string email in emails)
                {
                    cmbEmails.Items.Add(email);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"E-postalar yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _SetFormState(bool enabled)
        {
            txtFirstName.Enabled = enabled;
            txtLastName.Enabled = enabled;
            txtEmail.Enabled = enabled;
            txtPhone.Enabled = enabled;
            btnUpdateSupplier.Enabled = enabled;
            btnChangeStatus.Enabled = enabled;

            if (!enabled)
            {
                _ClearFormFields();
            }
        }

        private void _ClearFormFields()
        {
            _supplierID = -1;
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtEmailToSearch.Clear();
            lblCurrentStatus.Text = "---";
            lblCurrentStatus.ForeColor = Color.Black;
        }

        private void _FillSupplierData(stSupplierInfo supplier)
        {
            _supplierID = supplier.SupplierID;
            txtFirstName.Text = supplier.FirstName;
            txtLastName.Text = supplier.LastName;
            txtEmail.Text = supplier.Email;
            txtPhone.Text = supplier.Phone;
            _isCurrentActive = supplier.IsActive;

            _UpdateStatusLabel();
            _SetFormState(true);
        }

        private void _UpdateStatusLabel()
        {
            if (_isCurrentActive)
            {
                lblCurrentStatus.Text = "Aktif";
                lblCurrentStatus.ForeColor = Color.Green;
            }
            else
            {
                lblCurrentStatus.Text = "Pasif";
                lblCurrentStatus.ForeColor = Color.Red;
            }
        }

        private void _SearchSupplier(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Lütfen aranacak e-posta adresini giriniz veya seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                stSupplierInfo supplier = clsSupplierBL.GetSupplierByEmail(email.Trim());

                if (supplier.SupplierID != -1)
                {
                    _FillSupplierData(supplier);
                }
                else
                {
                    MessageBox.Show("Tedarikçi bulunamadı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _SetFormState(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Arama sırasında hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchEmail = !string.IsNullOrWhiteSpace(txtEmailToSearch.Text)
                ? txtEmailToSearch.Text.Trim()
                : (cmbEmails.SelectedItem != null ? cmbEmails.SelectedItem.ToString() : string.Empty);

            _SearchSupplier(searchEmail);
        }

        private void cmbEmails_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEmails.SelectedItem != null)
            {
                string selectedEmail = cmbEmails.SelectedItem.ToString();
               
                _SearchSupplier(selectedEmail);
            }
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

        private void btnUpdateSupplier_Click(object sender, EventArgs e)
        {
            if (_supplierID == -1 || !_ValidateFields())
            {
                return;
            }

            try
            {
                if (clsSupplierBL.IsPhoneExists(txtPhone.Text.Trim(), _supplierID))
                {
                    MessageBox.Show("Bu telefon numarası başka bir tedarikçiye ait!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPhone.Focus();
                    return;
                }

                if (clsSupplierBL.IsEmailExists(txtEmail.Text.Trim(), _supplierID))
                {
                    MessageBox.Show("Bu e-posta adresi başka bir tedarikçiye ait!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Focus();
                    return;
                }

                stSupplierInfo supplier = new stSupplierInfo
                {
                    SupplierID = _supplierID,
                    FirstName = txtFirstName.Text.Trim(),
                    LastName = txtLastName.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    IsActive = _isCurrentActive
                };

                if (clsSupplierBL.UpdateSupplierInfo(supplier))
                {
                    MessageBox.Show("Tedarikçi bilgileri başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _LoadEmailsList();
                    _ClearFormFields();
                }
                else
                {
                    MessageBox.Show("Güncelleme işlemi başarısız oldu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Güncelleme sırasında hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            if (_supplierID == -1) return;

            _isCurrentActive = !_isCurrentActive;
            _UpdateStatusLabel();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _SetFormState(false);
            txtEmailToSearch.Clear();
            cmbEmails.SelectedIndex = -1;
            this.Close();
        }
    }
}