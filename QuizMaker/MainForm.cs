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

namespace QuizMaker
{
    public partial class MainForm : MaterialForm
    {
        private static MainForm instance;

        public static MainForm GetInstance()
        {
            if (instance == null)
                instance = new MainForm();

            return instance;
        }
        public MainForm()
        {
            InitializeComponent();
            instance = this;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme

                (Primary.Grey800,
                 Primary.Grey900,
                 Primary.Grey500,
                 Accent.LightBlue700,
                 TextShade.WHITE);



            showMenu();
        }

        public void showMenu()
        {
            Screens.Menu menu = new Screens.Menu();
            menu.TopLevel = false;
            menu.Dock = DockStyle.Fill;
            menu.FormBorderStyle = FormBorderStyle.None;

            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(menu);
            menu.Show();
        }

        public void showPlayQuiz()
        {
            Screens.PlayQuiz playQuiz = new Screens.PlayQuiz();
            playQuiz.TopLevel = false;
            playQuiz.Dock = DockStyle.Fill;
            playQuiz.FormBorderStyle = FormBorderStyle.None;

            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(playQuiz);
            playQuiz.Show();
        }

        public void showQuestionManager()
        {
            Screens.QuestionManager questionManager = new Screens.QuestionManager();
            questionManager.TopLevel = false;
            questionManager.Dock = DockStyle.Fill;
            questionManager.FormBorderStyle = FormBorderStyle.None;

            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(questionManager);
            questionManager.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
