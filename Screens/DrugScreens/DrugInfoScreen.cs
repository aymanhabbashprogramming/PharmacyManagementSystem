using Pharmacy.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static PharmacyApp.DataAccess.clsDrugData;

namespace Pharmacy.Screens.DrugScreens
{
    public partial class DrugInfoScreen : Form
    {
        public stDrugInfo ResultDrugInfo { get; private set; }
        public List<int> ResultConflictingDrugIDs { get; private set; }

        private stDrugInfo _existingDrugInfo;
        private List<int> _existingConflictingDrugIDs;
        private bool _isEditMode = false;

        public DrugInfoScreen()
        {
            InitializeComponent();
            ResultConflictingDrugIDs = new List<int>();
        }

        public DrugInfoScreen(stDrugInfo existingDrugInfo, List<int> existingConflictingDrugIDs) : this()
        {
            _existingDrugInfo = existingDrugInfo;
            _existingConflictingDrugIDs = existingConflictingDrugIDs ?? new List<int>();
            _isEditMode = true;
        }

        private class DrugConflictRow
        {
            public int DrugID { get; set; }
            public string DrugName { get; set; }
            public bool IsConflicting { get; set; }
        }

        private void DrugInfoScreen_Load(object sender, EventArgs e)
        {
            cmbCategories.DataSource = clsDrugBL.GetAllCategories();
            cmbCategories.DisplayMember = "CategoryName";
            cmbCategories.ValueMember = "DrugCategoryID";

            nudRefillIntervalDays.Enabled = chkIsRestricted.Checked;

            List<stDrugInfo> allDrugs = clsDrugBL.GetAllDrugs();
            List<DrugConflictRow> conflictRows = allDrugs
                .Select(d => new DrugConflictRow
                {
                    DrugID = d.DrugID,
                    DrugName = d.DrugName,
                    IsConflicting = _isEditMode && _existingConflictingDrugIDs.Contains(d.DrugID)
                })
                .ToList();

            dgvDrugConflicts.AutoGenerateColumns = false;
            dgvDrugConflicts.DataSource = conflictRows;

            if (_isEditMode)
            {
                txtDrugName.Text = _existingDrugInfo.DrugName;
                cmbCategories.SelectedValue = _existingDrugInfo.DrugCategoryID;
                chkIsRestricted.Checked = _existingDrugInfo.IsRestricted;
                txtUsageInstructions.Text = _existingDrugInfo.DailyDosage;

                if (_existingDrugInfo.RefillIntervalDays.HasValue)
                {
                    nudRefillIntervalDays.Value = _existingDrugInfo.RefillIntervalDays.Value;
                }
            }
        }

        private void chkIsRestricted_CheckedChanged(object sender, EventArgs e)
        {
            nudRefillIntervalDays.Enabled = chkIsRestricted.Checked;
        }

        private void btnConfirmAndProceed_Click(object sender, EventArgs e)
        {
            string drugName = txtDrugName.Text.Trim();

            if (string.IsNullOrEmpty(drugName))
            {
                MessageBox.Show("Lütfen ilaç adını giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbCategories.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir kategori seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if ((!_isEditMode || _existingDrugInfo.DrugName != drugName) && clsDrugBL.IsDrugNameExists(drugName))
                {
                    MessageBox.Show("İlaç adı zaten mevcut.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"İlaç adı kontrol edilirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (chkIsRestricted.Checked && nudRefillIntervalDays.Value == 0)
            {
                MessageBox.Show("Lütfen tekrar dolum aralığı gün sayısını giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmResult = MessageBox.Show(
                "Ödeme ekranına geçmeden önce bilgileri onaylamak istiyor musunuz?",
                "Bilgileri Onayla",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmResult == DialogResult.No)
            {
                return;
            }

            stDrugInfo info = new stDrugInfo();
            info.DrugName = drugName;
            info.DrugCategoryID = Convert.ToInt32(cmbCategories.SelectedValue);
            info.IsRestricted = chkIsRestricted.Checked;
            info.DailyDosage = txtUsageInstructions.Text.Trim();
            info.RefillIntervalDays = chkIsRestricted.Checked ? (int?)Convert.ToInt32(nudRefillIntervalDays.Value) : null;

            List<int> conflictIDs = new List<int>();
            if (dgvDrugConflicts.DataSource is List<DrugConflictRow> conflictRows)
            {
                conflictIDs = conflictRows
                    .Where(r => r.IsConflicting)
                    .Select(r => r.DrugID)
                    .ToList();
            }

            this.ResultDrugInfo = info;
            this.ResultConflictingDrugIDs = conflictIDs;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAddNewCategory_Click(object sender, EventArgs e)
        {
            string categoryName = txtNewCategory.Text.Trim();

            if (string.IsNullOrEmpty(categoryName))
            {
                MessageBox.Show("Lütfen kategori adını giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int newCategoryID = clsDrugBL.AddNewCategory(categoryName);

                if (newCategoryID > 0)
                {
                    cmbCategories.DataSource = clsDrugBL.GetAllCategories();
                    cmbCategories.SelectedValue = newCategoryID;
                    txtNewCategory.Clear();
                }
                else
                {
                    MessageBox.Show("Kategori ekleme işlemi başarısız oldu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kategori eklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearchCategory_Click(object sender, EventArgs e)
        {
            string searchText = txtSearchCategory.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                return;
            }

            if (cmbCategories.DataSource is List<stDrugCategoryInfo> categories)
            {
                stDrugCategoryInfo matchedItem = categories.FirstOrDefault(c =>
                    c.CategoryName != null && c.CategoryName.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0);

                if (!string.IsNullOrEmpty(matchedItem.CategoryName))
                {
                    cmbCategories.SelectedItem = matchedItem;
                }
                else
                {
                    MessageBox.Show("Kategori bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}