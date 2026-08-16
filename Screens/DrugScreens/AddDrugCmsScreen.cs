using FontAwesome.Sharp;
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

namespace Pharmacy.Screens.DrugScreens
{
    public partial class AddDrugCmsScreen : Form
    {
        public bool IsEditMode { get; private set; }

        public int ResultQuantity { get; private set; }
        public decimal ResultUnitPrice { get; private set; }
        public decimal ResultTotalPrice { get; private set; }
        public int ResultDrugID { get; private set; }
        public int ResultPurchaseInvoiceDetailID { get; private set; }

        private stDrugInfo _drugInfo;
        private int _purchaseInvoiceDetailID;
        private int _availableStock;

        public AddDrugCmsScreen()
        {
            InitializeComponent();
        }

        public AddDrugCmsScreen(
            stDrugInfo drugInfo,
            int purchaseInvoiceDetailID,
            int availableStock,
            decimal unitPurchasePrice,
            bool isEditMode = false,
            int existingQuantity = 1)
        {
            InitializeComponent();

            IsEditMode = isEditMode;

            _drugInfo = drugInfo;
            _purchaseInvoiceDetailID = purchaseInvoiceDetailID;
            _availableStock = availableStock;

            lblDrugName.Text = drugInfo.DrugName;
            lblRestrictionStatus.Text = drugInfo.IsRestricted ? "Kısıtlı" : "Kısıtlı Değil";

            lblUnitPrice.Text = unitPurchasePrice.ToString("N2");
            lblCurrentStock.Text = availableStock.ToString();

            txtQuantity.Text = isEditMode ? existingQuantity.ToString() : "1";

            // حساب واستدعاء القيم الابتدائية عند فتح الشاشة
            _UpdateCalculatedFields();
        }

        private void _SetupButtonIcons()
        {
            btnAddToInvoice.Image = FontAwesome.Sharp.IconChar.CartPlus.ToBitmap(Color.SeaGreen, 25);
            btnAddToInvoice.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddToInvoice.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddToInvoice.TextAlign = ContentAlignment.MiddleCenter;

            btnCancel.Image = FontAwesome.Sharp.IconChar.Times.ToBitmap(Color.Crimson, 25);
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.TextAlign = ContentAlignment.MiddleCenter;

            btnAddQuantity.Image = FontAwesome.Sharp.IconChar.PlusCircle.ToBitmap(Color.Green, 26);
            btnSubtractQuantity.Image = FontAwesome.Sharp.IconChar.MinusCircle.ToBitmap(Color.Red, 26);
        }

        private void _UpdateCalculatedFields()
        {
            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
            {
                lblTotalPrice.Text = "0.00";
                lblNextDoseDate.Text = _drugInfo.IsRestricted ? "-" : "___";
                return;
            }

            // تصحيح الكمية إذا تجاوزت المتاح يدوياً
            if (quantity > _availableStock)
            {
                MessageBox.Show($"Mevcut stok sınırını aştınız! (Maksimum: {_availableStock})", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantity.Text = _availableStock.ToString();
                quantity = _availableStock;
            }

            if (decimal.TryParse(lblUnitPrice.Text, out decimal unitPrice))
            {
                decimal total = quantity * unitPrice;
                lblTotalPrice.Text = total.ToString("N2");
            }

            if (_drugInfo.IsRestricted)
            {
                lblNextDoseDate.Visible = true;
                int refillDays = _drugInfo.RefillIntervalDays ?? 0;
                DateTime nextDate = DateTime.Now.AddDays(refillDays * quantity);
                lblNextDoseDate.Text = nextDate.ToShortDateString();
            }
            else
            {
                lblNextDoseDate.Text = "___";
            }
        }
        private void AddDrugCmsScreen_Load(object sender, EventArgs e)
        {
            _SetupButtonIcons();
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            // تحديث الحسابات والتاريخ تلقائياً مع كل تغيير في الكتابة داخل النص
            _UpdateCalculatedFields();
        }

        private void btnAddQuantity_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtQuantity.Text, out int currentQuantity))
                currentQuantity = 1;

            if (currentQuantity >= _availableStock)
            {
                MessageBox.Show($"Mevcut stok sınırına ulaştınız! (Maksimum: {_availableStock})", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            currentQuantity++;
            txtQuantity.Text = currentQuantity.ToString();
            _UpdateCalculatedFields();
        }

        private void btnSubtractQuantity_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtQuantity.Text, out int currentQuantity))
                currentQuantity = 1;

            if (currentQuantity <= 1)
            {
                return; // عدم التقليل عن 1
            }

            currentQuantity--;
            txtQuantity.Text = currentQuantity.ToString();
            _UpdateCalculatedFields();
        }

        private void btnAddToInvoice_Click(object sender, EventArgs e)
        {
            // عرض رسالة تأكيد للمستخدم
            DialogResult confirmResult = MessageBox.Show(
                "Bu ilacı faturaya eklemek istediğinizden emin misiniz?",
                "Onay",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // إذا اختار المستخدم "لا"، يتم إلغاء العملية والبقاء في الشاشة
            if (confirmResult != DialogResult.Yes)
            {
                return;
            }

            // إسناد النتائج وإغلاق الشاشة بحالة النجاح
            ResultQuantity = int.Parse(txtQuantity.Text);
            ResultUnitPrice = decimal.Parse(lblUnitPrice.Text);
            ResultTotalPrice = ResultQuantity * ResultUnitPrice;
            ResultDrugID = _drugInfo.DrugID;
            ResultPurchaseInvoiceDetailID = _purchaseInvoiceDetailID;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtQuantity_TextChanged_1(object sender, EventArgs e)
        {
            _UpdateCalculatedFields();
        }
    }
}