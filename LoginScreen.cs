using System;
using System.Windows.Forms;
using Pharmacy.BusinessLogic;

namespace Pharmacy
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("الرجاء إدخال اسم المستخدم وكلمة المرور", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool isLoggedIn = clsPharmacistBL.CheckLogin(username, password);

                if (isLoggedIn)
                {
                    var pharmacist = clsPharmacistBL.GetPharmacistByUsername(username);
                    clsCurrentSession.CurrentPharmacistID = pharmacist.PharmacistID;

                    MessageBox.Show("تم تسجيل الدخول بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Screens.PharmacistScreens.AddNewPharmacistScreen addNewPharmacist = new Screens.PharmacistScreens.AddNewPharmacistScreen();
                    addNewPharmacist.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("اسم المستخدم أو كلمة المرور غير صحيحة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تسجيل الدخول: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}