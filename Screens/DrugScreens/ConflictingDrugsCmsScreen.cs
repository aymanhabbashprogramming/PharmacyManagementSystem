using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.Screens.DrugScreens
{
    public partial class ConflictingDrugsCmsScreen : Form
    {
        public ConflictingDrugsCmsScreen()
        {
            InitializeComponent();
        }

        private void ConflictingDrugsCmsScreen_Load(object sender, EventArgs e)
        {
            btnClose.Image = FontAwesome.Sharp.IconChar.Times.ToBitmap(System.Drawing.Color.Crimson,28);
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
        }
    }
}
