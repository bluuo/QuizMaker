using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static QuizMaker.DAO;
using static QuizMaker.Helper;

namespace QuizMaker.Screens
{
    public partial class QuestionManager : MaterialForm
    {
        public QuestionManager()
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

        private void QuestionManager_Load(object sender, EventArgs e)
        {
            updateQuestionListbox();
        }

        public void updateQuestionListbox()
        {
            List<Question> questionList = DAO.GetInstance().getAllQuestions();

            QuestionBox.Clear();

            foreach (var question in questionList)
            {
                MaterialListBoxItem rowText = new MaterialListBoxItem("" + question.Id + " " + question.Category + " " + question.QuestionText + "");
                QuestionBox.Items.Add(rowText);
            }
        }

        private void materialMultiLineTextBox21_Click(object sender, EventArgs e)
        {

        }

        private void ButtonAddQuestion_Click(object sender, EventArgs e)
        {
            Question question = new Question
            {
                Category = TextboxCategory.Text,
                QuestionText = TextboxQuestion.Text,
                CorrectAnswer = TextboxCorrect.Text,
                WrongAnswer1 = TextboxWrong1.Text,
                WrongAnswer2 = TextboxWrong2.Text,
                WrongAnswer3 = TextboxWrong3.Text,
            };

            DAO.GetInstance().insertQuestion(question);
            updateQuestionListbox();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (QuestionBox.SelectedIndex == -1) //no selection
                MessageBox.Show("Bitte wählen Sie eine Frage aus!");
            else
            {
                Regex regex = new Regex(@"^\d+");
                Match match = regex.Match(QuestionBox.SelectedItem.Text.ToString());

                DAO.GetInstance().deleteQuestion(int.Parse(match.Value));
                updateQuestionListbox();
            };

        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            MainForm.GetInstance().showMenu();
            this.Visible = false;
        }

        private void ButtonGenerate_Click(object sender, EventArgs e)
        {
            Screens.GeneratorPopup generatorPopup = new Screens.GeneratorPopup();
            generatorPopup.Show();
        }

        private void QuestionBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Regex regex = new Regex(@"^\d+");
            Match match = regex.Match(QuestionBox.SelectedItem.Text.ToString());

            Question selectedQuestion = DAO.GetInstance().getSingleQuestion(int.Parse(match.Value));

            TextboxCategory.Text = selectedQuestion.Category.ToString();
            TextboxQuestion.Text = selectedQuestion.QuestionText.ToString();
            TextboxCorrect.Text = selectedQuestion.CorrectAnswer.ToString();
            TextboxWrong1.Text = selectedQuestion.WrongAnswer1.ToString();
            TextboxWrong2.Text = selectedQuestion.WrongAnswer2.ToString();
            TextboxWrong3.Text = selectedQuestion.WrongAnswer3.ToString();
        }

        private void QuestionManager_Enter(object sender, EventArgs e)
        {

        }
    }
}
