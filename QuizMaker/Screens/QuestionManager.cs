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
            TextboxCategory.AutoCompleteCustomSource.Add("Apple");
            TextboxCategory.AutoCompleteCustomSource.Add("Banana");
            TextboxCategory.AutoCompleteCustomSource.Add("Cherry");
            TextboxCategory.AutoCompleteMode = AutoCompleteMode.Suggest;
            TextboxCategory.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }

        private void materialMultiLineTextBox21_Click(object sender, EventArgs e)
        {

        }

        private void ButtonAddQuestion_Click(object sender, EventArgs e)
        {
            FragenDB.FragenTabelleDataTable fragenDB = new FragenDB.FragenTabelleDataTable();
            FragenDB.FragenTabelleRow newRow = fragenDB.NewFragenTabelleRow();

            newRow.category = TextboxCategory.Text;
            newRow.question = TextboxQuestion.Text;
            newRow.correct_answer = TextboxCorrect.Text;
            newRow.wrong_answer1 = TextboxWrong1.Text;
            newRow.wrong_answer2 = TextboxWrong2.Text;
            newRow.wrong_answer3 = TextboxWrong3.Text;

            fragenDB.AddFragenTabelleRow(newRow);
            fragenDB.AcceptChanges();
        }

        private void ListboxQuestions_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {

        }
    }
}
