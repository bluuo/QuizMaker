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


        private void materialListBox1_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {
            Regex regex = new Regex(@"^\d+");
            Match match = regex.Match(QuestionBox.SelectedItem.Text.ToString());

            using (SqlConnection connection = new SqlConnection(connectionString))

        }




    }
}
