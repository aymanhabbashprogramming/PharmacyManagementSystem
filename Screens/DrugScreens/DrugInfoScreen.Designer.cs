namespace Pharmacy.Screens.DrugScreens
{
    partial class DrugInfoScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtDrugName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkIsRestricted = new System.Windows.Forms.CheckBox();
            this.txtUsageInstructions = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudRefillIntervalDays = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvDrugConflicts = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearchCategory = new System.Windows.Forms.Button();
            this.txtSearchCategory = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNewCategory = new System.Windows.Forms.TextBox();
            this.btnAddNewCategory = new System.Windows.Forms.Button();
            this.btnConfirmAndProceed = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.colDrugName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsConflicting = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudRefillIntervalDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrugConflicts)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDrugName
            // 
            this.txtDrugName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrugName.Location = new System.Drawing.Point(136, 58);
            this.txtDrugName.Multiline = true;
            this.txtDrugName.Name = "txtDrugName";
            this.txtDrugName.Size = new System.Drawing.Size(241, 29);
            this.txtDrugName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "İlaç Adı";
            // 
            // chkIsRestricted
            // 
            this.chkIsRestricted.AutoSize = true;
            this.chkIsRestricted.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsRestricted.Location = new System.Drawing.Point(16, 220);
            this.chkIsRestricted.Name = "chkIsRestricted";
            this.chkIsRestricted.Size = new System.Drawing.Size(177, 24);
            this.chkIsRestricted.TabIndex = 2;
            this.chkIsRestricted.Text = "Kısıtlı İlaç (Reçeteli)";
            this.chkIsRestricted.UseVisualStyleBackColor = true;
            this.chkIsRestricted.CheckedChanged += new System.EventHandler(this.chkIsRestricted_CheckedChanged);
            // 
            // txtUsageInstructions
            // 
            this.txtUsageInstructions.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsageInstructions.Location = new System.Drawing.Point(17, 345);
            this.txtUsageInstructions.Multiline = true;
            this.txtUsageInstructions.Name = "txtUsageInstructions";
            this.txtUsageInstructions.Size = new System.Drawing.Size(360, 104);
            this.txtUsageInstructions.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kullanım Talimatları";
            // 
            // nudRefillIntervalDays
            // 
            this.nudRefillIntervalDays.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudRefillIntervalDays.Location = new System.Drawing.Point(191, 259);
            this.nudRefillIntervalDays.Name = "nudRefillIntervalDays";
            this.nudRefillIntervalDays.Size = new System.Drawing.Size(186, 28);
            this.nudRefillIntervalDays.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Reçete Aralığı (Gün)";
            // 
            // cmbCategories
            // 
            this.cmbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategories.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(136, 175);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(241, 27);
            this.cmbCategories.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(337, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "İlaç Bilgiler";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(420, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(226, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Birlikte Kullanılamayan İlaçlar";
            // 
            // dgvDrugConflicts
            // 
            this.dgvDrugConflicts.AllowUserToAddRows = false;
            this.dgvDrugConflicts.AllowUserToDeleteRows = false;
            this.dgvDrugConflicts.AllowUserToResizeColumns = false;
            this.dgvDrugConflicts.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDrugConflicts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDrugConflicts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDrugConflicts.BackgroundColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDrugConflicts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDrugConflicts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDrugConflicts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDrugName,
            this.colIsConflicting});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDrugConflicts.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDrugConflicts.EnableHeadersVisualStyles = false;
            this.dgvDrugConflicts.Location = new System.Drawing.Point(424, 88);
            this.dgvDrugConflicts.MultiSelect = false;
            this.dgvDrugConflicts.Name = "dgvDrugConflicts";
            this.dgvDrugConflicts.RowHeadersVisible = false;
            this.dgvDrugConflicts.RowHeadersWidth = 51;
            this.dgvDrugConflicts.RowTemplate.Height = 24;
            this.dgvDrugConflicts.Size = new System.Drawing.Size(338, 193);
            this.dgvDrugConflicts.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Kategori Seç";
            // 
            // btnSearchCategory
            // 
            this.btnSearchCategory.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCategory.Location = new System.Drawing.Point(278, 127);
            this.btnSearchCategory.Name = "btnSearchCategory";
            this.btnSearchCategory.Size = new System.Drawing.Size(99, 29);
            this.btnSearchCategory.TabIndex = 16;
            this.btnSearchCategory.Text = "Ara";
            this.btnSearchCategory.UseVisualStyleBackColor = true;
            this.btnSearchCategory.Click += new System.EventHandler(this.btnSearchCategory_Click);
            // 
            // txtSearchCategory
            // 
            this.txtSearchCategory.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCategory.Location = new System.Drawing.Point(17, 127);
            this.txtSearchCategory.Multiline = true;
            this.txtSearchCategory.Name = "txtSearchCategory";
            this.txtSearchCategory.Size = new System.Drawing.Size(241, 29);
            this.txtSearchCategory.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Kategori Adı ile Ara\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(420, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Farklı Kategori Ekle";
            // 
            // txtNewCategory
            // 
            this.txtNewCategory.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewCategory.Location = new System.Drawing.Point(424, 329);
            this.txtNewCategory.Multiline = true;
            this.txtNewCategory.Name = "txtNewCategory";
            this.txtNewCategory.Size = new System.Drawing.Size(241, 29);
            this.txtNewCategory.TabIndex = 20;
            // 
            // btnAddNewCategory
            // 
            this.btnAddNewCategory.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCategory.Location = new System.Drawing.Point(672, 329);
            this.btnAddNewCategory.Name = "btnAddNewCategory";
            this.btnAddNewCategory.Size = new System.Drawing.Size(90, 29);
            this.btnAddNewCategory.TabIndex = 21;
            this.btnAddNewCategory.Text = "Ekle";
            this.btnAddNewCategory.UseVisualStyleBackColor = true;
            this.btnAddNewCategory.Click += new System.EventHandler(this.btnAddNewCategory_Click);
            // 
            // btnConfirmAndProceed
            // 
            this.btnConfirmAndProceed.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmAndProceed.Location = new System.Drawing.Point(424, 406);
            this.btnConfirmAndProceed.Name = "btnConfirmAndProceed";
            this.btnConfirmAndProceed.Size = new System.Drawing.Size(207, 43);
            this.btnConfirmAndProceed.TabIndex = 22;
            this.btnConfirmAndProceed.Text = "İlaç Bilgilerini Onayla";
            this.btnConfirmAndProceed.UseVisualStyleBackColor = true;
            this.btnConfirmAndProceed.Click += new System.EventHandler(this.btnConfirmAndProceed_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(646, 406);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 43);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "İptal";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // colDrugName
            // 
            this.colDrugName.DataPropertyName = "DrugName";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDrugName.DefaultCellStyle = dataGridViewCellStyle7;
            this.colDrugName.FillWeight = 135.8289F;
            this.colDrugName.HeaderText = "İlaç Adı";
            this.colDrugName.MinimumWidth = 6;
            this.colDrugName.Name = "colDrugName";
            this.colDrugName.ReadOnly = true;
            // 
            // colIsConflicting
            // 
            this.colIsConflicting.DataPropertyName = "IsConflicting";
            this.colIsConflicting.FillWeight = 64.17112F;
            this.colIsConflicting.HeaderText = "Kullanılmaz";
            this.colIsConflicting.MinimumWidth = 6;
            this.colIsConflicting.Name = "colIsConflicting";
            this.colIsConflicting.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colIsConflicting.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DrugInfoScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(783, 461);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirmAndProceed);
            this.Controls.Add(this.btnAddNewCategory);
            this.Controls.Add(this.txtNewCategory);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSearchCategory);
            this.Controls.Add(this.btnSearchCategory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvDrugConflicts);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbCategories);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudRefillIntervalDays);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsageInstructions);
            this.Controls.Add(this.chkIsRestricted);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDrugName);
            this.Name = "DrugInfoScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DrugInfoScreen";
            this.Load += new System.EventHandler(this.DrugInfoScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudRefillIntervalDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrugConflicts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDrugName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkIsRestricted;
        private System.Windows.Forms.TextBox txtUsageInstructions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudRefillIntervalDays;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvDrugConflicts;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearchCategory;
        private System.Windows.Forms.TextBox txtSearchCategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNewCategory;
        private System.Windows.Forms.Button btnAddNewCategory;
        private System.Windows.Forms.Button btnConfirmAndProceed;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDrugName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsConflicting;
    }
}