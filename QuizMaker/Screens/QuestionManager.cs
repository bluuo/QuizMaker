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

namespace QuizMaker.Screens
{
    public partial class QuestionManager : MaterialForm
    {
        //private string connectionString = Properties.Settings.Default.dbConnection;
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
            TextboxCategory.AutoCompleteCustomSource.Add("Apple");
            TextboxCategory.AutoCompleteCustomSource.Add("Banana");
            TextboxCategory.AutoCompleteCustomSource.Add("Cherry");
            TextboxCategory.AutoCompleteMode = AutoCompleteMode.Suggest;
            TextboxCategory.AutoCompleteSource = AutoCompleteSource.CustomSource;

            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\micha\\Source\\Repos\\bluuo\\QuizMaker\\QuizMaker\\Questions.mdf;Integrated Security=True"; // Replace with your actual connection string
           

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM QuestionsTable"; // Replace with your actual table name

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
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
                            string rowText = $"{id} {category} {question}";

                            // Add the row to the ListBox
                            ListboxQuestions.Items.Add(rowText);
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
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\micha\\Source\\Repos\\bluuo\\QuizMaker\\QuizMaker\\Questions.mdf;Integrated Security=True"; // Replace with your actual connection string

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = connection.CreateCommand();
            connection.Open();
            command.CommandText =
                "Insert into QuestionsTable(category, question, answer_correct, answer_wrong1, answer_wrong2, answer_wrong3) " +
                "VALUES ('value1', 'value2', 'value3', 'value4', 'value5', 'value6')";
            command.Connection = connection;
            command.ExecuteNonQuery();
            MessageBox.Show("Record Submitted", "Congrats");
            connection.Close();

        }

        private void ListboxQuestions_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {

        }

        private void ListboxQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
