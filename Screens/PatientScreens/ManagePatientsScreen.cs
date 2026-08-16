using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pharmacy.Screens.PatientScreens
{
    public partial class ManagePatientsScreen : Form
    {
        public ManagePatientsScreen()
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

        private void btnAddNewPatientScreen_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is AddNewPatientScreen)
                return;

            _CloseActiveChildForms();

            AddNewPatientScreen addNewPatientScreen = new AddNewPatientScreen();
            _ShowFormInTopLeft(addNewPatientScreen);
        }

        private void btnUpdatePatientScreen_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is UpdatePatientScreen)
                return;

            _CloseActiveChildForms();

            UpdatePatientScreen updatePatientScreen = new UpdatePatientScreen();
            _ShowFormInTopLeft(updatePatientScreen);
        }

        private void btnPatientsListScreen_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is PatientsListScreen)
                return;

            _CloseActiveChildForms();

            PatientsListScreen patientsListScreen = new PatientsListScreen();
            _ShowFormInTopLeft(patientsListScreen);
        }
    }
}