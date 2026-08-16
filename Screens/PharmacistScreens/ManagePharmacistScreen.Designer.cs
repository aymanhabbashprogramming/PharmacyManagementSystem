namespace Pharmacy.Screens.PharmacistScreens
{
    partial class ManagePharmacistScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddNewPharmacistScreen = new System.Windows.Forms.Button();
            this.btnUpdatePharmacistScreen = new System.Windows.Forms.Button();
            this.btnPharmacistsListScreen = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 26);
            this.label1.TabIndex = 16;
            this.label1.Text = "Eczacı Yönetimi";
            // 
            // btnAddNewPharmacistScreen
            // 
            this.btnAddNewPharmacistScreen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewPharmacistScreen.Location = new System.Drawing.Point(12, 82);
            this.btnAddNewPharmacistScreen.Name = "btnAddNewPharmacistScreen";
            this.btnAddNewPharmacistScreen.Size = new System.Drawing.Size(192, 40);
            this.btnAddNewPharmacistScreen.TabIndex = 18;
            this.btnAddNewPharmacistScreen.Text = "Yeni Eczacı Ekle";
            this.btnAddNewPharmacistScreen.UseVisualStyleBackColor = true;
            this.btnAddNewPharmacistScreen.Click += new System.EventHandler(this.btnAddNewPharmacistScreen_Click);
            // 
            // btnUpdatePharmacistScreen
            // 
            this.btnUpdatePharmacistScreen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePharmacistScreen.Location = new System.Drawing.Point(12, 143);
            this.btnUpdatePharmacistScreen.Name = "btnUpdatePharmacistScreen";
            this.btnUpdatePharmacistScreen.Size = new System.Drawing.Size(192, 40);
            this.btnUpdatePharmacistScreen.TabIndex = 19;
            this.btnUpdatePharmacistScreen.Text = "Eczacı Güncelle";
            this.btnUpdatePharmacistScreen.UseVisualStyleBackColor = true;
            this.btnUpdatePharmacistScreen.Click += new System.EventHandler(this.btnUpdatePharmacistScreen_Click);
            // 
            // btnPharmacistsListScreen
            // 
            this.btnPharmacistsListScreen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPharmacistsListScreen.Location = new System.Drawing.Point(12, 200);
            this.btnPharmacistsListScreen.Name = "btnPharmacistsListScreen";
            this.btnPharmacistsListScreen.Size = new System.Drawing.Size(192, 40);
            this.btnPharmacistsListScreen.TabIndex = 20;
            this.btnPharmacistsListScreen.Text = "Eczacı Listesi";
            this.btnPharmacistsListScreen.UseVisualStyleBackColor = true;
            this.btnPharmacistsListScreen.Click += new System.EventHandler(this.btnPharmacistsListScreen_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.btnPharmacistsListScreen);
            this.panel1.Controls.Add(this.btnUpdatePharmacistScreen);
            this.panel1.Controls.Add(this.btnAddNewPharmacistScreen);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 579);
            this.panel1.TabIndex = 17;
            // 
            // ManagePharmacistScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 579);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "ManagePharmacistScreen";
            this.Text = "ManagePharmacistScreen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddNewPharmacistScreen;
        private System.Windows.Forms.Button btnUpdatePharmacistScreen;
        private System.Windows.Forms.Button btnPharmacistsListScreen;
        private System.Windows.Forms.Panel panel1;
    }
}