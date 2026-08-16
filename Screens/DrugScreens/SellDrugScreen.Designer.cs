namespace Pharmacy.Screens.DrugScreens
{
    partial class SellDrugScreen
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPatientPhone = new System.Windows.Forms.TextBox();
            this.txtPaitentFullName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbPatientPhones = new System.Windows.Forms.ComboBox();
            this.txtSearchPatientPhone = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSearchPatient = new System.Windows.Forms.Button();
            this.gbxPharmacistInfo = new System.Windows.Forms.GroupBox();
            this.txtPharmacistPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPharmacistFullName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dgvAvailableDrugs = new System.Windows.Forms.DataGridView();
            this.cmsDrugOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiViewDrugDetails = new FontAwesome.Sharp.IconMenuItem();
            this.tsmiSearchDrug = new FontAwesome.Sharp.IconMenuItem();
            this.tsmiShowConflictingDrugs = new FontAwesome.Sharp.IconMenuItem();
            this.tsmiShowPrescriptionHistory = new FontAwesome.Sharp.IconMenuItem();
            this.tsmiAddDrugToDispense = new FontAwesome.Sharp.IconMenuItem();
            this.tsmiRefreshDrugList = new FontAwesome.Sharp.IconMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtInvoiceDateDetail = new System.Windows.Forms.TextBox();
            this.txtInvoiceDate = new System.Windows.Forms.TextBox();
            this.dgvDispensedDrugs = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsSelectedDrugsOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiProductDetails = new FontAwesome.Sharp.IconMenuItem();
            this.tsmiEdit = new FontAwesome.Sharp.IconMenuItem();
            this.tsmiRemoveDrug = new FontAwesome.Sharp.IconMenuItem();
            this.tsmiClearAllDrugs = new FontAwesome.Sharp.IconMenuItem();
            this.label17 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveInvoice = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSafeDrugs = new System.Windows.Forms.Label();
            this.lblConflictingDrugs = new System.Windows.Forms.Label();
            this.lblTotalDrugs = new System.Windows.Forms.Label();
            this.lblTotalDrugsIcon = new System.Windows.Forms.Label();
            this.lblConflictingDrugsIcon = new System.Windows.Forms.Label();
            this.lblSafeDrugsIcon = new System.Windows.Forms.Label();
            this.colDrugName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatchNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConflict = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRestricted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbxPharmacistInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableDrugs)).BeginInit();
            this.cmsDrugOptions.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDispensedDrugs)).BeginInit();
            this.cmsSelectedDrugsOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(430, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "İlaç Satışı";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cmbPatientPhones);
            this.groupBox1.Controls.Add(this.txtSearchPatientPhone);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.btnSearchPatient);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 162);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta Bilgileri";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtPatientPhone);
            this.panel2.Controls.Add(this.txtPaitentFullName);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(444, 77);
            this.panel2.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Telefon No";
            // 
            // txtPatientPhone
            // 
            this.txtPatientPhone.BackColor = System.Drawing.Color.White;
            this.txtPatientPhone.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientPhone.Location = new System.Drawing.Point(102, 40);
            this.txtPatientPhone.Multiline = true;
            this.txtPatientPhone.Name = "txtPatientPhone";
            this.txtPatientPhone.ReadOnly = true;
            this.txtPatientPhone.Size = new System.Drawing.Size(337, 29);
            this.txtPatientPhone.TabIndex = 23;
            // 
            // txtPaitentFullName
            // 
            this.txtPaitentFullName.BackColor = System.Drawing.Color.White;
            this.txtPaitentFullName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaitentFullName.Location = new System.Drawing.Point(102, 5);
            this.txtPaitentFullName.Multiline = true;
            this.txtPaitentFullName.Name = "txtPaitentFullName";
            this.txtPaitentFullName.ReadOnly = true;
            this.txtPaitentFullName.Size = new System.Drawing.Size(337, 29);
            this.txtPaitentFullName.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(2, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Ad-Soyad";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(255, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Telefon No Seç";
            // 
            // cmbPatientPhones
            // 
            this.cmbPatientPhones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPatientPhones.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPatientPhones.FormattingEnabled = true;
            this.cmbPatientPhones.Location = new System.Drawing.Point(240, 47);
            this.cmbPatientPhones.Name = "cmbPatientPhones";
            this.cmbPatientPhones.Size = new System.Drawing.Size(203, 34);
            this.cmbPatientPhones.TabIndex = 20;
            this.cmbPatientPhones.SelectedIndexChanged += new System.EventHandler(this.cmbPatientPhones_SelectedIndexChanged);
            // 
            // txtSearchPatientPhone
            // 
            this.txtSearchPatientPhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchPatientPhone.Location = new System.Drawing.Point(6, 47);
            this.txtSearchPatientPhone.Multiline = true;
            this.txtSearchPatientPhone.Name = "txtSearchPatientPhone";
            this.txtSearchPatientPhone.Size = new System.Drawing.Size(213, 29);
            this.txtSearchPatientPhone.TabIndex = 10;
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
            // btnSearchPatient
            // 
            this.btnSearchPatient.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchPatient.Location = new System.Drawing.Point(163, 15);
            this.btnSearchPatient.Name = "btnSearchPatient";
            this.btnSearchPatient.Size = new System.Drawing.Size(56, 29);
            this.btnSearchPatient.TabIndex = 17;
            this.btnSearchPatient.Text = "Ara";
            this.btnSearchPatient.UseVisualStyleBackColor = true;
            this.btnSearchPatient.Click += new System.EventHandler(this.btnSearchPatient_Click);
            // 
            // gbxPharmacistInfo
            // 
            this.gbxPharmacistInfo.Controls.Add(this.txtPharmacistPhone);
            this.gbxPharmacistInfo.Controls.Add(this.label7);
            this.gbxPharmacistInfo.Controls.Add(this.txtPharmacistFullName);
            this.gbxPharmacistInfo.Controls.Add(this.label15);
            this.gbxPharmacistInfo.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPharmacistInfo.Location = new System.Drawing.Point(487, 51);
            this.gbxPharmacistInfo.Name = "gbxPharmacistInfo";
            this.gbxPharmacistInfo.Size = new System.Drawing.Size(443, 98);
            this.gbxPharmacistInfo.TabIndex = 35;
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
            // dgvAvailableDrugs
            // 
            this.dgvAvailableDrugs.AllowUserToAddRows = false;
            this.dgvAvailableDrugs.AllowUserToDeleteRows = false;
            this.dgvAvailableDrugs.AllowUserToResizeColumns = false;
            this.dgvAvailableDrugs.AllowUserToResizeRows = false;
            this.dgvAvailableDrugs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAvailableDrugs.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAvailableDrugs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAvailableDrugs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAvailableDrugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailableDrugs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDrugName,
            this.BatchNumber,
            this.colConflict,
            this.colRestricted});
            this.dgvAvailableDrugs.ContextMenuStrip = this.cmsDrugOptions;
            this.dgvAvailableDrugs.EnableHeadersVisualStyles = false;
            this.dgvAvailableDrugs.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgvAvailableDrugs.Location = new System.Drawing.Point(12, 256);
            this.dgvAvailableDrugs.MultiSelect = false;
            this.dgvAvailableDrugs.Name = "dgvAvailableDrugs";
            this.dgvAvailableDrugs.ReadOnly = true;
            this.dgvAvailableDrugs.RowHeadersVisible = false;
            this.dgvAvailableDrugs.RowHeadersWidth = 51;
            this.dgvAvailableDrugs.RowTemplate.Height = 24;
            this.dgvAvailableDrugs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAvailableDrugs.Size = new System.Drawing.Size(659, 218);
            this.dgvAvailableDrugs.TabIndex = 44;
            // 
            // cmsDrugOptions
            // 
            this.cmsDrugOptions.BackColor = System.Drawing.SystemColors.Info;
            this.cmsDrugOptions.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsDrugOptions.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.cmsDrugOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiViewDrugDetails,
            this.tsmiSearchDrug,
            this.tsmiShowConflictingDrugs,
            this.tsmiShowPrescriptionHistory,
            this.tsmiAddDrugToDispense,
            this.tsmiRefreshDrugList});
            this.cmsDrugOptions.Name = "contextMenuStrip1";
            this.cmsDrugOptions.Size = new System.Drawing.Size(295, 220);
            // 
            // tsmiViewDrugDetails
            // 
            this.tsmiViewDrugDetails.IconChar = FontAwesome.Sharp.IconChar.None;
            this.tsmiViewDrugDetails.IconColor = System.Drawing.Color.Black;
            this.tsmiViewDrugDetails.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.tsmiViewDrugDetails.Name = "tsmiViewDrugDetails";
            this.tsmiViewDrugDetails.Size = new System.Drawing.Size(294, 36);
            this.tsmiViewDrugDetails.Text = "İlaç Detayları";
            this.tsmiViewDrugDetails.Click += new System.EventHandler(this.tsmiViewDrugDetails_Click);
            // 
            // tsmiSearchDrug
            // 
            this.tsmiSearchDrug.IconChar = FontAwesome.Sharp.IconChar.None;
            this.tsmiSearchDrug.IconColor = System.Drawing.Color.Black;
            this.tsmiSearchDrug.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.tsmiSearchDrug.Name = "tsmiSearchDrug";
            this.tsmiSearchDrug.Size = new System.Drawing.Size(294, 36);
            this.tsmiSearchDrug.Text = "İlaç Ara";
            this.tsmiSearchDrug.Click += new System.EventHandler(this.tsmiSearchDrug_Click);
            // 
            // tsmiShowConflictingDrugs
            // 
            this.tsmiShowConflictingDrugs.IconChar = FontAwesome.Sharp.IconChar.None;
            this.tsmiShowConflictingDrugs.IconColor = System.Drawing.Color.Black;
            this.tsmiShowConflictingDrugs.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.tsmiShowConflictingDrugs.Name = "tsmiShowConflictingDrugs";
            this.tsmiShowConflictingDrugs.Size = new System.Drawing.Size(294, 36);
            this.tsmiShowConflictingDrugs.Text = "Çakışan İlaçları Göster";
            this.tsmiShowConflictingDrugs.Click += new System.EventHandler(this.tsmiShowConflictingDrugs_Click);
            // 
            // tsmiShowPrescriptionHistory
            // 
            this.tsmiShowPrescriptionHistory.IconChar = FontAwesome.Sharp.IconChar.None;
            this.tsmiShowPrescriptionHistory.IconColor = System.Drawing.Color.Black;
            this.tsmiShowPrescriptionHistory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.tsmiShowPrescriptionHistory.Name = "tsmiShowPrescriptionHistory";
            this.tsmiShowPrescriptionHistory.Size = new System.Drawing.Size(294, 36);
            this.tsmiShowPrescriptionHistory.Text = "Hasta ve Kullanım Geçmişi";
            this.tsmiShowPrescriptionHistory.Click += new System.EventHandler(this.tsmiShowPrescriptionHistory_Click);
            // 
            // tsmiAddDrugToDispense
            // 
            this.tsmiAddDrugToDispense.IconChar = FontAwesome.Sharp.IconChar.None;
            this.tsmiAddDrugToDispense.IconColor = System.Drawing.Color.Black;
            this.tsmiAddDrugToDispense.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.tsmiAddDrugToDispense.Name = "tsmiAddDrugToDispense";
            this.tsmiAddDrugToDispense.Size = new System.Drawing.Size(294, 36);
            this.tsmiAddDrugToDispense.Text = "İlacı Ekle";
            this.tsmiAddDrugToDispense.Click += new System.EventHandler(this.tsmiAddDrugToDispense_Click);
            // 
            // tsmiRefreshDrugList
            // 
            this.tsmiRefreshDrugList.IconChar = FontAwesome.Sharp.IconChar.None;
            this.tsmiRefreshDrugList.IconColor = System.Drawing.Color.Black;
            this.tsmiRefreshDrugList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.tsmiRefreshDrugList.Name = "tsmiRefreshDrugList";
            this.tsmiRefreshDrugList.Size = new System.Drawing.Size(294, 36);
            this.tsmiRefreshDrugList.Text = "Listeyi Güncelle";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtInvoiceDateDetail);
            this.groupBox3.Controls.Add(this.txtInvoiceDate);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(487, 155);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(443, 58);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fatura Tarihi";
            // 
            // txtInvoiceDateDetail
            // 
            this.txtInvoiceDateDetail.BackColor = System.Drawing.Color.White;
            this.txtInvoiceDateDetail.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceDateDetail.Location = new System.Drawing.Point(247, 23);
            this.txtInvoiceDateDetail.Multiline = true;
            this.txtInvoiceDateDetail.Name = "txtInvoiceDateDetail";
            this.txtInvoiceDateDetail.ReadOnly = true;
            this.txtInvoiceDateDetail.Size = new System.Drawing.Size(186, 29);
            this.txtInvoiceDateDetail.TabIndex = 24;
            // 
            // txtInvoiceDate
            // 
            this.txtInvoiceDate.BackColor = System.Drawing.Color.White;
            this.txtInvoiceDate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceDate.Location = new System.Drawing.Point(10, 23);
            this.txtInvoiceDate.Multiline = true;
            this.txtInvoiceDate.Name = "txtInvoiceDate";
            this.txtInvoiceDate.ReadOnly = true;
            this.txtInvoiceDate.Size = new System.Drawing.Size(231, 29);
            this.txtInvoiceDate.TabIndex = 23;
            // 
            // dgvDispensedDrugs
            // 
            this.dgvDispensedDrugs.AllowUserToAddRows = false;
            this.dgvDispensedDrugs.AllowUserToDeleteRows = false;
            this.dgvDispensedDrugs.AllowUserToResizeColumns = false;
            this.dgvDispensedDrugs.AllowUserToResizeRows = false;
            this.dgvDispensedDrugs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDispensedDrugs.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDispensedDrugs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDispensedDrugs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDispensedDrugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDispensedDrugs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dgvDispensedDrugs.ContextMenuStrip = this.cmsSelectedDrugsOptions;
            this.dgvDispensedDrugs.EnableHeadersVisualStyles = false;
            this.dgvDispensedDrugs.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgvDispensedDrugs.Location = new System.Drawing.Point(689, 256);
            this.dgvDispensedDrugs.MultiSelect = false;
            this.dgvDispensedDrugs.Name = "dgvDispensedDrugs";
            this.dgvDispensedDrugs.ReadOnly = true;
            this.dgvDispensedDrugs.RowHeadersVisible = false;
            this.dgvDispensedDrugs.RowHeadersWidth = 51;
            this.dgvDispensedDrugs.RowTemplate.Height = 24;
            this.dgvDispensedDrugs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDispensedDrugs.Size = new System.Drawing.Size(241, 218);
            this.dgvDispensedDrugs.TabIndex = 46;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DrugName";
            this.dataGridViewTextBoxColumn1.FillWeight = 106.9519F;
            this.dataGridViewTextBoxColumn1.HeaderText = "İlaç Adı";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cmsSelectedDrugsOptions
            // 
            this.cmsSelectedDrugsOptions.BackColor = System.Drawing.SystemColors.Info;
            this.cmsSelectedDrugsOptions.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsSelectedDrugsOptions.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.cmsSelectedDrugsOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiProductDetails,
            this.tsmiEdit,
            this.tsmiRemoveDrug,
            this.tsmiClearAllDrugs});
            this.cmsSelectedDrugsOptions.Name = "cmsSelectedDrugsOptions";
            this.cmsSelectedDrugsOptions.Size = new System.Drawing.Size(241, 148);
            // 
            // tsmiProductDetails
            // 
            this.tsmiProductDetails.IconChar = FontAwesome.Sharp.IconChar.None;
            this.tsmiProductDetails.IconColor = System.Drawing.Color.Black;
            this.tsmiProductDetails.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.tsmiProductDetails.Name = "tsmiProductDetails";
            this.tsmiProductDetails.Size = new System.Drawing.Size(240, 36);
            this.tsmiProductDetails.Text = "Ürün Bilgileri";
            this.tsmiProductDetails.Click += new System.EventHandler(this.tsmiProductDetails_Click);
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.IconChar = FontAwesome.Sharp.IconChar.None;
            this.tsmiEdit.IconColor = System.Drawing.Color.Black;
            this.tsmiEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(240, 36);
            this.tsmiEdit.Text = "Düzenle";
            // 
            // tsmiRemoveDrug
            // 
            this.tsmiRemoveDrug.IconChar = FontAwesome.Sharp.IconChar.None;
            this.tsmiRemoveDrug.IconColor = System.Drawing.Color.Black;
            this.tsmiRemoveDrug.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.tsmiRemoveDrug.Name = "tsmiRemoveDrug";
            this.tsmiRemoveDrug.Size = new System.Drawing.Size(240, 36);
            this.tsmiRemoveDrug.Text = "İlacı Listeden Çıkar";
            // 
            // tsmiClearAllDrugs
            // 
            this.tsmiClearAllDrugs.IconChar = FontAwesome.Sharp.IconChar.None;
            this.tsmiClearAllDrugs.IconColor = System.Drawing.Color.Black;
            this.tsmiClearAllDrugs.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.tsmiClearAllDrugs.Name = "tsmiClearAllDrugs";
            this.tsmiClearAllDrugs.Size = new System.Drawing.Size(240, 36);
            this.tsmiClearAllDrugs.Text = "Tüm Listeyi Temizle";
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Silver;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(12, 225);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(659, 28);
            this.label17.TabIndex = 47;
            this.label17.Text = "İlaçlar Listesi";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(689, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 28);
            this.label2.TabIndex = 48;
            this.label2.Text = "Verilen İlaçlar";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSaveInvoice
            // 
            this.btnSaveInvoice.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveInvoice.Location = new System.Drawing.Point(689, 480);
            this.btnSaveInvoice.Name = "btnSaveInvoice";
            this.btnSaveInvoice.Size = new System.Drawing.Size(151, 43);
            this.btnSaveInvoice.TabIndex = 50;
            this.btnSaveInvoice.Text = "Faturayı Kaydet";
            this.btnSaveInvoice.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(846, 480);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 43);
            this.btnCancel.TabIndex = 51;
            this.btnCancel.Text = "İptal Et";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 477);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 19);
            this.label4.TabIndex = 57;
            this.label4.Text = "Toplam İlaç Sayısı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(248, 480);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 19);
            this.label5.TabIndex = 58;
            this.label5.Text = "Reçeteli İlaçlar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(461, 477);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 19);
            this.label6.TabIndex = 59;
            this.label6.Text = "Reçetesiz İlaçlar";
            // 
            // lblSafeDrugs
            // 
            this.lblSafeDrugs.AutoSize = true;
            this.lblSafeDrugs.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSafeDrugs.Location = new System.Drawing.Point(493, 504);
            this.lblSafeDrugs.Name = "lblSafeDrugs";
            this.lblSafeDrugs.Size = new System.Drawing.Size(54, 19);
            this.lblSafeDrugs.TabIndex = 60;
            this.lblSafeDrugs.Text = "10000";
            // 
            // lblConflictingDrugs
            // 
            this.lblConflictingDrugs.AutoSize = true;
            this.lblConflictingDrugs.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConflictingDrugs.Location = new System.Drawing.Point(285, 504);
            this.lblConflictingDrugs.Name = "lblConflictingDrugs";
            this.lblConflictingDrugs.Size = new System.Drawing.Size(54, 19);
            this.lblConflictingDrugs.TabIndex = 61;
            this.lblConflictingDrugs.Text = "10000";
            // 
            // lblTotalDrugs
            // 
            this.lblTotalDrugs.AutoSize = true;
            this.lblTotalDrugs.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDrugs.Location = new System.Drawing.Point(45, 504);
            this.lblTotalDrugs.Name = "lblTotalDrugs";
            this.lblTotalDrugs.Size = new System.Drawing.Size(54, 19);
            this.lblTotalDrugs.TabIndex = 62;
            this.lblTotalDrugs.Text = "10000";
            // 
            // lblTotalDrugsIcon
            // 
            this.lblTotalDrugsIcon.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDrugsIcon.Location = new System.Drawing.Point(152, 480);
            this.lblTotalDrugsIcon.Name = "lblTotalDrugsIcon";
            this.lblTotalDrugsIcon.Size = new System.Drawing.Size(30, 30);
            this.lblTotalDrugsIcon.TabIndex = 63;
            // 
            // lblConflictingDrugsIcon
            // 
            this.lblConflictingDrugsIcon.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConflictingDrugsIcon.Location = new System.Drawing.Point(368, 480);
            this.lblConflictingDrugsIcon.Name = "lblConflictingDrugsIcon";
            this.lblConflictingDrugsIcon.Size = new System.Drawing.Size(30, 30);
            this.lblConflictingDrugsIcon.TabIndex = 64;
            this.lblConflictingDrugsIcon.Text = "         ";
            // 
            // lblSafeDrugsIcon
            // 
            this.lblSafeDrugsIcon.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSafeDrugsIcon.Location = new System.Drawing.Point(590, 480);
            this.lblSafeDrugsIcon.Name = "lblSafeDrugsIcon";
            this.lblSafeDrugsIcon.Size = new System.Drawing.Size(30, 30);
            this.lblSafeDrugsIcon.TabIndex = 65;
            this.lblSafeDrugsIcon.Text = "      ";
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
            // BatchNumber
            // 
            this.BatchNumber.DataPropertyName = "BatchNumber";
            this.BatchNumber.FillWeight = 97.6827F;
            this.BatchNumber.HeaderText = "Seri No";
            this.BatchNumber.MinimumWidth = 6;
            this.BatchNumber.Name = "BatchNumber";
            this.BatchNumber.ReadOnly = true;
            this.BatchNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colConflict
            // 
            this.colConflict.DataPropertyName = "Conflict";
            this.colConflict.FillWeight = 97.6827F;
            this.colConflict.HeaderText = "Çakışma";
            this.colConflict.MinimumWidth = 6;
            this.colConflict.Name = "colConflict";
            this.colConflict.ReadOnly = true;
            this.colConflict.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colRestricted
            // 
            this.colRestricted.DataPropertyName = "Restricted";
            this.colRestricted.FillWeight = 97.6827F;
            this.colRestricted.HeaderText = "Reçeteli";
            this.colRestricted.MinimumWidth = 6;
            this.colRestricted.Name = "colRestricted";
            this.colRestricted.ReadOnly = true;
            this.colRestricted.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SellDrugScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 528);
            this.Controls.Add(this.lblSafeDrugsIcon);
            this.Controls.Add(this.lblConflictingDrugsIcon);
            this.Controls.Add(this.lblTotalDrugsIcon);
            this.Controls.Add(this.lblTotalDrugs);
            this.Controls.Add(this.lblConflictingDrugs);
            this.Controls.Add(this.lblSafeDrugs);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveInvoice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.dgvDispensedDrugs);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvAvailableDrugs);
            this.Controls.Add(this.gbxPharmacistInfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SellDrugScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellDrugScreen";
            this.Load += new System.EventHandler(this.SellDrugScreen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbxPharmacistInfo.ResumeLayout(false);
            this.gbxPharmacistInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableDrugs)).EndInit();
            this.cmsDrugOptions.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDispensedDrugs)).EndInit();
            this.cmsSelectedDrugsOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPaitentFullName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbPatientPhones;
        private System.Windows.Forms.TextBox txtSearchPatientPhone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSearchPatient;
        private System.Windows.Forms.GroupBox gbxPharmacistInfo;
        private System.Windows.Forms.TextBox txtPharmacistPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPharmacistFullName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dgvAvailableDrugs;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtInvoiceDateDetail;
        private System.Windows.Forms.TextBox txtInvoiceDate;
        private System.Windows.Forms.DataGridView dgvDispensedDrugs;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip cmsDrugOptions;
        private FontAwesome.Sharp.IconMenuItem tsmiViewDrugDetails;
        private FontAwesome.Sharp.IconMenuItem tsmiShowConflictingDrugs;
        private FontAwesome.Sharp.IconMenuItem tsmiShowPrescriptionHistory;
        private FontAwesome.Sharp.IconMenuItem tsmiAddDrugToDispense;
        private System.Windows.Forms.Button btnSaveInvoice;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ContextMenuStrip cmsSelectedDrugsOptions;
        private FontAwesome.Sharp.IconMenuItem tsmiProductDetails;
        private FontAwesome.Sharp.IconMenuItem tsmiRemoveDrug;
        private FontAwesome.Sharp.IconMenuItem tsmiClearAllDrugs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPatientPhone;
        private FontAwesome.Sharp.IconMenuItem tsmiEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSafeDrugs;
        private System.Windows.Forms.Label lblConflictingDrugs;
        private System.Windows.Forms.Label lblTotalDrugs;
        private System.Windows.Forms.Label lblTotalDrugsIcon;
        private System.Windows.Forms.Label lblConflictingDrugsIcon;
        private System.Windows.Forms.Label lblSafeDrugsIcon;
        private FontAwesome.Sharp.IconMenuItem tsmiSearchDrug;
        private FontAwesome.Sharp.IconMenuItem tsmiRefreshDrugList;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDrugName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConflict;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRestricted;
    }
}