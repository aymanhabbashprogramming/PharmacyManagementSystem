namespace Pharmacy.Screens.DrugScreens
{
    partial class ConflictingDrugsCmsScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvConflictingDrugs = new System.Windows.Forms.DataGridView();
            this.lblCurrentDrugName = new System.Windows.Forms.Label();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsSelectedForDispensing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.lblConflictingDrugsCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConflictingDrugs)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 20);
            this.label12.TabIndex = 12;
            this.label12.Text = "İlaç Adı : ";
            // 
            // dgvConflictingDrugs
            // 
            this.dgvConflictingDrugs.AllowUserToAddRows = false;
            this.dgvConflictingDrugs.AllowUserToDeleteRows = false;
            this.dgvConflictingDrugs.AllowUserToResizeColumns = false;
            this.dgvConflictingDrugs.AllowUserToResizeRows = false;
            this.dgvConflictingDrugs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConflictingDrugs.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvConflictingDrugs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConflictingDrugs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConflictingDrugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConflictingDrugs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.colIsSelectedForDispensing});
            this.dgvConflictingDrugs.EnableHeadersVisualStyles = false;
            this.dgvConflictingDrugs.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgvConflictingDrugs.Location = new System.Drawing.Point(12, 66);
            this.dgvConflictingDrugs.MultiSelect = false;
            this.dgvConflictingDrugs.Name = "dgvConflictingDrugs";
            this.dgvConflictingDrugs.ReadOnly = true;
            this.dgvConflictingDrugs.RowHeadersVisible = false;
            this.dgvConflictingDrugs.RowHeadersWidth = 51;
            this.dgvConflictingDrugs.RowTemplate.Height = 24;
            this.dgvConflictingDrugs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConflictingDrugs.Size = new System.Drawing.Size(339, 256);
            this.dgvConflictingDrugs.TabIndex = 47;
            // 
            // lblCurrentDrugName
            // 
            this.lblCurrentDrugName.AutoSize = true;
            this.lblCurrentDrugName.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentDrugName.Location = new System.Drawing.Point(96, 9);
            this.lblCurrentDrugName.Name = "lblCurrentDrugName";
            this.lblCurrentDrugName.Size = new System.Drawing.Size(64, 20);
            this.lblCurrentDrugName.TabIndex = 48;
            this.lblCurrentDrugName.Text = "İlaç Adı";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnClose.IconColor = System.Drawing.Color.Black;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.Location = new System.Drawing.Point(258, 328);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(93, 35);
            this.btnClose.TabIndex = 49;
            this.btnClose.Text = "Kapat";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 20);
            this.label1.TabIndex = 50;
            this.label1.Text = "Bu İlaç İle Çakışan İalçlar";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DrugName";
            this.dataGridViewTextBoxColumn1.FillWeight = 129.4833F;
            this.dataGridViewTextBoxColumn1.HeaderText = "İlaç Adı";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colIsSelectedForDispensing
            // 
            this.colIsSelectedForDispensing.FillWeight = 77.46863F;
            this.colIsSelectedForDispensing.HeaderText = "Eklendi";
            this.colIsSelectedForDispensing.MinimumWidth = 6;
            this.colIsSelectedForDispensing.Name = "colIsSelectedForDispensing";
            this.colIsSelectedForDispensing.ReadOnly = true;
            this.colIsSelectedForDispensing.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 51;
            this.label2.Text = "Çakışan İlaç Sayısı :";
            // 
            // lblConflictingDrugsCount
            // 
            this.lblConflictingDrugsCount.AutoSize = true;
            this.lblConflictingDrugsCount.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConflictingDrugsCount.Location = new System.Drawing.Point(188, 335);
            this.lblConflictingDrugsCount.Name = "lblConflictingDrugsCount";
            this.lblConflictingDrugsCount.Size = new System.Drawing.Size(45, 20);
            this.lblConflictingDrugsCount.TabIndex = 52;
            this.lblConflictingDrugsCount.Text = "1000";
            // 
            // ConflictingDrugsCmsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 375);
            this.Controls.Add(this.lblConflictingDrugsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblCurrentDrugName);
            this.Controls.Add(this.dgvConflictingDrugs);
            this.Controls.Add(this.label12);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConflictingDrugsCmsScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConflictingDrugsCmsScreen";
            this.Load += new System.EventHandler(this.ConflictingDrugsCmsScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConflictingDrugs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvConflictingDrugs;
        private System.Windows.Forms.Label lblCurrentDrugName;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsSelectedForDispensing;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblConflictingDrugsCount;
    }
}