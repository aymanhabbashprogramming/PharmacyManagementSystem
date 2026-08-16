using Pharmacy.BusinessLogic;
using PharmacyApp.DataAccess;
using System;
using System.Drawing;
using System.Windows.Forms;
using static PharmacyApp.DataAccess.clsPharmacistData;

namespace Pharmacy.Screens.PharmacistScreens
{
    public partial class UpdatePharmacistScreen : Form
    {
        private int _currentPharmacistID = -1;
        private bool _isCurrentStatusActive;

        // 1. הـ Constructor الخالي الأصلي
        public UpdatePharmacistScreen()
        {
            InitializeComponent();
            if (btnCancel2 != null)
            {
                btnCancel2.Visible = false;
            }   
        }

        // 2. الـ Constructor الجديد الذي يستقبل بيانات الصيدلي مباشرة
        public UpdatePharmacistScreen(clsPharmacistData.stPharmacistInfo pharmacistInfo)
        {
            InitializeComponent();
            _LoadPharmacistData(pharmacistInfo);

            // 1. تقليص عرض الشاشة إلى 657
            this.Width = 500;

            // 2. إظهار زر الإلغاء/الإغلاق المخصص لهذه الحالة
            if (btnCancel2 != null)
            {
                btnCancel2.Visible = true;
            }

            _LoadPharmacistData(pharmacistInfo);
        }
       
        // دالة مساعدة موحدة لتعبئة البيانات في الواجهة من الـ Struct
        private void _LoadPharmacistData(clsPharmacistData.stPharmacistInfo pharmacistInfo)
        {
            _currentPharmacistID = pharmacistInfo.PharmacistID;

            txtFirstName.Text = pharmacistInfo.FirstName;
            txtLastName.Text = pharmacistInfo.LastName;
            txtUserName.Text = pharmacistInfo.Username;
            txtPassword.Text = pharmacistInfo.Password;
            txtPhone.Text = pharmacistInfo.Phone;
            txtEmail.Text = pharmacistInfo.Email;

            _isCurrentStatusActive = pharmacistInfo.IsActive;
            lblCurrentStatus.Text = _isCurrentStatusActive ? "Aktif" : "Pasif";
            lblCurrentStatus.ForeColor = _isCurrentStatusActive ? Color.Green : Color.Red;

            SetFieldsState(true);
        }

        private void UpdatePharmacistScreen_Load(object sender, EventArgs e)
        {
            // عدم تصفير البيانات إذا تم فتح الشاشة عبر الـ Constructor الجديد (أي إذا كان المعرف معرفاً)
            if (_currentPharmacistID == -1)
            {
                ClearForm();
                LoadUsernames();
                SetFieldsState(false);
            }
        }

        private void LoadUsernames()
        {
            try
            {
                cmbUsernames.SelectedIndexChanged -= cmbUsernames_SelectedIndexChanged;

                cmbUsernames.DataSource = clsPharmacistBL.GetAllUsernames();
                cmbUsernames.SelectedIndex = -1;
                txtUserNameToSearch.Text = string.Empty;

                cmbUsernames.SelectedIndexChanged += cmbUsernames_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kullanıcı adları yüklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetFieldsState(bool isEnabled = false)
        {
            groupBox1.Enabled = isEnabled;
            btnUpdatePharmacist.Enabled = isEnabled;
        }

        private void cmbUsernames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUsernames.SelectedItem != null)
            {
                PerformSearch(cmbUsernames.SelectedItem.ToString().Trim());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PerformSearch(txtUserNameToSearch.Text.Trim());
        }

        private void PerformSearch(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Lütfen aramak için bir kullanıcı adı giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                clsPharmacistData.stPharmacistInfo pharmacistInfo = clsPharmacistBL.GetPharmacistByUsername(username);

                if (pharmacistInfo.PharmacistID == -1)
                {
                    ClearForm();
                    SetFieldsState(false);
                    MessageBox.Show("Eczacı bulunamadı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // استدعاء الدالة المساعدة بدلاً من تكرار الكود
                    _LoadPharmacistData(pharmacistInfo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Arama sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void ClearForm()
        {
            _currentPharmacistID = -1;
            txtFirstName.Clear();
            txtLastName.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            _isCurrentStatusActive = false;
            lblCurrentStatus.Text = string.Empty;
            txtUserNameToSearch.Clear();
        }

        private void btnUpdatePharmacist_Click(object sender, EventArgs e)
        {
            if (_currentPharmacistID == -1)
            {
                MessageBox.Show("Lütfen önce güncellenecek eczacıyı seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateFields())
            {
                return;
            }

            try
            {
                if (clsPharmacistBL.IsUsernameExists(txtUserName.Text.Trim(), _currentPharmacistID))
                {
                    MessageBox.Show("Bu kullanıcı adı başka bir eczacı tarafından kullanılmaktadır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.Focus();
                    return;
                }

                if (clsPharmacistBL.IsPhoneExists(txtPhone.Text.Trim(), _currentPharmacistID))
                {
                    MessageBox.Show("Bu telefon numarası başka bir eczacıya ait!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPhone.Focus();
                    return;
                }

                if (clsPharmacistBL.IsEmailExists(txtEmail.Text.Trim(), _currentPharmacistID))
                {
                    MessageBox.Show("Bu e-posta adresi başka bir eczacıya ait!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Focus();
                    return;
                }

                clsPharmacistData.stPharmacistInfo pharmacistInfo = new clsPharmacistData.stPharmacistInfo
                {
                    PharmacistID = _currentPharmacistID,
                    FirstName = txtFirstName.Text.Trim(),
                    LastName = txtLastName.Text.Trim(),
                    Username = txtUserName.Text.Trim(),
                    Password = txtPassword.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    IsActive = _isCurrentStatusActive
                };

                if (clsPharmacistBL.UpdatePharmacistInfo(pharmacistInfo))
                {
                    MessageBox.Show("Eczacı bilgileri başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // الاعتماد على رؤية زر btnCancel2 للتحقق هل تم الفتح من الـ Context Menu
                    if (btnCancel2 != null && btnCancel2.Visible)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        ClearForm();
                        LoadUsernames();
                        SetFieldsState(false);
                    }
                }
                else
                {
                    MessageBox.Show("Güncelleme işlemi başarısız oldu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            _isCurrentStatusActive = !_isCurrentStatusActive;
            lblCurrentStatus.Text = _isCurrentStatusActive ? "Aktif" : "Pasif";
            lblCurrentStatus.ForeColor = _isCurrentStatusActive ? Color.Green : Color.Red;
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}