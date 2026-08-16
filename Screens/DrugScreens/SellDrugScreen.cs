using FontAwesome.Sharp;
using Pharmacy.BusinessLogic;
using PharmacyApp.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PharmacyApp.DataAccess.clsDrugData;
using static PharmacyApp.DataAccess.clsPharmacistData;

namespace Pharmacy.Screens.DrugScreens
{
    public partial class SellDrugScreen : Form
    {
        public SellDrugScreen()
        {
            InitializeComponent();
        }

        private int _currentPatientID = -1;
        private DateTime _invoiceDate = DateTime.Now;

        private List<(int DrugID, string DrugName, int PurchaseInvoiceDetailID, int Quantity, decimal UnitPrice, decimal TotalPrice)> _dispensedDrugsList
        = new List<(int DrugID, string DrugName, int PurchaseInvoiceDetailID, int Quantity, decimal UnitPrice, decimal TotalPrice)>();

        private void SetupLabelIcons()
        {
            int iconSize = 30;

            lblTotalDrugsIcon.Image = IconChar.BoxesStacked.ToBitmap(Color.DodgerBlue, iconSize);
        
            lblConflictingDrugsIcon.Image = IconChar.Receipt.ToBitmap(Color.Crimson, iconSize);

            lblSafeDrugsIcon.Image = IconChar.ShieldHalved.ToBitmap(Color.SeaGreen, iconSize);
        }
        private void SetupMenuIcons()
        {
            tsmiViewDrugDetails.IconChar = IconChar.InfoCircle;
            tsmiViewDrugDetails.IconColor = Color.DodgerBlue;

            tsmiShowConflictingDrugs.IconChar = IconChar.ExclamationTriangle;
            tsmiShowConflictingDrugs.IconColor = Color.Crimson;

            tsmiShowPrescriptionHistory.IconChar = IconChar.History;
            tsmiShowPrescriptionHistory.IconColor = Color.DarkOrchid;

            tsmiAddDrugToDispense.IconChar = IconChar.PlusCircle;
            tsmiAddDrugToDispense.IconColor = Color.SeaGreen;

            tsmiProductDetails.IconChar = IconChar.InfoCircle;
            tsmiProductDetails.IconColor = Color.DodgerBlue;

            tsmiRemoveDrug.IconChar = IconChar.MinusCircle;
            tsmiRemoveDrug.IconColor = Color.Crimson;

            tsmiClearAllDrugs.IconChar = IconChar.TrashAlt;
            tsmiClearAllDrugs.IconColor = Color.DarkRed;

            tsmiEdit.IconChar = IconChar.Edit;
            tsmiEdit.IconColor = Color.DarkOrange;

            tsmiSearchDrug.IconChar = IconChar.MagnifyingGlass;
            tsmiSearchDrug.IconColor = Color.DarkCyan;

            tsmiRefreshDrugList.IconChar = IconChar.Rotate;
            tsmiRefreshDrugList.IconColor = Color.MediumSeaGreen;
        }
        private void _LoadAvailableDrugBatches()
        {
            List<stDrugBatchInfo> allBatches = clsDrugBL.GetAllDrugBatches();

            var displayList = allBatches
                .GroupBy(b => b.DrugID)
                .SelectMany(g => g.Select((item, index) => new
                {
                    item.DrugID,
                    item.PurchaseInvoiceDetailID,
                    DrugName = item.DrugName,
                    BatchNumber = index + 1,
                    Conflict = item.HasConflict ? "Var" : "Yok",
                    Restricted = item.IsRestricted ? "Reçeteli" : "Reçetesiz"
                }))
                .ToList();

            dgvAvailableDrugs.AutoGenerateColumns = false;
            dgvAvailableDrugs.DataSource = displayList;
        }
        private void _LoadPatientPhones()
        {
            cmbPatientPhones.DataSource = clsPatientBL.GetAllPhones();
        }
        private void _LoadPharmacistAndInvoiceInfo()
        {
            // جلب بيانات الصيدلي الحالي
            stPharmacistInfo currentPharmacist = clsPharmacistBL.GetPharmacistByID(clsCurrentSession.CurrentPharmacistID);
            txtPharmacistFullName.Text = $"{currentPharmacist.FirstName} {currentPharmacist.LastName}".Trim();
            txtPharmacistPhone.Text = currentPharmacist.Phone;

            // 2. ضبط الوقت الحالي
            _invoiceDate = DateTime.Now;

            // الخانة الأولى: (10.05.2026 - 12:55:20)
            txtInvoiceDate.Text = _invoiceDate.ToString("dd.MM.yyyy - HH:mm:ss");

            // الخانة الثانية: (July - Thursday)
            txtInvoiceDateDetail.Text = _invoiceDate.ToString("MMMM - dddd", new System.Globalization.CultureInfo("en-US"));
         
        }
        private void SellDrugScreen_Load(object sender, EventArgs e)
        {

            SetupMenuIcons();

            SetupLabelIcons();

            _LoadAvailableDrugBatches();

            _LoadPatientPhones();

            _LoadPharmacistAndInvoiceInfo();

        }

        private void _RefreshDispensedDrugsGrid()
        {
            dgvDispensedDrugs.AutoGenerateColumns = false;
            dgvDispensedDrugs.DataSource = null; // إعادة تعيين لضمان تحديث الـ DataGridView

            // تحويل القائمة إلى Anonymous Objects لربط أسماء الخصائص مع DataPropertyName للأعمدة
            dgvDispensedDrugs.DataSource = _dispensedDrugsList.Select(item => new
            {
                DrugID = item.DrugID,
                DrugName = item.DrugName,
                PurchaseInvoiceDetailID = item.PurchaseInvoiceDetailID,
                Quantity = item.Quantity,
                UnitPrice = item.UnitPrice,
                TotalPrice = item.TotalPrice
            }).ToList();
        }



        private void tsmiSearchDrug_Click(object sender, EventArgs e)
        {
            using (SearchDrugCmsScreen searchScreen = new SearchDrugCmsScreen())
            {
                searchScreen.ShowDialog();
            }
        }

        private void tsmiViewDrugDetails_Click(object sender, EventArgs e)
        {
            using (ShowDrugDetailsCmsScreen detailsScreen = new ShowDrugDetailsCmsScreen())
            {
                detailsScreen.ShowDialog();
            }
        }

        private void tsmiShowConflictingDrugs_Click(object sender, EventArgs e)
        {
            using (ConflictingDrugsCmsScreen conflictingDrugsScreen = new ConflictingDrugsCmsScreen())
            {
                conflictingDrugsScreen.ShowDialog();
            }
        }

        private void tsmiShowPrescriptionHistory_Click(object sender, EventArgs e)
        {
            using (ArchiveCmsScreen archiveCmsScreen = new ArchiveCmsScreen())
            {
                archiveCmsScreen.ShowDialog();
            }
        }


        private void tsmiAddDrugToDispense_Click(object sender, EventArgs e)
        {
            // 1. التحقق من اختيار مريض أولاً
            if (_currentPatientID == -1)
            {
                MessageBox.Show("Lütfen önce bir hasta seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvAvailableDrugs.CurrentRow == null)
                return;

            // 2. استخراج بيانات الدواء والدفعة من الصف المحدد
            dynamic selectedRow = dgvAvailableDrugs.CurrentRow.DataBoundItem;
            int drugID = selectedRow.DrugID;
            int purchaseInvoiceDetailID = selectedRow.PurchaseInvoiceDetailID;

            // 3. جلب تفاصيل الدواء والدفعة الحالية
            stDrugInfo drugInfo = clsDrugBL.GetAllDrugs().FirstOrDefault(d => d.DrugID == drugID);
            stDrugBatchInfo batchInfo = clsDrugBL.GetAllDrugBatches().FirstOrDefault(b => b.PurchaseInvoiceDetailID == purchaseInvoiceDetailID);

            int availableStock = batchInfo.Quantity;
            decimal unitPurchasePrice = batchInfo.UnitPurchasePrice; // جلب السعر من الدفعة مباشرة

            // 4. التحقق من القيود الزمنيّة للدواء (إذا كان مقيداً Reçeteli)
            if (drugInfo.IsRestricted)
            {
                DateTime? lastDispensingDate = clsDrugBL.GetLastDispensingDate(_currentPatientID, drugID);

                if (lastDispensingDate != null)
                {
                    List<stDispensingHistoryInfo> historyList = clsDrugBL.GetDispensingHistory(_currentPatientID, drugID);

                    if (historyList != null && historyList.Count > 0)
                    {
                        // أخذ آخر كمية تم صرفها (القائمة مرتبة تصاعدياً ASC فالآخر هو الأحدث)
                        int lastQuantity = historyList.Last().Quantity;

                        // حساب الموعد القادم المسموح به للصرف مع المعالجة الآمنة للـ Nullable int
                        int refillDays = drugInfo.RefillIntervalDays ?? 0;
                        DateTime nextAllowedDate = lastDispensingDate.Value.AddDays(refillDays * lastQuantity);

                        // إذا لم يحن الموعد بعد، يمنع الصرف
                        if (DateTime.Now < nextAllowedDate)
                        {
                            MessageBox.Show(
                                $"Bu ilaç şu an verilemez!\n" +
                                $"Hastanın bu ilacı tekrar alabileceği en erken tarih: {nextAllowedDate:dd.MM.yyyy - HH:mm}\n\n" +
                                $"Lütfen hastanın ilaç geçmişini kontrol ediniz.",
                                "Uyarı - İlaç Verilemez",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                            return;
                        }
                    }
                }
            }

            // 5. فتح شاشة الإضافة (AddDrugCmsScreen) بتمرير الأرجومنتات الستة بالترتيب
            using (AddDrugCmsScreen frm = new AddDrugCmsScreen(
                drugInfo,
                purchaseInvoiceDetailID,
                availableStock,
                unitPurchasePrice,
                false,
                1)) // جعلنا التكلفة الابتدائية للكمية 1
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // التحقق من وجود نفس الدفعة في القائمة منعاً للتكرار
                    var existing = _dispensedDrugsList.FirstOrDefault(i => i.PurchaseInvoiceDetailID == frm.ResultPurchaseInvoiceDetailID);

                    if (existing.PurchaseInvoiceDetailID != 0)
                    {
                        MessageBox.Show("Bu ilaç zaten listede mevcut. Lütfen düzenleyin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        // إضافة العنصر إلى القائمة المحلية
                        _dispensedDrugsList.Add((
                            frm.ResultDrugID,
                            drugInfo.DrugName,
                            frm.ResultPurchaseInvoiceDetailID,
                            frm.ResultQuantity,
                            frm.ResultUnitPrice,
                            frm.ResultTotalPrice
                        ));

                        // تحديث الـ DataGridView
                        _RefreshDispensedDrugsGrid();
                    }
                }
            }
        }



        private void tsmiProductDetails_Click(object sender, EventArgs e)
        {
            using (ShowDispenseDrugCmsScreen showDispenseDrugCmsScreen = new ShowDispenseDrugCmsScreen())
            {
                showDispenseDrugCmsScreen.ShowDialog();
            }
        }

        private void btnSearchPatient_Click(object sender, EventArgs e)
        {
            string searchPhone = txtSearchPatientPhone.Text.Trim();

            if (string.IsNullOrEmpty(searchPhone))
            {
                MessageBox.Show("Lütfen aranacak telefon numarasını giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var patient = clsPatientBL.GetPatientByPhone(searchPhone);

            if (patient.PatientID != -1)
            {
                _currentPatientID = patient.PatientID;
                txtPaitentFullName.Text = $"{patient.FirstName} {patient.LastName}".Trim();
                txtPatientPhone.Text = patient.Phone;

                if (cmbPatientPhones.Items.Contains(patient.Phone))
                {
                    cmbPatientPhones.SelectedItem = patient.Phone;
                }
            }
            else
            {
                _currentPatientID = -1;
                txtPaitentFullName.Clear();
                txtPatientPhone.Clear();

                MessageBox.Show("Bu telefon numarasına ait hasta bulunamadı!", "Hasta Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmbPatientPhones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPatientPhones.SelectedItem == null)
                return;

            string selectedPhone = cmbPatientPhones.SelectedItem.ToString();
            var patient = clsPatientBL.GetPatientByPhone(selectedPhone);

            if (patient.PatientID != -1)
            {
                _currentPatientID = patient.PatientID;
                txtPaitentFullName.Text = $"{patient.FirstName} {patient.LastName}".Trim();
                txtPatientPhone.Text = patient.Phone;
            }
            else
            {
                _currentPatientID = -1;
                txtPaitentFullName.Clear();
                txtPatientPhone.Clear();
            }
        }
    }
}
