namespace Pharmacy.Screens.SupplierScreens
{
    partial class ManageSuppliersScreen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSupplıersListScreen = new System.Windows.Forms.Button();
            this.btnUpdateSupplıerScreen = new System.Windows.Forms.Button();
            this.btnAddNewSupplıerScreen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.btnSupplıersListScreen);
            this.panel1.Controls.Add(this.btnUpdateSupplıerScreen);
            this.panel1.Controls.Add(this.btnAddNewSupplıerScreen);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 541);
            this.panel1.TabIndex = 18;
            // 
            // btnSupplıersListScreen
            // 
            this.btnSupplıersListScreen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplıersListScreen.Location = new System.Drawing.Point(12, 200);
            this.btnSupplıersListScreen.Name = "btnSupplıersListScreen";
            this.btnSupplıersListScreen.Size = new System.Drawing.Size(192, 40);
            this.btnSupplıersListScreen.TabIndex = 20;
            this.btnSupplıersListScreen.Text = "Tedarikçi Listesi";
            this.btnSupplıersListScreen.UseVisualStyleBackColor = true;
            this.btnSupplıersListScreen.Click += new System.EventHandler(this.btnSuppliersListScreen_Click);
            // 
            // btnUpdateSupplıerScreen
            // 
            this.btnUpdateSupplıerScreen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSupplıerScreen.Location = new System.Drawing.Point(12, 143);
            this.btnUpdateSupplıerScreen.Name = "btnUpdateSupplıerScreen";
            this.btnUpdateSupplıerScreen.Size = new System.Drawing.Size(192, 40);
            this.btnUpdateSupplıerScreen.TabIndex = 19;
            this.btnUpdateSupplıerScreen.Text = "Tedarikçi Güncelle";
            this.btnUpdateSupplıerScreen.UseVisualStyleBackColor = true;
            this.btnUpdateSupplıerScreen.Click += new System.EventHandler(this.btnUpdateSupplierScreen_Click);
            // 
            // btnAddNewSupplıerScreen
            // 
            this.btnAddNewSupplıerScreen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewSupplıerScreen.Location = new System.Drawing.Point(12, 82);
            this.btnAddNewSupplıerScreen.Name = "btnAddNewSupplıerScreen";
            this.btnAddNewSupplıerScreen.Size = new System.Drawing.Size(192, 40);
            this.btnAddNewSupplıerScreen.TabIndex = 18;
            this.btnAddNewSupplıerScreen.Text = "Yeni Tedarikçi Ekle";
            this.btnAddNewSupplıerScreen.UseVisualStyleBackColor = true;
            this.btnAddNewSupplıerScreen.Click += new System.EventHandler(this.btnAddNewSupplierScreen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 26);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tedarikçi Yönetimi";
            // 
            // ManageSuppliersScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 541);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "ManageSuppliersScreen";
            this.Text = "ManageSuppliersScreen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSupplıersListScreen;
        private System.Windows.Forms.Button btnUpdateSupplıerScreen;
        private System.Windows.Forms.Button btnAddNewSupplıerScreen;
        private System.Windows.Forms.Label label1;
    }
}