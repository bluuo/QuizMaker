using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuizMaker.DAO;
using static QuizMaker.Helper;

namespace QuizMaker.Screens
{
    public partial class PlayQuiz : MaterialForm
    {
        private Question currentQuestion;
        private bool answersIsCorrect = false;
        private static PlayQuiz instance;

        public static PlayQuiz GetInstance()
        {
            if (instance == null)
                instance = new PlayQuiz();

            return instance;
        }
        public PlayQuiz()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme
            (Primary.Grey600,
            Primary.Grey900,
                 Primary.Amber100,
                 Accent.LightBlue700,
                 TextShade.WHITE);

            this.setButtonsDesign();
        }

        public async Task<int> showQuestion(Question question)
        {
            this.setButtonsDesign();
            currentQuestion = question;

            LabelFrage.Text = question.QuestionText;
            List<string> answers = new List<string>
            {
                question.CorrectAnswer,
                question.WrongAnswer1,
                question.WrongAnswer2,
                question.WrongAnswer3
            };

            Random random = new Random();

            // Randomly assign an answer to Antwort_A.Text
            int indexA = random.Next(answers.Count);
            Antwort_A.Text = answers[indexA];
            answers.RemoveAt(indexA);

            // Randomly assign an answer to Antwort_B.Text
            int indexB = random.Next(answers.Count);
            Antwort_B.Text = answers[indexB];
            answers.RemoveAt(indexB);

            // Randomly assign an answer to Antwort_C.Text
            int indexC = random.Next(answers.Count);
            Antwort_C.Text = answers[indexC];
            answers.RemoveAt(indexC);

            // Assign the remaining answer to Antwort_D.Text
            Antwort_D.Text = answers[0];

            MainForm.GetInstance().showPlayQuiz();

            // Create a task completion source to wait for button click event
            var taskCompletionSource = new TaskCompletionSource<int>();

            void ButtonClickHandler(object sender, EventArgs e)
            {
                // Unsubscribe from all button click events
                Antwort_A.Click -= ButtonClickHandler;
                Antwort_B.Click -= ButtonClickHandler;
                Antwort_C.Click -= ButtonClickHandler;
                Antwort_D.Click -= ButtonClickHandler;

                // Determine the selected answer and set the task completion source result accordingly
                if (sender == Antwort_A)
                    taskCompletionSource.SetResult(0);
                else if (sender == Antwort_B)
                    taskCompletionSource.SetResult(1);
                else if (sender == Antwort_C)
                    taskCompletionSource.SetResult(2);
                else if (sender == Antwort_D)
                    taskCompletionSource.SetResult(3);
            }

            // Subscribe to the button click event
            Antwort_A.Click += ButtonClickHandler;
            Antwort_B.Click += ButtonClickHandler;
            Antwort_C.Click += ButtonClickHandler;
            Antwort_D.Click += ButtonClickHandler;

            // Wait for the button click event to occur
            await taskCompletionSource.Task;

            if (answersIsCorrect)
                return CorrectAnswer;
            else
                return FalseAnswer;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void materialButton3_Click(object sender, EventArgs e)
        {
            MainForm.GetInstance().showMenu();
            this.Visible = false;
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }
        private bool checkAnswer(string answer)
        {
            if (answer == currentQuestion.CorrectAnswer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ProgressBar_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Antwort_A_Click_1(object sender, EventArgs e)
        {
            if (checkAnswer(Antwort_A.Text) == true)
            {
                answersIsCorrect = true;
                Antwort_A.BackColor = Color.DarkGreen;
            }
            else
            {
                Antwort_A.BackColor = Color.FromArgb(153, 12, 8);
            }
        }

        private void Antwort_B_Click_1(object sender, EventArgs e)
        {
            if (checkAnswer(Antwort_B.Text) == true)
            {
                answersIsCorrect = true;
                Antwort_B.BackColor = Color.DarkGreen;
            }
            else
            {
                Antwort_B.BackColor = Color.FromArgb(153, 12, 8);
            }
        }

        private void Antwort_C_Click_1(object sender, EventArgs e)
        {
            if (checkAnswer(Antwort_C.Text) == true)
            {
                answersIsCorrect = true;
                Antwort_C.BackColor = Color.DarkGreen;
            }
            else
            {
                Antwort_C.BackColor = Color.FromArgb(153, 12, 8);
            }
        }

        private void Antwort_D_Click_1(object sender, EventArgs e)
        {
            if (checkAnswer(Antwort_D.Text) == true)
            {
                answersIsCorrect = true;
                Antwort_D.BackColor = Color.DarkGreen;
            }
            else
            {
                Antwort_D.BackColor = Color.FromArgb(153, 12, 8);
            }
        }

        public void setButtonsDesign()
        {
            Antwort_A.Font = new Font("Microsoft Sans Serif", 20);
            Antwort_B.Font = new Font("Microsoft Sans Serif", 20);
            Antwort_C.Font = new Font("Microsoft Sans Serif", 20);
            Antwort_D.Font = new Font("Microsoft Sans Serif", 20);


            Antwort_A.BackColor = Color.FromArgb(65, 69, 74);
            Antwort_B.BackColor = Color.FromArgb(65, 69, 74);
            Antwort_C.BackColor = Color.FromArgb(65, 69, 74);
            Antwort_D.BackColor = Color.FromArgb(65, 69, 74);
        }
    }
}
