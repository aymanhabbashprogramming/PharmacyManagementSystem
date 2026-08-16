using System;
using System.Windows.Forms;
using PharmacyApp.Business;
using static PharmacyApp.DataAccess.clsPatientData;

namespace Pharmacy.Screens.PatientScreens
{
    public partial class AddNewPatientScreen : Form
    {
        public AddNewPatientScreen()
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

            return true;
        }

        private void _ResetForm()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
            cbIsActive.Checked = true;
            txtFirstName.Focus();
        }

        private void btnAddNewPatient_Click(object sender, EventArgs e)
        {
            if (!_ValidateFields())
            {
                return;
            }

            try
            {
                if (clsPatientBL.IsPhoneExists(txtPhone.Text.Trim()))
                {
                    MessageBox.Show("Bu telefon numarasına sahip bir hasta zaten kayıtlı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPhone.Focus();
                    return;
                }

                stPatientInfo newPatient = new stPatientInfo
                {
                    FirstName = txtFirstName.Text.Trim(),
                    LastName = txtLastName.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    IsActive = cbIsActive.Checked
                };

                int insertedID = clsPatientBL.AddNewPatient(newPatient);

                if (insertedID != -1)
                {
                    MessageBox.Show($"Hasta başarıyla eklendi! (ID: {insertedID})", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _ResetForm();
                }
                else
                {
                    MessageBox.Show("Hasta ekleme işlemi başarısız oldu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ekleme sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _ResetForm();
            this.Close();
        }

        private void AddNewPatientScreen_Load(object sender, EventArgs e)
        {
            cbIsActive.Checked = true;
        }
    }
}