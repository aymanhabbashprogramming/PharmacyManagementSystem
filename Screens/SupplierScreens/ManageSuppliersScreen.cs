using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pharmacy.Screens.SupplierScreens
{
    public partial class ManageSuppliersScreen : Form
    {
        public ManageSuppliersScreen()
        {
            InitializeComponent();
        }

        private void _CloseActiveChildForms()
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
        }

        private void _ShowFormInTopLeft(Form frm)
        {
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point(0, 0);
            frm.Show();
        }

        private void btnAddNewSupplierScreen_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is AddNewSupplierScreen)
                return;

            _CloseActiveChildForms();

            AddNewSupplierScreen addNewSupplierScreen = new AddNewSupplierScreen();
            _ShowFormInTopLeft(addNewSupplierScreen);
        }

        private void btnUpdateSupplierScreen_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is UpdateSupplierScreen)
                return;

            _CloseActiveChildForms();

            UpdateSupplierScreen updateSupplierScreen = new UpdateSupplierScreen();
            _ShowFormInTopLeft(updateSupplierScreen);
        }

        private void btnSuppliersListScreen_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is SuppliersListScreen)
                return;

            _CloseActiveChildForms();

            SuppliersListScreen suppliersListScreen = new SuppliersListScreen();
            _ShowFormInTopLeft(suppliersListScreen);
        }
    }
}