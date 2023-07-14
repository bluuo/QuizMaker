using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuizMaker.Helper;
using static QuizMaker.DAO;

namespace QuizMaker.Screens
{
    public partial class PrePlayQuiz : MaterialForm
    {
        public PrePlayQuiz()
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
        private void materialListBox1_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {

        }

        public void updateQuestionListbox()
        {
            List<Quiz> quizList = DAO.GetInstance().getAllQuizzes();

            QuizBox.Clear();

            foreach (var quiz in quizList)
            {
                MaterialListBoxItem rowText = new MaterialListBoxItem("" + quiz.Id + " " + quiz.Category + " " + quiz.Size + "");
                QuizBox.Items.Add(rowText);
            }
        }

        private void PrePlayQuiz_Load(object sender, EventArgs e)
        {
            updateQuestionListbox();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (TextboxAnzahl.Text != null || TextboxKategorie.Text != null || TextboxName != null) //no selection
                MessageBox.Show("Bitte alle Felder ausfüllen");
            else
            {
                Quiz quiz = new Quiz()
                {
                    Size = Int32.Parse(TextboxAnzahl.Text),
                    Category = TextboxKategorie.Text,
                    Name = TextboxName.Text
                };

                DAO.GetInstance().insertQuiz(quiz);
                updateQuestionListbox();
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (QuizBox.SelectedIndex == -1) //no selection
                MessageBox.Show("Bitte wählen Sie ein Quiz aus!");
            else
            {
                Regex regex = new Regex(@"^\d+");
                Match match = regex.Match(QuizBox.SelectedItem.Text.ToString());
  
                GameControler gameControler = new GameControler(Int32.Parse(match.Value));
                gameControler.startQuiz();
            };
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (QuizBox.SelectedIndex == -1) //no selection
                MessageBox.Show("Bitte wähle ein Quiz aus");
            else
            {
                Regex regex = new Regex(@"^\d+");
                Match match = regex.Match(QuizBox.SelectedItem.Text.ToString());

                DAO.GetInstance().deleteQuiz(int.Parse(match.Value));
                updateQuestionListbox();
            };

        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            MainForm.GetInstance().showMenu();
            this.Visible = false;
        }

        private void QuizBox_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            Regex regex = new Regex(@"^\d+");
            Match match = regex.Match(QuizBox.SelectedItem.Text.ToString());

            GameControler gameControler = new GameControler(Int32.Parse(match.Value));
            gameControler.startQuiz();

        }
    }
}
