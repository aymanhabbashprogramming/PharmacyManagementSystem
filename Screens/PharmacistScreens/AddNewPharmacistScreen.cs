using Pharmacy.BusinessLogic;
using System;
using System.Windows.Forms;
using static PharmacyApp.DataAccess.clsPharmacistData;

namespace Pharmacy.Screens.PharmacistScreens
{
    public partial class AddNewPharmacistScreen : Form
    {
        public AddNewPharmacistScreen()
        {
            InitializeComponent();
        }

        private bool ValidateFields()
        {
            TextBox[] fields = { txtFirstName, txtLastName, txtEmail, txtPhone, txtUserName, txtPassword };

            foreach (TextBox field in fields)
            {
                if (string.IsNullOrWhiteSpace(field.Text))
                {
                    MessageBox.Show($"Lütfen '{field.Tag ?? field.Name}' alanını doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    field.Focus();
                    return false;
                }
            }

            return true;
        }

        private void btnAddNewPharmacist_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                return;
            }

            try
            {
                if (clsPharmacistBL.IsEmailExists(txtEmail.Text.Trim()))
                {
                    MessageBox.Show("Bu e-posta adresi zaten kayıtlı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Focus();
                    txtEmail.SelectAll();
                    return;
                }

                if (clsPharmacistBL.IsPhoneExists(txtPhone.Text.Trim()))
                {
                    MessageBox.Show("Bu telefon numarası zaten kayıtlı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPhone.Focus();
                    txtPhone.SelectAll();
                    return;
                }

                if (clsPharmacistBL.IsUsernameExists(txtUserName.Text.Trim()))
                {
                    MessageBox.Show("Bu kullanıcı adı zaten kullanılmaktadır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.Focus();
                    txtUserName.SelectAll();
                    return;
                }

                stPharmacistInfo pharmacistInfo = new stPharmacistInfo
                {
                    FirstName = txtFirstName.Text.Trim(),
                    LastName = txtLastName.Text.Trim(),
                    Username = txtUserName.Text.Trim(),
                    Password = txtPassword.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    IsActive= cbIsActive.Checked
                };

                int newPharmacistID = clsPharmacistBL.AddNewPharmacist(pharmacistInfo);

                if (newPharmacistID != -1)
                {
                    MessageBox.Show($"Eczacı başarıyla eklendi! ID: {newPharmacistID}", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Eczacı eklenirken bir hata oluştu. Lütfen tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Sistem hatası: {ex.Message}", "Beklenmeyen Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearForm()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
            txtFirstName.Focus();
            cbIsActive.Checked = true;
        }

        private void AddNewPharmacistScreen_Load(object sender, EventArgs e)
        {
            cbIsActive.Checked = true;  
        }
    }
}