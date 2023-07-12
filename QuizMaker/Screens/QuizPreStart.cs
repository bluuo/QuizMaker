using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizMaker.Screens
{
    public partial class QuizPreStart : MaterialForm
    {
        public QuizPreStart()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;

            materialListBox1 = new MaterialListBox();

            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme
                (Primary.Grey800,
                 Primary.Grey900,
                 Primary.Grey500,
                 Accent.LightBlue700,
                 TextShade.WHITE);
        }

        private void QuizPreStart_Load(object sender, EventArgs e)
        {

        }
    }
}
