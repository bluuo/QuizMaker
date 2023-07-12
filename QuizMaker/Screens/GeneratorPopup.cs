using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizMaker.Screens
{
    public partial class GeneratorPopup : MaterialForm
    {
        public GeneratorPopup()
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

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonGenerate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < NumberSlider.Value; i++)
            {
                generateQuestion();
            }
            this.Close();
            MainForm.GetInstance().showQuestionManager();
        }
        private void generateQuestion()
        {
            OpenAIGptClient client = new OpenAIGptClient();

            string level = "";
            switch (LevelSlider.Value)
            {
                case 0:
                    level = "sehr leichte ";
                    break;
                case 1:
                    level = "leichte ";
                    break;
                case 2:
                    level = "";
                    break;
                case 3:
                    level = "mittelschwere ";
                    break;
                case 4:
                    level = "schwere ";
                    break;
                case 5:
                    level = "sehr schwere ";
                    break;
            }

            string prompt = "Generiere eine " + level + "Quizfrage zum Thema '" + TextboxCategory.Text + "' mit 4 möglichen antworten. die erste Antwort soll richtig sein. Antworte direkt mit der Frage und den Antworten.Verwende dabei folgende Vorlage: Frage@Richtige Antwort@Falsche Antwort@Falsche Antwort@Falsche Antwort";

            int resultLength;
            int counter = 0;
            string[] result;
            do
            {
                string response = client.SendApiRequest(prompt);
                string content = client.ExtractContentFromResponse(response);
                string[] temp_result = content.Split('@');
                resultLength = temp_result.Length;
                result = temp_result;

                

                counter++;
            } while (resultLength != 5 && counter < 5);
            if (counter >= 5)
                return;

            HelperClass.Question question = new HelperClass.Question()
            {
                Category = TextboxCategory.Text,
                QuestionText = result[0],
                CorrectAnswer = result[1],
                WrongAnswer1 = result[2],
                WrongAnswer2 = result[3],
                WrongAnswer3 = result[4],
            };

            HelperClass.GetInstance().insertQuestion(question);
        }

        private void LevelSlider_Click(object sender, EventArgs e)
        {

        }
    }
}
