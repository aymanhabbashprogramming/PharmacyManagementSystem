namespace Pharmacy.Screens.DrugScreens
{
    partial class PurchasePaymentInfoScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchSupplierByPhone = new System.Windows.Forms.TextBox();
            this.btnSearchSupplier = new System.Windows.Forms.Button();
            this.gbxSupplierInfo = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSupplierEmail = new System.Windows.Forms.TextBox();
            this.txtSupplierPhone = new System.Windows.Forms.TextBox();
            this.txtSupplierFullName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSupplierPhones = new System.Windows.Forms.ComboBox();
            this.gbxPharmacistInfo = new System.Windows.Forms.GroupBox();
            this.txtPharmacistPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPharmacistFullName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.gbxPricingDetails = new System.Windows.Forms.GroupBox();
            this.btnCalculateTotal = new System.Windows.Forms.Button();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.numUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnConfirmAndProceed = new System.Windows.Forms.Button();
            this.btnEditDrugDetails = new System.Windows.Forms.Button();
            this.btnShowDrugDetails = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDrugName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDrugCategory = new System.Windows.Forms.TextBox();
            this.txtRestrictionStatus = new System.Windows.Forms.TextBox();
            this.gbxDrugInfo = new System.Windows.Forms.GroupBox();
            this.txtConsumptionDate = new System.Windows.Forms.TextBox();
            this.gbxSupplierInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbxPharmacistInfo.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbxPricingDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.gbxDrugInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(340, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Satın Alma Ödeme Bilgileri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Telefon No Giriniz";
            // 
            // txtSearchSupplierByPhone
            // 
            this.txtSearchSupplierByPhone.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchSupplierByPhone.Location = new System.Drawing.Point(6, 47);
            this.txtSearchSupplierByPhone.Multiline = true;
            this.txtSearchSupplierByPhone.Name = "txtSearchSupplierByPhone";
            this.txtSearchSupplierByPhone.Size = new System.Drawing.Size(213, 29);
            this.txtSearchSupplierByPhone.TabIndex = 10;
            // 
            // btnSearchSupplier
            // 
            this.btnSearchSupplier.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchSupplier.Location = new System.Drawing.Point(163, 15);
            this.btnSearchSupplier.Name = "btnSearchSupplier";
            this.btnSearchSupplier.Size = new System.Drawing.Size(56, 29);
            this.btnSearchSupplier.TabIndex = 17;
            this.btnSearchSupplier.Text = "Ara";
            this.btnSearchSupplier.UseVisualStyleBackColor = true;
            this.btnSearchSupplier.Click += new System.EventHandler(this.btnSearchSupplier_Click);
            // 
            // gbxSupplierInfo
            // 
            this.gbxSupplierInfo.Controls.Add(this.panel1);
            this.gbxSupplierInfo.Controls.Add(this.label5);
            this.gbxSupplierInfo.Controls.Add(this.cmbSupplierPhones);
            this.gbxSupplierInfo.Controls.Add(this.txtSearchSupplierByPhone);
            this.gbxSupplierInfo.Controls.Add(this.label1);
            this.gbxSupplierInfo.Controls.Add(this.btnSearchSupplier);
            this.gbxSupplierInfo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSupplierInfo.Location = new System.Drawing.Point(12, 46);
            this.gbxSupplierInfo.Name = "gbxSupplierInfo";
            this.gbxSupplierInfo.Size = new System.Drawing.Size(450, 200);
            this.gbxSupplierInfo.TabIndex = 18;
            this.gbxSupplierInfo.TabStop = false;
            this.gbxSupplierInfo.Text = "Tedarikçi Bilgileri";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtSupplierEmail);
            this.panel1.Controls.Add(this.txtSupplierPhone);
            this.panel1.Controls.Add(this.txtSupplierFullName);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 113);
            this.panel1.TabIndex = 19;
            // 
            // txtSupplierEmail
            // 
            this.txtSupplierEmail.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierEmail.Location = new System.Drawing.Point(99, 39);
            this.txtSupplierEmail.Multiline = true;
            this.txtSupplierEmail.Name = "txtSupplierEmail";
            this.txtSupplierEmail.ReadOnly = true;
            this.txtSupplierEmail.Size = new System.Drawing.Size(337, 29);
            this.txtSupplierEmail.TabIndex = 28;
            // 
            // txtSupplierPhone
            // 
            this.txtSupplierPhone.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierPhone.Location = new System.Drawing.Point(99, 75);
            this.txtSupplierPhone.Multiline = true;
            this.txtSupplierPhone.Name = "txtSupplierPhone";
            this.txtSupplierPhone.ReadOnly = true;
            this.txtSupplierPhone.Size = new System.Drawing.Size(337, 29);
            this.txtSupplierPhone.TabIndex = 27;
            // 
            // txtSupplierFullName
            // 
            this.txtSupplierFullName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierFullName.Location = new System.Drawing.Point(99, 3);
            this.txtSupplierFullName.Multiline = true;
            this.txtSupplierFullName.Name = "txtSupplierFullName";
            this.txtSupplierFullName.ReadOnly = true;
            this.txtSupplierFullName.Size = new System.Drawing.Size(337, 29);
            this.txtSupplierFullName.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Telefon No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "E-posta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Ad-Soyad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(248, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Telefon No Seç";
            // 
            // cmbSupplierPhones
            // 
            this.cmbSupplierPhones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSupplierPhones.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSupplierPhones.FormattingEnabled = true;
            this.cmbSupplierPhones.Location = new System.Drawing.Point(248, 49);
            this.cmbSupplierPhones.Name = "cmbSupplierPhones";
            this.cmbSupplierPhones.Size = new System.Drawing.Size(196, 27);
            this.cmbSupplierPhones.TabIndex = 20;
            this.cmbSupplierPhones.SelectedIndexChanged += new System.EventHandler(this.cmbSupplierPhones_SelectedIndexChanged);
            // 
            // gbxPharmacistInfo
            // 
            this.gbxPharmacistInfo.Controls.Add(this.txtPharmacistPhone);
            this.gbxPharmacistInfo.Controls.Add(this.label8);
            this.gbxPharmacistInfo.Controls.Add(this.txtPharmacistFullName);
            this.gbxPharmacistInfo.Controls.Add(this.label7);
            this.gbxPharmacistInfo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPharmacistInfo.Location = new System.Drawing.Point(480, 46);
            this.gbxPharmacistInfo.Name = "gbxPharmacistInfo";
            this.gbxPharmacistInfo.Size = new System.Drawing.Size(443, 98);
            this.gbxPharmacistInfo.TabIndex = 19;
            this.gbxPharmacistInfo.TabStop = false;
            this.gbxPharmacistInfo.Text = "Eczacı Bilgileri";
            // 
            // txtPharmacistPhone
            // 
            this.txtPharmacistPhone.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPharmacistPhone.Location = new System.Drawing.Point(100, 56);
            this.txtPharmacistPhone.Multiline = true;
            this.txtPharmacistPhone.Name = "txtPharmacistPhone";
            this.txtPharmacistPhone.ReadOnly = true;
            this.txtPharmacistPhone.Size = new System.Drawing.Size(333, 29);
            this.txtPharmacistPhone.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Telefon No";
            // 
            // txtPharmacistFullName
            // 
            this.txtPharmacistFullName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPharmacistFullName.Location = new System.Drawing.Point(100, 21);
            this.txtPharmacistFullName.Multiline = true;
            this.txtPharmacistFullName.Name = "txtPharmacistFullName";
            this.txtPharmacistFullName.ReadOnly = true;
            this.txtPharmacistFullName.Size = new System.Drawing.Size(333, 29);
            this.txtPharmacistFullName.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Ad-Soyad";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpInvoiceDate);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(480, 170);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(443, 76);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fatura Tarihi";
            // 
            // dtpInvoiceDate
            // 
            this.dtpInvoiceDate.Enabled = false;
            this.dtpInvoiceDate.Location = new System.Drawing.Point(10, 36);
            this.dtpInvoiceDate.Name = "dtpInvoiceDate";
            this.dtpInvoiceDate.Size = new System.Drawing.Size(423, 27);
            this.dtpInvoiceDate.TabIndex = 31;
            // 
            // gbxPricingDetails
            // 
            this.gbxPricingDetails.Controls.Add(this.btnCalculateTotal);
            this.gbxPricingDetails.Controls.Add(this.txtTotalPrice);
            this.gbxPricingDetails.Controls.Add(this.label11);
            this.gbxPricingDetails.Controls.Add(this.dtpExpiryDate);
            this.gbxPricingDetails.Controls.Add(this.label10);
            this.gbxPricingDetails.Controls.Add(this.numUnitPrice);
            this.gbxPricingDetails.Controls.Add(this.label9);
            this.gbxPricingDetails.Controls.Add(this.numQuantity);
            this.gbxPricingDetails.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPricingDetails.Location = new System.Drawing.Point(12, 265);
            this.gbxPricingDetails.Name = "gbxPricingDetails";
            this.gbxPricingDetails.Size = new System.Drawing.Size(450, 191);
            this.gbxPricingDetails.TabIndex = 32;
            this.gbxPricingDetails.TabStop = false;
            this.gbxPricingDetails.Text = "Fiyat ve Miktar Bilgileri";
            // 
            // btnCalculateTotal
            // 
            this.btnCalculateTotal.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateTotal.Location = new System.Drawing.Point(12, 151);
            this.btnCalculateTotal.Name = "btnCalculateTotal";
            this.btnCalculateTotal.Size = new System.Drawing.Size(164, 29);
            this.btnCalculateTotal.TabIndex = 41;
            this.btnCalculateTotal.Text = "Toplamı Hesapla";
            this.btnCalculateTotal.UseVisualStyleBackColor = true;
            this.btnCalculateTotal.Click += new System.EventHandler(this.btnCalculateTotal_Click);
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.Location = new System.Drawing.Point(193, 149);
            this.txtTotalPrice.Multiline = true;
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(247, 29);
            this.txtTotalPrice.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 20);
            this.label11.TabIndex = 33;
            this.label11.Text = "Tüketim Tarihi";
            // 
            // dtpExpiryDate
            // 
            this.dtpExpiryDate.Location = new System.Drawing.Point(129, 26);
            this.dtpExpiryDate.Name = "dtpExpiryDate";
            this.dtpExpiryDate.Size = new System.Drawing.Size(311, 27);
            this.dtpExpiryDate.TabIndex = 32;
            this.dtpExpiryDate.ValueChanged += new System.EventHandler(this.dtpExpiryDate_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "Birim Fiyatı";
            // 
            // numUnitPrice
            // 
            this.numUnitPrice.DecimalPlaces = 2;
            this.numUnitPrice.Location = new System.Drawing.Point(129, 108);
            this.numUnitPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numUnitPrice.Name = "numUnitPrice";
            this.numUnitPrice.Size = new System.Drawing.Size(311, 27);
            this.numUnitPrice.TabIndex = 23;
            this.numUnitPrice.ThousandsSeparator = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Miktar";
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(129, 67);
            this.numQuantity.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(311, 27);
            this.numQuantity.TabIndex = 0;
            // 
            // btnConfirmAndProceed
            // 
            this.btnConfirmAndProceed.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmAndProceed.Location = new System.Drawing.Point(480, 471);
            this.btnConfirmAndProceed.Name = "btnConfirmAndProceed";
            this.btnConfirmAndProceed.Size = new System.Drawing.Size(289, 43);
            this.btnConfirmAndProceed.TabIndex = 37;
            this.btnConfirmAndProceed.Text = "Onayla Ve Faturayı Kaydet";
            this.btnConfirmAndProceed.UseVisualStyleBackColor = true;
            this.btnConfirmAndProceed.Click += new System.EventHandler(this.btnConfirmAndProceed_Click);
            // 
            // btnEditDrugDetails
            // 
            this.btnEditDrugDetails.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditDrugDetails.Location = new System.Drawing.Point(251, 471);
            this.btnEditDrugDetails.Name = "btnEditDrugDetails";
            this.btnEditDrugDetails.Size = new System.Drawing.Size(211, 43);
            this.btnEditDrugDetails.TabIndex = 38;
            this.btnEditDrugDetails.Text = "İlaç Bilgilerini Düzelt";
            this.btnEditDrugDetails.UseVisualStyleBackColor = true;
            this.btnEditDrugDetails.Click += new System.EventHandler(this.btnEditDrugDetails_Click);
            // 
            // btnShowDrugDetails
            // 
            this.btnShowDrugDetails.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDrugDetails.Location = new System.Drawing.Point(12, 471);
            this.btnShowDrugDetails.Name = "btnShowDrugDetails";
            this.btnShowDrugDetails.Size = new System.Drawing.Size(216, 43);
            this.btnShowDrugDetails.TabIndex = 39;
            this.btnShowDrugDetails.Text = "İlaç Bilgilerini Göster";
            this.btnShowDrugDetails.UseVisualStyleBackColor = true;
            this.btnShowDrugDetails.Click += new System.EventHandler(this.btnShowDrugDetails_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(777, 471);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(148, 43);
            this.btnCancel.TabIndex = 40;
            this.btnCancel.Text = "İşlemi İptal Et";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(11, 117);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(117, 20);
            this.label15.TabIndex = 33;
            this.label15.Text = "Tüketim Tarihi";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(11, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 20);
            this.label13.TabIndex = 36;
            this.label13.Text = "İlaç Adı";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(11, 155);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 20);
            this.label14.TabIndex = 30;
            this.label14.Text = "Durumu";
            // 
            // txtDrugName
            // 
            this.txtDrugName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrugName.Location = new System.Drawing.Point(140, 27);
            this.txtDrugName.Multiline = true;
            this.txtDrugName.Name = "txtDrugName";
            this.txtDrugName.ReadOnly = true;
            this.txtDrugName.Size = new System.Drawing.Size(290, 29);
            this.txtDrugName.TabIndex = 31;
            this.txtDrugName.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(11, 73);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 20);
            this.label16.TabIndex = 37;
            this.label16.Text = "Kategori";
            // 
            // txtDrugCategory
            // 
            this.txtDrugCategory.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrugCategory.Location = new System.Drawing.Point(140, 69);
            this.txtDrugCategory.Multiline = true;
            this.txtDrugCategory.Name = "txtDrugCategory";
            this.txtDrugCategory.ReadOnly = true;
            this.txtDrugCategory.Size = new System.Drawing.Size(290, 29);
            this.txtDrugCategory.TabIndex = 38;
            this.txtDrugCategory.TabStop = false;
            // 
            // txtRestrictionStatus
            // 
            this.txtRestrictionStatus.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRestrictionStatus.Location = new System.Drawing.Point(140, 151);
            this.txtRestrictionStatus.Multiline = true;
            this.txtRestrictionStatus.Name = "txtRestrictionStatus";
            this.txtRestrictionStatus.ReadOnly = true;
            this.txtRestrictionStatus.Size = new System.Drawing.Size(290, 29);
            this.txtRestrictionStatus.TabIndex = 39;
            this.txtRestrictionStatus.TabStop = false;
            // 
            // gbxDrugInfo
            // 
            this.gbxDrugInfo.Controls.Add(this.txtConsumptionDate);
            this.gbxDrugInfo.Controls.Add(this.txtRestrictionStatus);
            this.gbxDrugInfo.Controls.Add(this.txtDrugCategory);
            this.gbxDrugInfo.Controls.Add(this.label16);
            this.gbxDrugInfo.Controls.Add(this.txtDrugName);
            this.gbxDrugInfo.Controls.Add(this.label14);
            this.gbxDrugInfo.Controls.Add(this.label13);
            this.gbxDrugInfo.Controls.Add(this.label15);
            this.gbxDrugInfo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDrugInfo.Location = new System.Drawing.Point(480, 265);
            this.gbxDrugInfo.Name = "gbxDrugInfo";
            this.gbxDrugInfo.Size = new System.Drawing.Size(443, 191);
            this.gbxDrugInfo.TabIndex = 34;
            this.gbxDrugInfo.TabStop = false;
            this.gbxDrugInfo.Text = "İlaç Bilgileri";
            // 
            // txtConsumptionDate
            // 
            this.txtConsumptionDate.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsumptionDate.Location = new System.Drawing.Point(140, 109);
            this.txtConsumptionDate.Multiline = true;
            this.txtConsumptionDate.Name = "txtConsumptionDate";
            this.txtConsumptionDate.ReadOnly = true;
            this.txtConsumptionDate.Size = new System.Drawing.Size(290, 29);
            this.txtConsumptionDate.TabIndex = 40;
            this.txtConsumptionDate.TabStop = false;
            // 
            // PurchasePaymentInfoScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(937, 535);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnShowDrugDetails);
            this.Controls.Add(this.btnEditDrugDetails);
            this.Controls.Add(this.gbxDrugInfo);
            this.Controls.Add(this.btnConfirmAndProceed);
            this.Controls.Add(this.gbxPricingDetails);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbxPharmacistInfo);
            this.Controls.Add(this.gbxSupplierInfo);
            this.Controls.Add(this.label4);
            this.Name = "PurchasePaymentInfoScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurchasePaymentInfoScreen";
            this.Load += new System.EventHandler(this.PurchasePaymentInfoScreen_Load);
            this.gbxSupplierInfo.ResumeLayout(false);
            this.gbxSupplierInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbxPharmacistInfo.ResumeLayout(false);
            this.gbxPharmacistInfo.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.gbxPricingDetails.ResumeLayout(false);
            this.gbxPricingDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.gbxDrugInfo.ResumeLayout(false);
            this.gbxDrugInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchSupplierByPhone;
        private System.Windows.Forms.Button btnSearchSupplier;
        private System.Windows.Forms.GroupBox gbxSupplierInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSupplierPhones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSupplierFullName;
        private System.Windows.Forms.TextBox txtSupplierEmail;
        private System.Windows.Forms.TextBox txtSupplierPhone;
        private System.Windows.Forms.GroupBox gbxPharmacistInfo;
        private System.Windows.Forms.TextBox txtPharmacistPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPharmacistFullName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpInvoiceDate;
        private System.Windows.Forms.GroupBox gbxPricingDetails;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpExpiryDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numUnitPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnConfirmAndProceed;
        private System.Windows.Forms.Button btnEditDrugDetails;
        private System.Windows.Forms.Button btnShowDrugDetails;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDrugName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtDrugCategory;
        private System.Windows.Forms.TextBox txtRestrictionStatus;
        private System.Windows.Forms.GroupBox gbxDrugInfo;
        private System.Windows.Forms.TextBox txtConsumptionDate;
        private System.Windows.Forms.Button btnCalculateTotal;
    }
}