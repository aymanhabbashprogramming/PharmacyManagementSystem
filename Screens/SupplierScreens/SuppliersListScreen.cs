using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PharmacyApp.Business;
using static PharmacyApp.DataAccess.clsSupplierData;

namespace Pharmacy.Screens.SupplierScreens
{
    public partial class SuppliersListScreen : Form
    {
        public SuppliersListScreen()
        {
            InitializeComponent();
        }

        private void SuppliersListScreen_Load(object sender, EventArgs e)
        {
            dgvSuppliers.AutoGenerateColumns = false;
            _LoadAllData();
        }

        private void _LoadAllData()
        {
            try
            {
                cmbEmails.DataSource = clsSupplierBL.GetAllEmails();
                cmbEmails.SelectedIndex = -1;
                dgvSuppliers.DataSource = clsSupplierBL.GetAllSuppliers();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veriler yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _DisplaySingleSupplierInGrid(stSupplierInfo supplier)
        {
            List<stSupplierInfo> singleSupplierList = new List<stSupplierInfo> { supplier };
            dgvSuppliers.DataSource = singleSupplierList;
        }

        private void cmbEmails_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEmails.SelectedItem != null && cmbEmails.SelectedIndex != -1)
            {
                string selectedEmail = cmbEmails.SelectedItem.ToString();
                stSupplierInfo supplier = clsSupplierBL.GetSupplierByEmail(selectedEmail);

                if (supplier.SupplierID != -1)
                {
                    _DisplaySingleSupplierInGrid(supplier);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string emailToSearch = txtEmailToSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(emailToSearch))
            {
                MessageBox.Show("Lütfen aranacak e-posta adresini giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                stSupplierInfo supplier = clsSupplierBL.GetSupplierByEmail(emailToSearch);

                if (supplier.SupplierID == -1)
                {
                    MessageBox.Show("Tedarikçi bulunamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmailToSearch.Clear();
                    txtEmailToSearch.Focus();
                }
                else
                {
                    _DisplaySingleSupplierInGrid(supplier);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Arama sırasında hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtEmailToSearch.Clear();
            _LoadAllData();
        }

        private void dgvSuppliers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvSuppliers.Columns[e.ColumnIndex].Name == "colIsActive" && e.Value != null)
            {
                if (bool.TryParse(e.Value.ToString(), out bool isActive))
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
    }
}