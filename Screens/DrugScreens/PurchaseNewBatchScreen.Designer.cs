namespace Pharmacy.Screens.DrugScreens
{
    partial class PurchaseNewBatchScreen
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbNamesOfDrugs = new System.Windows.Forms.ComboBox();
            this.txtDrugNameToSearch = new System.Windows.Forms.TextBox();
            this.btnSearchDrug = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSupplierEmail = new System.Windows.Forms.TextBox();
            this.txtSupplierPhone = new System.Windows.Forms.TextBox();
            this.txtSupplierFullName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbSupplierPhones = new System.Windows.Forms.ComboBox();
            this.txtSearchSupplierPhone = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSearchSupplier = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.lblCurrentStockValue = new System.Windows.Forms.Label();
            this.gbxPricingDetails = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.btnCalculateTotal = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.nudNewQuantity = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClearDrugSelection = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dtpInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.gbxPharmacistInfo = new System.Windows.Forms.GroupBox();
            this.txtPharmacistPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPharmacistFullName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveInvoice = new System.Windows.Forms.Button();
            this.dgvInvoiceItems = new System.Windows.Forms.DataGridView();
            this.RowNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDrugName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsInvoiceItems2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiDeleteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddDrugToInvoice = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbxPricingDetails.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewQuantity)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbxPharmacistInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceItems)).BeginInit();
            this.cmsInvoiceItems2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(422, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yeni Stok Girişi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "İlaç Adı İle Ara";
            // 
            // cmbNamesOfDrugs
            // 
            this.cmbNamesOfDrugs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNamesOfDrugs.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNamesOfDrugs.FormattingEnabled = true;
            this.cmbNamesOfDrugs.Location = new System.Drawing.Point(6, 104);
            this.cmbNamesOfDrugs.Name = "cmbNamesOfDrugs";
            this.cmbNamesOfDrugs.Size = new System.Drawing.Size(235, 27);
            this.cmbNamesOfDrugs.TabIndex = 20;
            this.cmbNamesOfDrugs.SelectedIndexChanged += new System.EventHandler(this.cmbNamesOfDrugs_SelectedIndexChanged);
            // 
            // txtDrugNameToSearch
            // 
            this.txtDrugNameToSearch.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrugNameToSearch.Location = new System.Drawing.Point(6, 36);
            this.txtDrugNameToSearch.Multiline = true;
            this.txtDrugNameToSearch.Name = "txtDrugNameToSearch";
            this.txtDrugNameToSearch.Size = new System.Drawing.Size(235, 29);
            this.txtDrugNameToSearch.TabIndex = 10;
            // 
            // btnSearchDrug
            // 
            this.btnSearchDrug.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchDrug.Location = new System.Drawing.Point(145, 3);
            this.btnSearchDrug.Name = "btnSearchDrug";
            this.btnSearchDrug.Size = new System.Drawing.Size(96, 30);
            this.btnSearchDrug.TabIndex = 17;
            this.btnSearchDrug.Text = "Ara";
            this.btnSearchDrug.UseVisualStyleBackColor = true;
            this.btnSearchDrug.Click += new System.EventHandler(this.btnSearchDrug_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cmbSupplierPhones);
            this.groupBox1.Controls.Add(this.txtSearchSupplierPhone);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.btnSearchSupplier);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 200);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tedarikçi Bilgileri";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtSupplierEmail);
            this.panel2.Controls.Add(this.txtSupplierPhone);
            this.panel2.Controls.Add(this.txtSupplierFullName);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(444, 113);
            this.panel2.TabIndex = 19;
            // 
            // txtSupplierEmail
            // 
            this.txtSupplierEmail.BackColor = System.Drawing.Color.White;
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
            this.txtSupplierPhone.BackColor = System.Drawing.Color.White;
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
            this.txtSupplierFullName.BackColor = System.Drawing.Color.White;
            this.txtSupplierFullName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierFullName.Location = new System.Drawing.Point(99, 3);
            this.txtSupplierFullName.Multiline = true;
            this.txtSupplierFullName.Name = "txtSupplierFullName";
            this.txtSupplierFullName.ReadOnly = true;
            this.txtSupplierFullName.Size = new System.Drawing.Size(337, 29);
            this.txtSupplierFullName.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(2, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Telefon No";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(2, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "E-posta";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(2, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Ad-Soyad";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(248, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Telefon No Seç";
            // 
            // cmbSupplierPhones
            // 
            this.cmbSupplierPhones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSupplierPhones.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSupplierPhones.FormattingEnabled = true;
            this.cmbSupplierPhones.Location = new System.Drawing.Point(244, 49);
            this.cmbSupplierPhones.Name = "cmbSupplierPhones";
            this.cmbSupplierPhones.Size = new System.Drawing.Size(196, 27);
            this.cmbSupplierPhones.TabIndex = 20;
            this.cmbSupplierPhones.SelectedIndexChanged += new System.EventHandler(this.cmbSupplierPhones_SelectedIndexChanged);
            // 
            // txtSearchSupplierPhone
            // 
            this.txtSearchSupplierPhone.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchSupplierPhone.Location = new System.Drawing.Point(6, 47);
            this.txtSearchSupplierPhone.Multiline = true;
            this.txtSearchSupplierPhone.Name = "txtSearchSupplierPhone";
            this.txtSearchSupplierPhone.Size = new System.Drawing.Size(213, 29);
            this.txtSearchSupplierPhone.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "Telefon No Giriniz";
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
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 140);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 22);
            this.label13.TabIndex = 22;
            this.label13.Text = "Mevcut Stok : ";
            // 
            // lblCurrentStockValue
            // 
            this.lblCurrentStockValue.AutoSize = true;
            this.lblCurrentStockValue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentStockValue.Location = new System.Drawing.Point(150, 140);
            this.lblCurrentStockValue.Name = "lblCurrentStockValue";
            this.lblCurrentStockValue.Size = new System.Drawing.Size(60, 22);
            this.lblCurrentStockValue.TabIndex = 23;
            this.lblCurrentStockValue.Text = "10000";
            // 
            // gbxPricingDetails
            // 
            this.gbxPricingDetails.Controls.Add(this.panel3);
            this.gbxPricingDetails.Controls.Add(this.panel1);
            this.gbxPricingDetails.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPricingDetails.Location = new System.Drawing.Point(12, 256);
            this.gbxPricingDetails.Name = "gbxPricingDetails";
            this.gbxPricingDetails.Size = new System.Drawing.Size(271, 361);
            this.gbxPricingDetails.TabIndex = 33;
            this.gbxPricingDetails.TabStop = false;
            this.gbxPricingDetails.Text = "Yeni Stok Bilgleri";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.numUnitPrice);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtTotalPrice);
            this.panel3.Controls.Add(this.btnCalculateTotal);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.nudNewQuantity);
            this.panel3.Location = new System.Drawing.Point(7, 203);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(255, 150);
            this.panel3.TabIndex = 43;
            // 
            // numUnitPrice
            // 
            this.numUnitPrice.DecimalPlaces = 2;
            this.numUnitPrice.Location = new System.Drawing.Point(110, 39);
            this.numUnitPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numUnitPrice.Name = "numUnitPrice";
            this.numUnitPrice.Size = new System.Drawing.Size(136, 27);
            this.numUnitPrice.TabIndex = 23;
            this.numUnitPrice.ThousandsSeparator = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Birim Fiyatı";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.BackColor = System.Drawing.Color.White;
            this.txtTotalPrice.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.Location = new System.Drawing.Point(10, 111);
            this.txtTotalPrice.Multiline = true;
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(235, 29);
            this.txtTotalPrice.TabIndex = 31;
            // 
            // btnCalculateTotal
            // 
            this.btnCalculateTotal.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateTotal.Location = new System.Drawing.Point(9, 76);
            this.btnCalculateTotal.Name = "btnCalculateTotal";
            this.btnCalculateTotal.Size = new System.Drawing.Size(235, 29);
            this.btnCalculateTotal.TabIndex = 41;
            this.btnCalculateTotal.Text = "Toplamı Hesapla";
            this.btnCalculateTotal.UseVisualStyleBackColor = true;
            this.btnCalculateTotal.Click += new System.EventHandler(this.btnCalculateTotal_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Yeni Miktar";
            // 
            // nudNewQuantity
            // 
            this.nudNewQuantity.Location = new System.Drawing.Point(110, 6);
            this.nudNewQuantity.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudNewQuantity.Name = "nudNewQuantity";
            this.nudNewQuantity.Size = new System.Drawing.Size(136, 27);
            this.nudNewQuantity.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnClearDrugSelection);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblCurrentStockValue);
            this.panel1.Controls.Add(this.txtDrugNameToSearch);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnSearchDrug);
            this.panel1.Controls.Add(this.cmbNamesOfDrugs);
            this.panel1.Location = new System.Drawing.Point(7, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 171);
            this.panel1.TabIndex = 42;
            // 
            // btnClearDrugSelection
            // 
            this.btnClearDrugSelection.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearDrugSelection.Location = new System.Drawing.Point(145, 71);
            this.btnClearDrugSelection.Name = "btnClearDrugSelection";
            this.btnClearDrugSelection.Size = new System.Drawing.Size(96, 30);
            this.btnClearDrugSelection.TabIndex = 25;
            this.btnClearDrugSelection.Text = "Temizle";
            this.btnClearDrugSelection.UseVisualStyleBackColor = true;
            this.btnClearDrugSelection.Click += new System.EventHandler(this.btnClearDrugSelection_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 19);
            this.label6.TabIndex = 24;
            this.label6.Text = "Listeden İlaç Seç";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Tüketim Tarihi";
            // 
            // dtpExpiryDate
            // 
            this.dtpExpiryDate.Location = new System.Drawing.Point(141, 60);
            this.dtpExpiryDate.Name = "dtpExpiryDate";
            this.dtpExpiryDate.Size = new System.Drawing.Size(296, 27);
            this.dtpExpiryDate.TabIndex = 32;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.dtpInvoiceDate);
            this.groupBox3.Controls.Add(this.dtpExpiryDate);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(482, 154);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(443, 96);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fatura ve İlaç Tüketim Tarihi";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 29);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(102, 20);
            this.label16.TabIndex = 34;
            this.label16.Text = "Fatura Tarihi";
            // 
            // dtpInvoiceDate
            // 
            this.dtpInvoiceDate.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpInvoiceDate.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dtpInvoiceDate.Enabled = false;
            this.dtpInvoiceDate.Location = new System.Drawing.Point(141, 26);
            this.dtpInvoiceDate.Name = "dtpInvoiceDate";
            this.dtpInvoiceDate.Size = new System.Drawing.Size(296, 27);
            this.dtpInvoiceDate.TabIndex = 31;
            // 
            // gbxPharmacistInfo
            // 
            this.gbxPharmacistInfo.Controls.Add(this.txtPharmacistPhone);
            this.gbxPharmacistInfo.Controls.Add(this.label7);
            this.gbxPharmacistInfo.Controls.Add(this.txtPharmacistFullName);
            this.gbxPharmacistInfo.Controls.Add(this.label15);
            this.gbxPharmacistInfo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPharmacistInfo.Location = new System.Drawing.Point(482, 50);
            this.gbxPharmacistInfo.Name = "gbxPharmacistInfo";
            this.gbxPharmacistInfo.Size = new System.Drawing.Size(443, 98);
            this.gbxPharmacistInfo.TabIndex = 34;
            this.gbxPharmacistInfo.TabStop = false;
            this.gbxPharmacistInfo.Text = "Eczacı Bilgileri";
            // 
            // txtPharmacistPhone
            // 
            this.txtPharmacistPhone.BackColor = System.Drawing.Color.White;
            this.txtPharmacistPhone.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPharmacistPhone.Location = new System.Drawing.Point(100, 56);
            this.txtPharmacistPhone.Multiline = true;
            this.txtPharmacistPhone.Name = "txtPharmacistPhone";
            this.txtPharmacistPhone.ReadOnly = true;
            this.txtPharmacistPhone.Size = new System.Drawing.Size(333, 29);
            this.txtPharmacistPhone.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Telefon No";
            // 
            // txtPharmacistFullName
            // 
            this.txtPharmacistFullName.BackColor = System.Drawing.Color.White;
            this.txtPharmacistFullName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPharmacistFullName.Location = new System.Drawing.Point(100, 21);
            this.txtPharmacistFullName.Multiline = true;
            this.txtPharmacistFullName.Name = "txtPharmacistFullName";
            this.txtPharmacistFullName.ReadOnly = true;
            this.txtPharmacistFullName.Size = new System.Drawing.Size(333, 29);
            this.txtPharmacistFullName.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 20);
            this.label15.TabIndex = 24;
            this.label15.Text = "Ad-Soyad";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(846, 574);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(79, 43);
            this.btnCancel.TabIndex = 41;
            this.btnCancel.Text = "İptal Et";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveInvoice
            // 
            this.btnSaveInvoice.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveInvoice.Location = new System.Drawing.Point(664, 574);
            this.btnSaveInvoice.Name = "btnSaveInvoice";
            this.btnSaveInvoice.Size = new System.Drawing.Size(164, 43);
            this.btnSaveInvoice.TabIndex = 42;
            this.btnSaveInvoice.Text = "Faturayı Kaydet";
            this.btnSaveInvoice.UseVisualStyleBackColor = true;
            this.btnSaveInvoice.Click += new System.EventHandler(this.btnSaveInvoice_Click);
            // 
            // dgvInvoiceItems
            // 
            this.dgvInvoiceItems.AllowUserToAddRows = false;
            this.dgvInvoiceItems.AllowUserToDeleteRows = false;
            this.dgvInvoiceItems.AllowUserToResizeColumns = false;
            this.dgvInvoiceItems.AllowUserToResizeRows = false;
            this.dgvInvoiceItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoiceItems.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvInvoiceItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoiceItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInvoiceItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoiceItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowNumber,
            this.colDrugName,
            this.colQuantity,
            this.colUnitPrice,
            this.colTotalPrice});
            this.dgvInvoiceItems.ContextMenuStrip = this.cmsInvoiceItems2;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInvoiceItems.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInvoiceItems.EnableHeadersVisualStyles = false;
            this.dgvInvoiceItems.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgvInvoiceItems.Location = new System.Drawing.Point(294, 297);
            this.dgvInvoiceItems.MultiSelect = false;
            this.dgvInvoiceItems.Name = "dgvInvoiceItems";
            this.dgvInvoiceItems.ReadOnly = true;
            this.dgvInvoiceItems.RowHeadersVisible = false;
            this.dgvInvoiceItems.RowHeadersWidth = 51;
            this.dgvInvoiceItems.RowTemplate.Height = 24;
            this.dgvInvoiceItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoiceItems.Size = new System.Drawing.Size(631, 268);
            this.dgvInvoiceItems.TabIndex = 43;
            // 
            // RowNumber
            // 
            this.RowNumber.DataPropertyName = "RowNumber";
            this.RowNumber.HeaderText = "Ürün No";
            this.RowNumber.MinimumWidth = 6;
            this.RowNumber.Name = "RowNumber";
            this.RowNumber.ReadOnly = true;
            this.RowNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colDrugName
            // 
            this.colDrugName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colDrugName.DataPropertyName = "DrugName";
            this.colDrugName.FillWeight = 106.9519F;
            this.colDrugName.HeaderText = "İlaç Adı";
            this.colDrugName.MinimumWidth = 6;
            this.colDrugName.Name = "colDrugName";
            this.colDrugName.ReadOnly = true;
            this.colDrugName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colDrugName.Width = 200;
            // 
            // colQuantity
            // 
            this.colQuantity.DataPropertyName = "Quantity";
            this.colQuantity.FillWeight = 97.6827F;
            this.colQuantity.HeaderText = "Miktar";
            this.colQuantity.MinimumWidth = 6;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            this.colQuantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.DataPropertyName = "UnitPrice";
            this.colUnitPrice.FillWeight = 97.6827F;
            this.colUnitPrice.HeaderText = "Birim Fiyatı";
            this.colUnitPrice.MinimumWidth = 6;
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.ReadOnly = true;
            this.colUnitPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colTotalPrice
            // 
            this.colTotalPrice.DataPropertyName = "TotalPrice";
            this.colTotalPrice.FillWeight = 97.6827F;
            this.colTotalPrice.HeaderText = "Toplam";
            this.colTotalPrice.MinimumWidth = 6;
            this.colTotalPrice.Name = "colTotalPrice";
            this.colTotalPrice.ReadOnly = true;
            this.colTotalPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cmsInvoiceItems2
            // 
            this.cmsInvoiceItems2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsInvoiceItems2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDeleteItem,
            this.tsmiEditItem});
            this.cmsInvoiceItems2.Name = "contextMenuStrip1";
            this.cmsInvoiceItems2.Size = new System.Drawing.Size(155, 56);
            // 
            // tsmiDeleteItem
            // 
            this.tsmiDeleteItem.BackColor = System.Drawing.SystemColors.Info;
            this.tsmiDeleteItem.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiDeleteItem.ForeColor = System.Drawing.Color.Black;
            this.tsmiDeleteItem.Image = global::Pharmacy.Properties.Resources.DeleteIcon;
            this.tsmiDeleteItem.Name = "tsmiDeleteItem";
            this.tsmiDeleteItem.Size = new System.Drawing.Size(154, 26);
            this.tsmiDeleteItem.Text = "Ürün Sil ";
            this.tsmiDeleteItem.Click += new System.EventHandler(this.tsmiDeleteItem_Click);
            // 
            // tsmiEditItem
            // 
            this.tsmiEditItem.BackColor = System.Drawing.SystemColors.Info;
            this.tsmiEditItem.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F);
            this.tsmiEditItem.Image = global::Pharmacy.Properties.Resources.images;
            this.tsmiEditItem.Name = "tsmiEditItem";
            this.tsmiEditItem.Size = new System.Drawing.Size(154, 26);
            this.tsmiEditItem.Text = "Düzelt";
            this.tsmiEditItem.Click += new System.EventHandler(this.tsmiEditItem_Click);
            // 
            // btnAddDrugToInvoice
            // 
            this.btnAddDrugToInvoice.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDrugToInvoice.Location = new System.Drawing.Point(294, 574);
            this.btnAddDrugToInvoice.Name = "btnAddDrugToInvoice";
            this.btnAddDrugToInvoice.Size = new System.Drawing.Size(192, 43);
            this.btnAddDrugToInvoice.TabIndex = 45;
            this.btnAddDrugToInvoice.Text = "Faturaya İlaç Ekle";
            this.btnAddDrugToInvoice.UseVisualStyleBackColor = true;
            this.btnAddDrugToInvoice.Click += new System.EventHandler(this.btnAddDrugToInvoice_Click);
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Silver;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(293, 266);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(631, 28);
            this.label17.TabIndex = 46;
            this.label17.Text = "Fatura İçeriği";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PurchaseNewBatchScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(936, 629);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnAddDrugToInvoice);
            this.Controls.Add(this.dgvInvoiceItems);
            this.Controls.Add(this.btnSaveInvoice);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbxPharmacistInfo);
            this.Controls.Add(this.gbxPricingDetails);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "PurchaseNewBatchScreen";
            this.Text = "PurchaseNewBatchScreen";
            this.Load += new System.EventHandler(this.PurchaseNewBatchScreen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbxPricingDetails.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewQuantity)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbxPharmacistInfo.ResumeLayout(false);
            this.gbxPharmacistInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceItems)).EndInit();
            this.cmsInvoiceItems2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbNamesOfDrugs;
        private System.Windows.Forms.TextBox txtDrugNameToSearch;
        private System.Windows.Forms.Button btnSearchDrug;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSupplierEmail;
        private System.Windows.Forms.TextBox txtSupplierPhone;
        private System.Windows.Forms.TextBox txtSupplierFullName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbSupplierPhones;
        private System.Windows.Forms.TextBox txtSearchSupplierPhone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSearchSupplier;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblCurrentStockValue;
        private System.Windows.Forms.GroupBox gbxPricingDetails;
        private System.Windows.Forms.Button btnCalculateTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpExpiryDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numUnitPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudNewQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpInvoiceDate;
        private System.Windows.Forms.GroupBox gbxPharmacistInfo;
        private System.Windows.Forms.TextBox txtPharmacistPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPharmacistFullName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveInvoice;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvInvoiceItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDrugName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalPrice;
        private System.Windows.Forms.Button btnAddDrugToInvoice;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ContextMenuStrip cmsInvoiceItems2;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteItem;
        private System.Windows.Forms.Button btnClearDrugSelection;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditItem;
    }
}