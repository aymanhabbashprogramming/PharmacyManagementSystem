using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pharmacy.Screens.PharmacistScreens
{
    public partial class ManagePharmacistScreen : Form
    {
        public ManagePharmacistScreen()
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

        private void btnAddNewPharmacistScreen_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is AddNewPharmacistScreen)
                return;

            _CloseActiveChildForms();

            AddNewPharmacistScreen addNewPharmacistScreen = new AddNewPharmacistScreen();
            _ShowFormInTopLeft(addNewPharmacistScreen);
        }

        private void btnUpdatePharmacistScreen_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is UpdatePharmacistScreen)
                return;

            _CloseActiveChildForms();

            UpdatePharmacistScreen updatePharmacistScreen = new UpdatePharmacistScreen();
            _ShowFormInTopLeft(updatePharmacistScreen);
        }

        private void btnPharmacistsListScreen_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is PharmacistsListScreen)
                return;

            _CloseActiveChildForms();

            PharmacistsListScreen pharmacistsListScreen = new PharmacistsListScreen();
            _ShowFormInTopLeft(pharmacistsListScreen);
        }
    }
}