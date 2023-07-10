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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Npgsql;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;
using System.IO;

namespace QuizMaker.Screens
{
    public partial class QuestionManager : MaterialForm
    {
        //private string connectionString = Properties.Settings.Default.dbConnection;

        private static string relativePath = "..\\..\\Questions.mdf";
        private static string absolutePath = Path.GetFullPath(relativePath);
        private string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={absolutePath};Integrated Security=True";

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

        private void updateQuestionListbox()
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM QuestionsTable"; // Replace with your actual table name

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        QuestionBox.Items.Clear();

                        while (reader.Read())
                        {
                            // Retrieve values for each row
                            int id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                            string category = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                            string question = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);
                            string answer_correct = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                            string answer_wrong1 = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);
                            string answer_wrong2 = reader.IsDBNull(5) ? string.Empty : reader.GetString(5);
                            string answer_wrong3 = reader.IsDBNull(6) ? string.Empty : reader.GetString(6);

                            // Create a formatted string to represent the row


                            MaterialListBoxItem rowText = new MaterialListBoxItem(""+id+" "+category+" "+question+"");

                            // Add the row to the ListBox
                            QuestionBox.AddItem(rowText);
                            //ListboxQuestions.Items.Add(rowText);
                        }
                    }
                }
            }
        }

        private void materialMultiLineTextBox21_Click(object sender, EventArgs e)
        {

        }

        private void ButtonAddQuestion_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = connection.CreateCommand();
            connection.Open();
            command.CommandText =
                "Insert into QuestionsTable(category, question, answer_correct, answer_wrong1, answer_wrong2, answer_wrong3) " +
                "VALUES ('"+TextboxCategory.Text+"', '"+TextboxCategory.Text+"', '"+TextboxCorrect.Text+"', '"+TextboxWrong1.Text+"', '"+TextboxWrong2.Text+"', '"+TextboxWrong3.Text+"')";
            command.Connection = connection;
            command.ExecuteNonQuery();
            connection.Close();
            updateQuestionListbox();
        }

        private void ListboxQuestions_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {

        }

        private void ListboxQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (QuestionBox.SelectedIndex == -1) //no selection
                MessageBox.Show("Bitte wählen Sie eine Frage aus!");
            else
            {
                Regex regex = new Regex(@"^\d+");
                Match match = regex.Match(QuestionBox.SelectedItem.Text.ToString());

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = connection.CreateCommand();
                connection.Open();
                command.CommandText = "DELETE from QuestionsTable where id =" + match.Value.ToString();
                command.Connection = connection;
                command.ExecuteNonQuery();
                connection.Close();
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
            OpenAIGptClient client = new OpenAIGptClient();
            string prompt = "Generiere eine interessante Quizfrage mit 4 möglichen antworten. die erste Antwort soll richtig sein. Antworte direkt mit der Frage und den Antworten.Verwende dabei folgende Vorlage: Frage@Richtige Antwort@Falsche Antwort@Falsche Antwort@Falsche Antwort";
            
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
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = connection.CreateCommand();
            connection.Open();
            command.CommandText =
                "Insert into QuestionsTable(category, question, answer_correct, answer_wrong1, answer_wrong2, answer_wrong3) " +
                "VALUES ('AI', '" + result[0] + "', '" + result[1] + "', '" + result[2] + "', '" + result[3] + "', '" + result[4] + "')";
            command.Connection = connection;
            command.ExecuteNonQuery();
            connection.Close();
            updateQuestionListbox();

        }

        private void QuestionBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Regex regex = new Regex(@"^\d+");
            Match match = regex.Match(QuestionBox.SelectedItem.Text.ToString());

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * from QuestionsTable where id =" + match.Value.ToString();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        QuestionBox.Items.Clear();

                        while (reader.Read())
                        {
                            TextboxCategory.Text = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                            TextboxQuestion.Text = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);
                            TextboxCorrect.Text = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                            TextboxWrong1.Text = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);
                            TextboxWrong2.Text = reader.IsDBNull(5) ? string.Empty : reader.GetString(5);
                            TextboxWrong3.Text = reader.IsDBNull(6) ? string.Empty : reader.GetString(6);
                        }
                    }
                }
            }
            updateQuestionListbox();
        }
    }
}
