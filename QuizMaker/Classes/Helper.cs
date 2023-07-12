using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker
{
    internal class Helper
    {
        public class Question
        {
            public int Id { get; set; }
            public string Category { get; set; }
            public string QuestionText { get; set; }
            public string CorrectAnswer { get; set; }
            public string WrongAnswer1 { get; set; }
            public string WrongAnswer2 { get; set; }
            public string WrongAnswer3 { get; set; }
        }

        public class Quiz
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Category { get; set; }
            public int Size { get; set; }
        }
    }
}
