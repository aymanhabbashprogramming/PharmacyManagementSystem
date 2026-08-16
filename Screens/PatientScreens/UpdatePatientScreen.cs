using System;
using System.Drawing;
using System.Windows.Forms;
using PharmacyApp.Business;
using static PharmacyApp.DataAccess.clsPatientData;

namespace Pharmacy.Screens.PatientScreens
{
    public partial class UpdatePatientScreen : Form
    {
        private stPatientInfo _currentPatient;

        public UpdatePatientScreen()
        {
            InitializeComponent();
        }

        private void UpdatePatientScreen_Load(object sender, EventArgs e)
        {
            _LoadPhonesToComboBox();
            _ResetForm();
        }

        private void _LoadPhonesToComboBox()
        {
            try
            {
                cmbPhones.DataSource = clsPatientBL.GetAllPhones();
                cmbPhones.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Telefon listesi yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _UpdateStatusUI(bool isActive)
        {
            if (isActive)
            {
                lblCurrentStatus.Text = "Aktif";
                lblCurrentStatus.ForeColor = Color.Green;
                btnChangeStatus.Text = "Pasifleştir";
            }
            else
            {
                lblCurrentStatus.Text = "Pasif";
                lblCurrentStatus.ForeColor = Color.Red;
                btnChangeStatus.Text = "Aktifleştir";
            }
        }

        private void _FillPatientDataToForm(stPatientInfo patient)
        {
            _currentPatient = patient;

            txtFirstName.Text = patient.FirstName;
            txtLastName.Text = patient.LastName;
            txtPhone.Text = patient.Phone;

            _UpdateStatusUI(patient.IsActive);

            btnUpdatePatient.Enabled = true;
            btnChangeStatus.Enabled = true;
        }

        private void _ResetForm()
        {
            _currentPatient = new stPatientInfo { PatientID = -1 };

            txtPhoneToSearch.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();

            lblCurrentStatus.Text = "---";
            lblCurrentStatus.ForeColor = Color.Black;

            btnUpdatePatient.Enabled = false;
            btnChangeStatus.Enabled = false;
            btnChangeStatus.Text = "Durumu Değiştir";
        }

        private void _SearchAndFillPatient(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Lütfen geçerli bir telefon numarası giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                stPatientInfo patient = clsPatientBL.GetPatientByPhone(phone.Trim());

                if (patient.PatientID == -1)
                {
                    MessageBox.Show("Aranan telefon numarasına ait hasta bulunamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    _ResetForm();
                }
                else
                {
                    _FillPatientDataToForm(patient);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Arama sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbPhones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPhones.SelectedItem != null && cmbPhones.SelectedIndex != -1)
            {
                string selectedPhone = cmbPhones.SelectedItem.ToString();
                _SearchAndFillPatient(selectedPhone);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _SearchAndFillPatient(txtPhoneToSearch.Text);
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

        private void btnUpdatePatient_Click(object sender, EventArgs e)
        {
            if (_currentPatient.PatientID == -1)
            {
                MessageBox.Show("Lütfen önce güncellenecek bir hasta seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!_ValidateFields())
                return;

            try
            {
                if (clsPatientBL.IsPhoneExists(txtPhone.Text.Trim(), _currentPatient.PatientID))
                {
                    MessageBox.Show("Bu telefon numarası başka bir hastaya ait!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPhone.Focus();
                    return;
                }

                _currentPatient.FirstName = txtFirstName.Text.Trim();
                _currentPatient.LastName = txtLastName.Text.Trim();
                _currentPatient.Phone = txtPhone.Text.Trim();

                if (clsPatientBL.UpdatePatientInfo(_currentPatient))
                {
                    MessageBox.Show("Hasta bilgileri başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _LoadPhonesToComboBox();
                    _ResetForm();
                }
                else
                {
                    MessageBox.Show("Güncelleme işlemi başarısız oldu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Güncelleme sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            if (_currentPatient.PatientID == -1)
                return;

            _currentPatient.IsActive = !_currentPatient.IsActive;
            _UpdateStatusUI(_currentPatient.IsActive);
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _ResetForm();
            this.Close();
        }
    }
}