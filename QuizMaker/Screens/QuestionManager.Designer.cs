using MaterialSkin;
using System;

namespace QuizMaker.Screens
{
    partial class QuestionManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.ButtonLöschen = new MaterialSkin.Controls.MaterialButton();
            this.ButtonAddQuestion = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.TextboxCorrect = new MaterialSkin.Controls.MaterialTextBox();
            this.TextboxWrong1 = new MaterialSkin.Controls.MaterialTextBox();
            this.TextboxWrong2 = new MaterialSkin.Controls.MaterialTextBox();
            this.TextboxWrong3 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.QuestionBox = new MaterialSkin.Controls.MaterialListBox();
            this.TextboxCategory = new MaterialSkin.Controls.MaterialTextBox();
            this.ButtonGenerate = new MaterialSkin.Controls.MaterialButton();
            this.fragenTabelleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TextboxQuestion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fragenTabelleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(331, 90);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(41, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Frage";
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(335, 192);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(117, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Richtige Antwort";
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(336, 249);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(115, 19);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "Falsche Antwort";
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(335, 307);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(115, 19);
            this.materialLabel4.TabIndex = 8;
            this.materialLabel4.Text = "Falsche Antwort";
            // 
            // materialLabel5
            // 
            this.materialLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(335, 365);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(115, 19);
            this.materialLabel5.TabIndex = 10;
            this.materialLabel5.Text = "Falsche Antwort";
            // 
            // ButtonLöschen
            // 
            this.ButtonLöschen.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonLöschen.AutoSize = false;
            this.ButtonLöschen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonLöschen.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonLöschen.Depth = 0;
            this.ButtonLöschen.HighEmphasis = true;
            this.ButtonLöschen.Icon = null;
            this.ButtonLöschen.Location = new System.Drawing.Point(68, 552);
            this.ButtonLöschen.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonLöschen.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonLöschen.Name = "ButtonLöschen";
            this.ButtonLöschen.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonLöschen.Size = new System.Drawing.Size(215, 31);
            this.ButtonLöschen.TabIndex = 8;
            this.ButtonLöschen.Text = "Ausgewählte löschen";
            this.ButtonLöschen.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonLöschen.UseAccentColor = false;
            this.ButtonLöschen.UseVisualStyleBackColor = true;
            this.ButtonLöschen.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // ButtonAddQuestion
            // 
            this.ButtonAddQuestion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonAddQuestion.AutoSize = false;
            this.ButtonAddQuestion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonAddQuestion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonAddQuestion.Depth = 0;
            this.ButtonAddQuestion.HighEmphasis = true;
            this.ButtonAddQuestion.Icon = null;
            this.ButtonAddQuestion.Location = new System.Drawing.Point(478, 552);
            this.ButtonAddQuestion.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonAddQuestion.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonAddQuestion.Name = "ButtonAddQuestion";
            this.ButtonAddQuestion.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonAddQuestion.Size = new System.Drawing.Size(189, 31);
            this.ButtonAddQuestion.TabIndex = 7;
            this.ButtonAddQuestion.Text = "Frage hinzufügen";
            this.ButtonAddQuestion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonAddQuestion.UseAccentColor = false;
            this.ButtonAddQuestion.UseVisualStyleBackColor = true;
            this.ButtonAddQuestion.Click += new System.EventHandler(this.ButtonAddQuestion_Click);
            // 
            // materialLabel6
            // 
            this.materialLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(335, 422);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(68, 19);
            this.materialLabel6.TabIndex = 13;
            this.materialLabel6.Text = "Kategorie";
            // 
            // TextboxCorrect
            // 
            this.TextboxCorrect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextboxCorrect.AnimateReadOnly = false;
            this.TextboxCorrect.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextboxCorrect.Depth = 0;
            this.TextboxCorrect.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextboxCorrect.LeadingIcon = null;
            this.TextboxCorrect.Location = new System.Drawing.Point(335, 208);
            this.TextboxCorrect.Margin = new System.Windows.Forms.Padding(1);
            this.TextboxCorrect.MaxLength = 50;
            this.TextboxCorrect.MouseState = MaterialSkin.MouseState.OUT;
            this.TextboxCorrect.Multiline = false;
            this.TextboxCorrect.Name = "TextboxCorrect";
            this.TextboxCorrect.Size = new System.Drawing.Size(462, 50);
            this.TextboxCorrect.TabIndex = 2;
            this.TextboxCorrect.Text = "";
            this.TextboxCorrect.TrailingIcon = null;
            // 
            // TextboxWrong1
            // 
            this.TextboxWrong1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextboxWrong1.AnimateReadOnly = false;
            this.TextboxWrong1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextboxWrong1.Depth = 0;
            this.TextboxWrong1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextboxWrong1.LeadingIcon = null;
            this.TextboxWrong1.Location = new System.Drawing.Point(335, 266);
            this.TextboxWrong1.Margin = new System.Windows.Forms.Padding(1);
            this.TextboxWrong1.MaxLength = 50;
            this.TextboxWrong1.MouseState = MaterialSkin.MouseState.OUT;
            this.TextboxWrong1.Multiline = false;
            this.TextboxWrong1.Name = "TextboxWrong1";
            this.TextboxWrong1.Size = new System.Drawing.Size(462, 50);
            this.TextboxWrong1.TabIndex = 3;
            this.TextboxWrong1.Text = "";
            this.TextboxWrong1.TrailingIcon = null;
            // 
            // TextboxWrong2
            // 
            this.TextboxWrong2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextboxWrong2.AnimateReadOnly = false;
            this.TextboxWrong2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextboxWrong2.Depth = 0;
            this.TextboxWrong2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextboxWrong2.LeadingIcon = null;
            this.TextboxWrong2.Location = new System.Drawing.Point(335, 323);
            this.TextboxWrong2.Margin = new System.Windows.Forms.Padding(1);
            this.TextboxWrong2.MaxLength = 50;
            this.TextboxWrong2.MouseState = MaterialSkin.MouseState.OUT;
            this.TextboxWrong2.Multiline = false;
            this.TextboxWrong2.Name = "TextboxWrong2";
            this.TextboxWrong2.Size = new System.Drawing.Size(462, 50);
            this.TextboxWrong2.TabIndex = 4;
            this.TextboxWrong2.Text = "";
            this.TextboxWrong2.TrailingIcon = null;
            // 
            // TextboxWrong3
            // 
            this.TextboxWrong3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextboxWrong3.AnimateReadOnly = false;
            this.TextboxWrong3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextboxWrong3.Depth = 0;
            this.TextboxWrong3.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextboxWrong3.LeadingIcon = null;
            this.TextboxWrong3.Location = new System.Drawing.Point(335, 381);
            this.TextboxWrong3.Margin = new System.Windows.Forms.Padding(1);
            this.TextboxWrong3.MaxLength = 50;
            this.TextboxWrong3.MouseState = MaterialSkin.MouseState.OUT;
            this.TextboxWrong3.Multiline = false;
            this.TextboxWrong3.Name = "TextboxWrong3";
            this.TextboxWrong3.Size = new System.Drawing.Size(462, 50);
            this.TextboxWrong3.TabIndex = 5;
            this.TextboxWrong3.Text = "";
            this.TextboxWrong3.TrailingIcon = null;
            // 
            // materialLabel7
            // 
            this.materialLabel7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel7.Location = new System.Drawing.Point(332, 13);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(119, 41);
            this.materialLabel7.TabIndex = 21;
            this.materialLabel7.Text = "Fragen";
            this.materialLabel7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // materialButton3
            // 
            this.materialButton3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialButton3.AutoSize = false;
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(25, 9);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialButton3.Size = new System.Drawing.Size(68, 33);
            this.materialButton3.TabIndex = 9;
            this.materialButton3.Text = "Zurück";
            this.materialButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            this.materialButton3.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // QuestionBox
            // 
            this.QuestionBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.QuestionBox.BackColor = System.Drawing.Color.White;
            this.QuestionBox.BorderColor = System.Drawing.Color.LightGray;
            this.QuestionBox.Depth = 0;
            this.QuestionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.QuestionBox.Location = new System.Drawing.Point(25, 91);
            this.QuestionBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.QuestionBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.QuestionBox.Name = "QuestionBox";
            this.QuestionBox.SelectedIndex = -1;
            this.QuestionBox.SelectedItem = null;
            this.QuestionBox.Size = new System.Drawing.Size(301, 447);
            this.QuestionBox.TabIndex = 25;
            this.QuestionBox.SelectedIndexChanged += new MaterialSkin.Controls.MaterialListBox.SelectedIndexChangedEventHandler(this.QuestionBox_SelectedIndexChanged);
            this.QuestionBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.QuestionBox_MouseDoubleClick);
            // 
            // TextboxCategory
            // 
            this.TextboxCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextboxCategory.AnimateReadOnly = false;
            this.TextboxCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextboxCategory.Depth = 0;
            this.TextboxCategory.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextboxCategory.LeadingIcon = null;
            this.TextboxCategory.Location = new System.Drawing.Point(335, 440);
            this.TextboxCategory.Margin = new System.Windows.Forms.Padding(1);
            this.TextboxCategory.MaxLength = 50;
            this.TextboxCategory.MouseState = MaterialSkin.MouseState.OUT;
            this.TextboxCategory.Multiline = false;
            this.TextboxCategory.Name = "TextboxCategory";
            this.TextboxCategory.Size = new System.Drawing.Size(235, 50);
            this.TextboxCategory.TabIndex = 6;
            this.TextboxCategory.Text = "";
            this.TextboxCategory.TrailingIcon = null;
            // 
            // ButtonGenerate
            // 
            this.ButtonGenerate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ButtonGenerate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonGenerate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonGenerate.Depth = 0;
            this.ButtonGenerate.HighEmphasis = true;
            this.ButtonGenerate.Icon = null;
            this.ButtonGenerate.Location = new System.Drawing.Point(123, 47);
            this.ButtonGenerate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonGenerate.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonGenerate.Name = "ButtonGenerate";
            this.ButtonGenerate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonGenerate.Size = new System.Drawing.Size(106, 36);
            this.ButtonGenerate.TabIndex = 26;
            this.ButtonGenerate.Text = "Generator";
            this.ButtonGenerate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonGenerate.UseAccentColor = false;
            this.ButtonGenerate.UseVisualStyleBackColor = true;
            this.ButtonGenerate.Click += new System.EventHandler(this.ButtonGenerate_Click);
            // 
            // TextboxQuestion
            // 
            this.TextboxQuestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextboxQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TextboxQuestion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxQuestion.Location = new System.Drawing.Point(331, 108);
            this.TextboxQuestion.Multiline = true;
            this.TextboxQuestion.Name = "TextboxQuestion";
            this.TextboxQuestion.Size = new System.Drawing.Size(467, 50);
            this.TextboxQuestion.TabIndex = 27;
            this.TextboxQuestion.TabStop = false;
            this.TextboxQuestion.Click += new System.EventHandler(this.materialMultiLineTextBox21_Click);
            // 
            // QuestionManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 607);
            this.ControlBox = false;
            this.Controls.Add(this.TextboxQuestion);
            this.Controls.Add(this.ButtonGenerate);
            this.Controls.Add(this.TextboxCategory);
            this.Controls.Add(this.QuestionBox);
            this.Controls.Add(this.materialButton3);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.TextboxWrong3);
            this.Controls.Add(this.TextboxWrong2);
            this.Controls.Add(this.TextboxWrong1);
            this.Controls.Add(this.TextboxCorrect);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.ButtonAddQuestion);
            this.Controls.Add(this.ButtonLöschen);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.MaximizeBox = false;
            this.Name = "QuestionManager";
            this.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Sizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.QuestionManager_Load);
            this.Enter += new System.EventHandler(this.QuestionManager_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.fragenTabelleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void QuestionBox_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {
           
        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialButton ButtonLöschen;
        private MaterialSkin.Controls.MaterialButton ButtonAddQuestion;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialTextBox TextboxCorrect;
        private MaterialSkin.Controls.MaterialTextBox TextboxWrong1;
        private MaterialSkin.Controls.MaterialTextBox TextboxWrong2;
        private MaterialSkin.Controls.MaterialTextBox TextboxWrong3;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private System.Windows.Forms.BindingSource fragenTabelleBindingSource;
        private MaterialSkin.Controls.MaterialListBox QuestionBox;
        private MaterialSkin.Controls.MaterialTextBox TextboxCategory;
        private MaterialSkin.Controls.MaterialButton ButtonGenerate;
        private System.Windows.Forms.TextBox TextboxQuestion;
    }
}