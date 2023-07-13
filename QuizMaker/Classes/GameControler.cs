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

            foreach (Question question in questions)
            {
                int result = await PlayQuiz.GetInstance().showQuestion(question);

                if (result == CorrectAnswer) 
                {
                    
                }
                await Task.Delay(3000);
            }
        }
    }
}
