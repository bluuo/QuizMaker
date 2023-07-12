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
    public partial class PlayQuiz : MaterialForm
    {
        public PlayQuiz()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme
                (Primary.Grey800,
                 Primary.Grey900,
                 Primary.Grey500,
                 Accent.LightBlue700,
                 TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Antwort3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Antwort2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Antwort1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Antwort4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            MainForm.GetInstance().showMenu();
            this.Visible = false;
        }
    }
}
