using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using PharmacyApp.Business;
using static PharmacyApp.DataAccess.clsPatientData;

namespace Pharmacy.Screens.PatientScreens
{
    public partial class PatientsListScreen : Form
    {
        private List<stPatientInfo> _allPatientsList;

        public PatientsListScreen()
        {
            InitializeComponent();

            dgvPatients.AutoGenerateColumns = false;
        }

        private void PatientsListScreen_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void _LoadData()
        {
            try
            {
                _allPatientsList = clsPatientBL.GetAllPatients();

                dgvPatients.DataSource = null;
                dgvPatients.DataSource = _allPatientsList;

                _LoadPhonesToComboBox();
                txtPhoneToSearch.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veriler yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _LoadPhonesToComboBox()
        {
            cmbPhones.SelectedIndexChanged -= cmbPhones_SelectedIndexChanged;

            cmbPhones.DataSource = clsPatientBL.GetAllPhones();
            cmbPhones.SelectedIndex = -1;

            cmbPhones.SelectedIndexChanged += cmbPhones_SelectedIndexChanged;
        }

        private void cmbPhones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPhones.SelectedItem != null && cmbPhones.SelectedIndex != -1)
            {
                string selectedPhone = cmbPhones.SelectedItem.ToString();

                var filteredList = _allPatientsList.Where(p => p.Phone == selectedPhone).ToList();

                dgvPatients.DataSource = null;
                dgvPatients.DataSource = filteredList;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchPhone = txtPhoneToSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchPhone))
            {
                MessageBox.Show("Lütfen aranacak telefon numarasını giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var filteredList = _allPatientsList.Where(p => p.Phone.Equals(searchPhone, StringComparison.OrdinalIgnoreCase)).ToList();

            if (filteredList.Count > 0)
            {
                dgvPatients.DataSource = null;
                dgvPatients.DataSource = filteredList;
            }
            else
            {
                MessageBox.Show("Aranan telefon numarasına ait hasta bulunamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhoneToSearch.Clear();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void dgvPatients_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvPatients.Columns[e.ColumnIndex].Name == "colIsActive" && e.Value != null)
            {
                if (bool.TryParse(e.Value.ToString(), out bool isActive))
                {
                    e.Value = isActive ? "Aktif" : "Pasif";
                    e.CellStyle.ForeColor = isActive ? Color.Green : Color.Red;
                    e.CellStyle.Font = new Font("Times New Roman", 10, FontStyle.Regular);
                    e.FormattingApplied = true;
                }
            }
        }

    }
}