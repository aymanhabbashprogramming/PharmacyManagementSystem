using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Pharmacy.BusinessLogic;
using PharmacyApp.DataAccess;

namespace Pharmacy.Screens.PharmacistScreens
{
    public partial class PharmacistsListScreen : Form
    {
        public PharmacistsListScreen()
        {
            InitializeComponent();
        }

        private void PharmacistsListScreen_Load(object sender, EventArgs e)
        {
            _LoadPharmacistsData();
            _LoadUsernamesData(); // تجديد الكومبوبوكس عند فتح الشاشة
        }

        // دالة مساعدة موحدة لتعبئة الكومبوبوكس ومنع الاختيار التلقائي
        private void _LoadUsernamesData()
        {
            cmbUsernames.SelectedIndexChanged -= cmbUsernames_SelectedIndexChanged;
            cmbUsernames.DataSource = clsPharmacistBL.GetAllUsernames();
            cmbUsernames.SelectedIndex = -1;
            cmbUsernames.SelectedIndexChanged += cmbUsernames_SelectedIndexChanged;
        }

        private void _LoadPharmacistsData()
        {
            dgvPharmacists.AutoGenerateColumns = false;

            if (dgvPharmacists.Columns["colIsActive"] != null)
            {
                dgvPharmacists.Columns["colIsActive"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvPharmacists.Columns["colIsActive"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            List<clsPharmacistData.stPharmacistInfo> pharmacistsList = clsPharmacistBL.GetAllPharmacists();
            dgvPharmacists.DataSource = pharmacistsList;
        }

        private void _DisplaySinglePharmacistInGrid(clsPharmacistData.stPharmacistInfo pharmacist)
        {
            List<clsPharmacistData.stPharmacistInfo> singleList = new List<clsPharmacistData.stPharmacistInfo> { pharmacist };
            dgvPharmacists.DataSource = singleList;
        }

        private void cmbUsernames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUsernames.SelectedIndex == -1 || cmbUsernames.SelectedItem == null)
                return;

            string selectedUsername = cmbUsernames.SelectedItem.ToString();
            clsPharmacistData.stPharmacistInfo pharmacist = clsPharmacistBL.GetPharmacistByUsername(selectedUsername);

            if (pharmacist.PharmacistID != -1)
            {
                _DisplaySinglePharmacistInGrid(pharmacist);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string usernameToSearch = txtUserNameToSearch.Text.Trim();

            if (string.IsNullOrEmpty(usernameToSearch))
                return;

            clsPharmacistData.stPharmacistInfo pharmacist = clsPharmacistBL.GetPharmacistByUsername(usernameToSearch);

            if (pharmacist.PharmacistID == -1)
            {
                MessageBox.Show("Eczacı bulunamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserNameToSearch.Clear();
            }
            else
            {
                _DisplaySinglePharmacistInGrid(pharmacist);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            _LoadPharmacistsData();

            // 2. إعادة جلب أسماء المستخدمين المحدثة للكومبوبوكس (تعديل المشكلة)
            _LoadUsernamesData();

            // 3. تفريغ حقل البحث النصي
            txtUserNameToSearch.Text = "";
        }

        private void dgvPharmacists_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvPharmacists.Columns[e.ColumnIndex].Name == "colIsActive")
            {
                if (e.Value != null && e.Value is bool isActive)
                {
                    if (isActive)
                    {
                        e.Value = "Aktif";
                        e.CellStyle.ForeColor = Color.Green;
                    }
                    else
                    {
                        e.Value = "Pasif";
                        e.CellStyle.ForeColor = Color.Red;
                    }

                    e.FormattingApplied = true;
                }
            }
        }

        private void miEditPharmacist_Click_1(object sender, EventArgs e)
        {
            if (dgvPharmacists.CurrentRow == null)
                return;

            string username = dgvPharmacists.CurrentRow.Cells["colUsername"].Value?.ToString();

            if (!string.IsNullOrEmpty(username))
            {
                clsPharmacistData.stPharmacistInfo pharmacistInfo = clsPharmacistBL.GetPharmacistByUsername(username);

                if (pharmacistInfo.PharmacistID != -1)
                {
                    UpdatePharmacistScreen updateScreen = new UpdatePharmacistScreen(pharmacistInfo);
                    updateScreen.ShowDialog();

                    // عند إغلاق الشاشة يتم استدعاء btnRefresh_Click ليجدد الجدول والكومبوبوكس معاً
                    btnRefresh_Click(sender, e);
                }
            }
        }
    }
}