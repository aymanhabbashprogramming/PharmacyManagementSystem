namespace Pharmacy.Screens.DrugScreens
{
    partial class ArchiveCmsScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label10 = new System.Windows.Forms.Label();
            this.lblPatientFullName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMedicineName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLastGivenDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNextDoseDate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblApprovalStatus = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvPreviousDoses = new System.Windows.Forms.DataGridView();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNextDoseNumber = new System.Windows.Forms.Label();
            this.lblActiveDoseStatus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.colDoseNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGivenDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreviousDoses)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Hasta Adı Soyadı : ";
            // 
            // lblPatientFullName
            // 
            this.lblPatientFullName.AutoSize = true;
            this.lblPatientFullName.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientFullName.Location = new System.Drawing.Point(177, 9);
            this.lblPatientFullName.Name = "lblPatientFullName";
            this.lblPatientFullName.Size = new System.Drawing.Size(133, 20);
            this.lblPatientFullName.TabIndex = 23;
            this.lblPatientFullName.Text = "Hasta Adı Soyadı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "İlaç Adı : ";
            // 
            // lblMedicineName
            // 
            this.lblMedicineName.AutoSize = true;
            this.lblMedicineName.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicineName.Location = new System.Drawing.Point(103, 41);
            this.lblMedicineName.Name = "lblMedicineName";
            this.lblMedicineName.Size = new System.Drawing.Size(64, 20);
            this.lblMedicineName.TabIndex = 25;
            this.lblMedicineName.Text = "İlaç Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Son Verilen Doz Tarihi : ";
            // 
            // lblLastGivenDate
            // 
            this.lblLastGivenDate.AutoSize = true;
            this.lblLastGivenDate.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastGivenDate.Location = new System.Drawing.Point(217, 73);
            this.lblLastGivenDate.Name = "lblLastGivenDate";
            this.lblLastGivenDate.Size = new System.Drawing.Size(91, 20);
            this.lblLastGivenDate.TabIndex = 27;
            this.lblLastGivenDate.Text = "10.10.2026";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Sonraki Doz Tarihi : ";
            // 
            // lblNextDoseDate
            // 
            this.lblNextDoseDate.AutoSize = true;
            this.lblNextDoseDate.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextDoseDate.Location = new System.Drawing.Point(189, 105);
            this.lblNextDoseDate.Name = "lblNextDoseDate";
            this.lblNextDoseDate.Size = new System.Drawing.Size(91, 20);
            this.lblNextDoseDate.TabIndex = 29;
            this.lblNextDoseDate.Text = "10.12.2026";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Onay Durumu : ";
            // 
            // lblApprovalStatus
            // 
            this.lblApprovalStatus.AutoSize = true;
            this.lblApprovalStatus.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApprovalStatus.Location = new System.Drawing.Point(154, 139);
            this.lblApprovalStatus.Name = "lblApprovalStatus";
            this.lblApprovalStatus.Size = new System.Drawing.Size(356, 20);
            this.lblApprovalStatus.TabIndex = 31;
            this.lblApprovalStatus.Text = "Verilebilir / Mevcut Doz Bitene Kadar Verilemez";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(507, 20);
            this.label11.TabIndex = 32;
            this.label11.Text = "---------------------------------------------------------------------------------" +
    "--\r\n";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 179);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(238, 20);
            this.label12.TabIndex = 33;
            this.label12.Text = "Hastanın Bu İlacı Alma Geçmişi";
            // 
            // dgvPreviousDoses
            // 
            this.dgvPreviousDoses.AllowUserToAddRows = false;
            this.dgvPreviousDoses.AllowUserToDeleteRows = false;
            this.dgvPreviousDoses.AllowUserToResizeColumns = false;
            this.dgvPreviousDoses.AllowUserToResizeRows = false;
            this.dgvPreviousDoses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPreviousDoses.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPreviousDoses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPreviousDoses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPreviousDoses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreviousDoses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDoseNumber,
            this.colGivenDate,
            this.colEndDate});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPreviousDoses.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvPreviousDoses.EnableHeadersVisualStyles = false;
            this.dgvPreviousDoses.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgvPreviousDoses.Location = new System.Drawing.Point(16, 202);
            this.dgvPreviousDoses.MultiSelect = false;
            this.dgvPreviousDoses.Name = "dgvPreviousDoses";
            this.dgvPreviousDoses.ReadOnly = true;
            this.dgvPreviousDoses.RowHeadersVisible = false;
            this.dgvPreviousDoses.RowHeadersWidth = 51;
            this.dgvPreviousDoses.RowTemplate.Height = 24;
            this.dgvPreviousDoses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPreviousDoses.Size = new System.Drawing.Size(502, 224);
            this.dgvPreviousDoses.TabIndex = 48;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnClose.IconColor = System.Drawing.Color.Black;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.Location = new System.Drawing.Point(434, 432);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(84, 38);
            this.btnClose.TabIndex = 49;
            this.btnClose.Text = "Kapat";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 440);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 50;
            this.label1.Text = "Verilecek Doz No : ";
            // 
            // lblNextDoseNumber
            // 
            this.lblNextDoseNumber.AutoSize = true;
            this.lblNextDoseNumber.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextDoseNumber.Location = new System.Drawing.Point(176, 440);
            this.lblNextDoseNumber.Name = "lblNextDoseNumber";
            this.lblNextDoseNumber.Size = new System.Drawing.Size(54, 20);
            this.lblNextDoseNumber.TabIndex = 51;
            this.lblNextDoseNumber.Text = "10000";
            // 
            // lblActiveDoseStatus
            // 
            this.lblActiveDoseStatus.AutoSize = true;
            this.lblActiveDoseStatus.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveDoseStatus.Location = new System.Drawing.Point(355, 440);
            this.lblActiveDoseStatus.Name = "lblActiveDoseStatus";
            this.lblActiveDoseStatus.Size = new System.Drawing.Size(67, 20);
            this.lblActiveDoseStatus.TabIndex = 53;
            this.lblActiveDoseStatus.Text = "Var/Yok";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(254, 440);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 52;
            this.label5.Text = "Aktif Doz :";
            // 
            // colDoseNumber
            // 
            this.colDoseNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colDoseNumber.DefaultCellStyle = dataGridViewCellStyle8;
            this.colDoseNumber.FillWeight = 82.07271F;
            this.colDoseNumber.HeaderText = "Doz No";
            this.colDoseNumber.MinimumWidth = 6;
            this.colDoseNumber.Name = "colDoseNumber";
            this.colDoseNumber.ReadOnly = true;
            this.colDoseNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colDoseNumber.Width = 120;
            // 
            // colGivenDate
            // 
            this.colGivenDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colGivenDate.DataPropertyName = "DrugName";
            this.colGivenDate.FillWeight = 104.623F;
            this.colGivenDate.HeaderText = "Veriliş Tarihi";
            this.colGivenDate.MinimumWidth = 6;
            this.colGivenDate.Name = "colGivenDate";
            this.colGivenDate.ReadOnly = true;
            this.colGivenDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colGivenDate.Width = 190;
            // 
            // colEndDate
            // 
            this.colEndDate.FillWeight = 120.2563F;
            this.colEndDate.HeaderText = "Bitiş Tarihi";
            this.colEndDate.MinimumWidth = 6;
            this.colEndDate.Name = "colEndDate";
            this.colEndDate.ReadOnly = true;
            this.colEndDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ArchiveCmsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 477);
            this.Controls.Add(this.lblActiveDoseStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNextDoseNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvPreviousDoses);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblApprovalStatus);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblNextDoseDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblLastGivenDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMedicineName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPatientFullName);
            this.Controls.Add(this.label10);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ArchiveCmsScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArchiveCmsScreen";
            this.Load += new System.EventHandler(this.ArchiveCmsScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreviousDoses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblPatientFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMedicineName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblLastGivenDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNextDoseDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblApprovalStatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvPreviousDoses;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNextDoseNumber;
        private System.Windows.Forms.Label lblActiveDoseStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDoseNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGivenDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEndDate;
    }
}