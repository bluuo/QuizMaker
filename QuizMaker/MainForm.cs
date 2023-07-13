using MaterialSkin;
using MaterialSkin.Controls;
using QuizMaker.Screens;
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
            Screens.PlayQuiz playQuiz = PlayQuiz.GetInstance();
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

        public void showPrePlayQuiz()
        {
            //toDO
            Screens.PrePlayQuiz prePlayQuiz = new Screens.PrePlayQuiz();
            prePlayQuiz.TopLevel = false;
            prePlayQuiz.Dock = DockStyle.Fill;
            prePlayQuiz.FormBorderStyle = FormBorderStyle.None;

            //toDO
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(prePlayQuiz);
            prePlayQuiz.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void playQuiz(string name, String category, int size)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
