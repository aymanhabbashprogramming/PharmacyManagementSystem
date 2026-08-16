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
    public partial class ShowDispenseDrugCmsScreen : Form
    {
        public ShowDispenseDrugCmsScreen()
        {
            InitializeComponent();
        }

        private void ShowDispenseDrugCmsScreen_Load(object sender, EventArgs e)
        {
            btnClose.Image = FontAwesome.Sharp.IconChar.Times.ToBitmap(Color.Crimson, 30);
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.TextAlign = ContentAlignment.MiddleCenter;
        }
    }
}
