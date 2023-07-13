using QuizMaker.Screens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuizMaker.Helper;

namespace QuizMaker
{
    internal class GameControler
    {
        private Quiz currentQuiz;

        public GameControler(int quizId)
        {
            currentQuiz = DAO.GetInstance().getSingleQuiz(quizId);
        }

        public async void startQuiz()
        {
            List<Question> questions = DAO.GetInstance().getQuestionsForQuiz(currentQuiz.Name, currentQuiz.Category, currentQuiz.Size);

            int index = 0;
            PlayQuiz.GetInstance().ProgressBar.Maximum = questions.Count();
            PlayQuiz.GetInstance().labelQCount.Text = questions.Count().ToString();
            foreach (Question question in questions)
            {
                PlayQuiz.GetInstance().ProgressBar.Select();
                index++;
                PlayQuiz.GetInstance().ProgressBar.Value = index;
                PlayQuiz.GetInstance().labelCurrentQ.Text = index.ToString();
                int result = await PlayQuiz.GetInstance().showQuestion(question);

                if (result == CorrectAnswer) 
                {
                }
                else
                {
                }
                await Task.Delay(500);
                PlayQuiz.GetInstance().setButtonsDesign();
            }
            MainForm.GetInstance().showMenu();
        }
    }
}
