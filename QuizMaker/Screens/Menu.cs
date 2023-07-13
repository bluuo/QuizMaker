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
    public partial class Menu : MaterialForm
    {
        public Menu()
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

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            //Screens.PlayQuiz Quiz = new Screens.PlayQuiz();
            //Quiz.Show();
            //this.Visible = false;

            MainForm.GetInstance().showQuestionManager();
            this.Visible = false;
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            MainForm.GetInstance().Close();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            MainForm.GetInstance().showQuestionManager();
            this.Visible = false;
        }
    }
}
