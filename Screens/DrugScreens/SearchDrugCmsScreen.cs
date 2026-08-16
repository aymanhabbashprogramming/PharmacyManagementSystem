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
    public partial class SearchDrugCmsScreen : Form
    {
        public SearchDrugCmsScreen()
        {
            InitializeComponent();
        }

        private void SearchDrugCmsScreen_Load(object sender, EventArgs e)
        {
            int buttonIconSize = 27;

            btnSearch.Image = IconChar.Search.ToBitmap(Color.MediumSeaGreen, buttonIconSize);
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearch.Text = "  Ara"; 

            btnCancel.Image = IconChar.Times.ToBitmap(Color.Crimson, buttonIconSize);
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.Text = "  İptal";
        }
    }
}
