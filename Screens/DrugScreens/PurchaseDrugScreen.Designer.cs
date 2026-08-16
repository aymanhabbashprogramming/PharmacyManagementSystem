namespace Pharmacy.Screens.DrugScreens
{
    partial class PurchaseDrugScreen
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
            this.label5 = new System.Windows.Forms.Label();
            this.dgvInvoiceItems = new System.Windows.Forms.DataGridView();
            this.RowNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDrugName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsInvoiceItems = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiDeleteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddNewDrug = new System.Windows.Forms.Button();
            this.btnConfirmAndSave = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblAddedProductCount = new System.Windows.Forms.Label();
            this.lblInvoiceTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceItems)).BeginInit();
            this.cmsInvoiceItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sisteme Yeni İlaç Ekle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Eklenen Ürün Sayısı :";
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
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
            this.dgvInvoiceItems.ContextMenuStrip = this.cmsInvoiceItems;
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
            this.dgvInvoiceItems.Location = new System.Drawing.Point(12, 88);
            this.dgvInvoiceItems.MultiSelect = false;
            this.dgvInvoiceItems.Name = "dgvInvoiceItems";
            this.dgvInvoiceItems.ReadOnly = true;
            this.dgvInvoiceItems.RowHeadersVisible = false;
            this.dgvInvoiceItems.RowHeadersWidth = 51;
            this.dgvInvoiceItems.RowTemplate.Height = 24;
            this.dgvInvoiceItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoiceItems.Size = new System.Drawing.Size(748, 150);
            this.dgvInvoiceItems.TabIndex = 6;
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
            // cmsInvoiceItems
            // 
            this.cmsInvoiceItems.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsInvoiceItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDeleteItem});
            this.cmsInvoiceItems.Name = "contextMenuStrip1";
            this.cmsInvoiceItems.Size = new System.Drawing.Size(155, 30);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fatura Toplamı : ";
            // 
            // btnAddNewDrug
            // 
            this.btnAddNewDrug.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewDrug.Location = new System.Drawing.Point(605, 39);
            this.btnAddNewDrug.Name = "btnAddNewDrug";
            this.btnAddNewDrug.Size = new System.Drawing.Size(155, 43);
            this.btnAddNewDrug.TabIndex = 38;
            this.btnAddNewDrug.Text = "Yeni İlaç Ekle\r\n";
            this.btnAddNewDrug.UseVisualStyleBackColor = true;
            this.btnAddNewDrug.Click += new System.EventHandler(this.btnAddNewDrug_Click);
            // 
            // btnConfirmAndSave
            // 
            this.btnConfirmAndSave.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmAndSave.Location = new System.Drawing.Point(405, 244);
            this.btnConfirmAndSave.Name = "btnConfirmAndSave";
            this.btnConfirmAndSave.Size = new System.Drawing.Size(201, 43);
            this.btnConfirmAndSave.TabIndex = 40;
            this.btnConfirmAndSave.Text = "Onayla Ve Kaydet";
            this.btnConfirmAndSave.UseVisualStyleBackColor = true;
            this.btnConfirmAndSave.Click += new System.EventHandler(this.btnConfirmAndSave_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(612, 244);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 43);
            this.button3.TabIndex = 41;
            this.button3.Text = "İşlemi İptal Et";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblAddedProductCount
            // 
            this.lblAddedProductCount.AutoSize = true;
            this.lblAddedProductCount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddedProductCount.Location = new System.Drawing.Point(196, 60);
            this.lblAddedProductCount.Name = "lblAddedProductCount";
            this.lblAddedProductCount.Size = new System.Drawing.Size(208, 22);
            this.lblAddedProductCount.TabIndex = 42;
            this.lblAddedProductCount.Text = "(Henüz Ürün Eklenmedi)";
            // 
            // lblInvoiceTotal
            // 
            this.lblInvoiceTotal.AutoSize = true;
            this.lblInvoiceTotal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceTotal.Location = new System.Drawing.Point(164, 254);
            this.lblInvoiceTotal.Name = "lblInvoiceTotal";
            this.lblInvoiceTotal.Size = new System.Drawing.Size(45, 22);
            this.lblInvoiceTotal.TabIndex = 43;
            this.lblInvoiceTotal.Text = "0.00";
            // 
            // PurchaseDrugScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(772, 296);
            this.Controls.Add(this.lblInvoiceTotal);
            this.Controls.Add(this.lblAddedProductCount);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnConfirmAndSave);
            this.Controls.Add(this.btnAddNewDrug);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvInvoiceItems);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "PurchaseDrugScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurchaseDrugScreen";
            this.Load += new System.EventHandler(this.PurchaseDrugScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceItems)).EndInit();
            this.cmsInvoiceItems.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvInvoiceItems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddNewDrug;
        private System.Windows.Forms.Button btnConfirmAndSave;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblAddedProductCount;
        private System.Windows.Forms.Label lblInvoiceTotal;
        private System.Windows.Forms.ContextMenuStrip cmsInvoiceItems;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDrugName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalPrice;
    }
}