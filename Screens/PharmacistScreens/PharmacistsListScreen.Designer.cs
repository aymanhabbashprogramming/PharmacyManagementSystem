namespace Pharmacy.Screens.PharmacistScreens
{
    partial class PharmacistsListScreen
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
            this.dgvPharmacists = new System.Windows.Forms.DataGridView();
            this.colPharmacistID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsPharmacistsList2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miEditPharmacist = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbUsernames = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUserNameToSearch = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPharmacists)).BeginInit();
            this.cmsPharmacistsList2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPharmacists
            // 
            this.dgvPharmacists.AllowUserToAddRows = false;
            this.dgvPharmacists.AllowUserToDeleteRows = false;
            this.dgvPharmacists.AllowUserToResizeColumns = false;
            this.dgvPharmacists.AllowUserToResizeRows = false;
            this.dgvPharmacists.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPharmacists.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPharmacists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPharmacists.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPharmacistID,
            this.colFirstName,
            this.colLastName,
            this.colUsername,
            this.colPassword,
            this.colPhone,
            this.colEmail,
            this.colIsActive});
            this.dgvPharmacists.ContextMenuStrip = this.cmsPharmacistsList2;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPharmacists.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPharmacists.Location = new System.Drawing.Point(14, 150);
            this.dgvPharmacists.MultiSelect = false;
            this.dgvPharmacists.Name = "dgvPharmacists";
            this.dgvPharmacists.ReadOnly = true;
            this.dgvPharmacists.RowHeadersVisible = false;
            this.dgvPharmacists.RowHeadersWidth = 51;
            this.dgvPharmacists.RowTemplate.Height = 24;
            this.dgvPharmacists.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPharmacists.Size = new System.Drawing.Size(1084, 315);
            this.dgvPharmacists.TabIndex = 0;
            this.dgvPharmacists.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPharmacists_CellFormatting);
            // 
            // colPharmacistID
            // 
            this.colPharmacistID.DataPropertyName = "PharmacistID";
            this.colPharmacistID.HeaderText = "ID";
            this.colPharmacistID.MinimumWidth = 6;
            this.colPharmacistID.Name = "colPharmacistID";
            this.colPharmacistID.ReadOnly = true;
            // 
            // colFirstName
            // 
            this.colFirstName.DataPropertyName = "FirstName";
            this.colFirstName.FillWeight = 20F;
            this.colFirstName.HeaderText = "Ad";
            this.colFirstName.MinimumWidth = 120;
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.ReadOnly = true;
            // 
            // colLastName
            // 
            this.colLastName.DataPropertyName = "LastName";
            this.colLastName.HeaderText = "Soyad";
            this.colLastName.MinimumWidth = 6;
            this.colLastName.Name = "colLastName";
            this.colLastName.ReadOnly = true;
            // 
            // colUsername
            // 
            this.colUsername.DataPropertyName = "Username";
            this.colUsername.HeaderText = "Kullanıcı Adı";
            this.colUsername.MinimumWidth = 6;
            this.colUsername.Name = "colUsername";
            this.colUsername.ReadOnly = true;
            // 
            // colPassword
            // 
            this.colPassword.DataPropertyName = "Password";
            this.colPassword.HeaderText = "Şifre";
            this.colPassword.MinimumWidth = 6;
            this.colPassword.Name = "colPassword";
            this.colPassword.ReadOnly = true;
            // 
            // colPhone
            // 
            this.colPhone.DataPropertyName = "Phone";
            this.colPhone.HeaderText = "Telefon No";
            this.colPhone.MinimumWidth = 6;
            this.colPhone.Name = "colPhone";
            this.colPhone.ReadOnly = true;
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "Email";
            this.colEmail.MinimumWidth = 6;
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            // 
            // colIsActive
            // 
            this.colIsActive.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colIsActive.DataPropertyName = "IsActive";
            this.colIsActive.HeaderText = "Durum";
            this.colIsActive.MinimumWidth = 6;
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.ReadOnly = true;
            this.colIsActive.Width = 90;
            // 
            // cmsPharmacistsList2
            // 
            this.cmsPharmacistsList2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsPharmacistsList2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miEditPharmacist});
            this.cmsPharmacistsList2.Name = "cmsPharmacistsList";
            this.cmsPharmacistsList2.Size = new System.Drawing.Size(133, 28);
            // 
            // miEditPharmacist
            // 
            this.miEditPharmacist.Name = "miEditPharmacist";
            this.miEditPharmacist.Size = new System.Drawing.Size(132, 24);
            this.miEditPharmacist.Text = "Düzenle";
            this.miEditPharmacist.Click += new System.EventHandler(this.miEditPharmacist_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(478, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "Eczacılar Listesi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(806, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(280, 26);
            this.label9.TabIndex = 39;
            this.label9.Text = "Kullanıcı Adına Göre Filtrele";
            // 
            // cmbUsernames
            // 
            this.cmbUsernames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsernames.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbUsernames.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUsernames.FormattingEnabled = true;
            this.cmbUsernames.Location = new System.Drawing.Point(811, 99);
            this.cmbUsernames.Name = "cmbUsernames";
            this.cmbUsernames.Size = new System.Drawing.Size(287, 30);
            this.cmbUsernames.TabIndex = 38;
            this.cmbUsernames.SelectedIndexChanged += new System.EventHandler(this.cmbUsernames_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(249, 92);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(122, 42);
            this.btnSearch.TabIndex = 37;
            this.btnSearch.Text = "Arama Yap";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(204, 26);
            this.label8.TabIndex = 35;
            this.label8.Text = "Kullanıcı Adı İle Ara";
            // 
            // txtUserNameToSearch
            // 
            this.txtUserNameToSearch.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserNameToSearch.Location = new System.Drawing.Point(14, 92);
            this.txtUserNameToSearch.Multiline = true;
            this.txtUserNameToSearch.Name = "txtUserNameToSearch";
            this.txtUserNameToSearch.Size = new System.Drawing.Size(229, 42);
            this.txtUserNameToSearch.TabIndex = 36;
            this.txtUserNameToSearch.Tag = "Kullanıcı Adı";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(578, 92);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(214, 42);
            this.btnRefresh.TabIndex = 40;
            this.btnRefresh.Text = "Listeyi Güncelle";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // PharmacistsListScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1110, 477);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbUsernames);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtUserNameToSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPharmacists);
            this.Name = "PharmacistsListScreen";
            this.Text = "PharmacistsListScreen";
            this.Load += new System.EventHandler(this.PharmacistsListScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPharmacists)).EndInit();
            this.cmsPharmacistsList2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPharmacists;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPharmacistID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsActive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbUsernames;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUserNameToSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ContextMenuStrip cmsPharmacistsList2;
        private System.Windows.Forms.ToolStripMenuItem miEditPharmacist;
    }
}