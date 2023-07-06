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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionManager));
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
            this.TextboxQuestion = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.TextboxCategory = new System.Windows.Forms.TextBox();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.fragenDB1 = new QuizMaker.FragenDB();
            this.fragenTabelleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ListboxQuestions = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.fragenDB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fragenTabelleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(457, 229);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(41, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Frage";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(457, 433);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(117, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Richtige Antwort";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(457, 533);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(115, 19);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "Falsche Antwort";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(457, 633);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(115, 19);
            this.materialLabel4.TabIndex = 8;
            this.materialLabel4.Text = "Falsche Antwort";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(461, 732);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(115, 19);
            this.materialLabel5.TabIndex = 10;
            this.materialLabel5.Text = "Falsche Antwort";
            // 
            // ButtonLöschen
            // 
            this.ButtonLöschen.AutoSize = false;
            this.ButtonLöschen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonLöschen.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonLöschen.Depth = 0;
            this.ButtonLöschen.HighEmphasis = true;
            this.ButtonLöschen.Icon = null;
            this.ButtonLöschen.Location = new System.Drawing.Point(44, 826);
            this.ButtonLöschen.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.ButtonLöschen.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonLöschen.Name = "ButtonLöschen";
            this.ButtonLöschen.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonLöschen.Size = new System.Drawing.Size(371, 38);
            this.ButtonLöschen.TabIndex = 11;
            this.ButtonLöschen.Text = "Ausgewählte löschen";
            this.ButtonLöschen.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonLöschen.UseAccentColor = false;
            this.ButtonLöschen.UseVisualStyleBackColor = true;
            this.ButtonLöschen.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // ButtonAddQuestion
            // 
            this.ButtonAddQuestion.AutoSize = false;
            this.ButtonAddQuestion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonAddQuestion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonAddQuestion.Depth = 0;
            this.ButtonAddQuestion.HighEmphasis = true;
            this.ButtonAddQuestion.Icon = null;
            this.ButtonAddQuestion.Location = new System.Drawing.Point(653, 826);
            this.ButtonAddQuestion.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.ButtonAddQuestion.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonAddQuestion.Name = "ButtonAddQuestion";
            this.ButtonAddQuestion.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonAddQuestion.Size = new System.Drawing.Size(371, 38);
            this.ButtonAddQuestion.TabIndex = 12;
            this.ButtonAddQuestion.Text = "Frage hinzufügen";
            this.ButtonAddQuestion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonAddQuestion.UseAccentColor = false;
            this.ButtonAddQuestion.UseVisualStyleBackColor = true;
            this.ButtonAddQuestion.Click += new System.EventHandler(this.ButtonAddQuestion_Click);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(457, 137);
            this.materialLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(68, 19);
            this.materialLabel6.TabIndex = 13;
            this.materialLabel6.Text = "Kategorie";
            // 
            // TextboxCorrect
            // 
            this.TextboxCorrect.AnimateReadOnly = false;
            this.TextboxCorrect.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextboxCorrect.Depth = 0;
            this.TextboxCorrect.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextboxCorrect.LeadingIcon = null;
            this.TextboxCorrect.Location = new System.Drawing.Point(457, 468);
            this.TextboxCorrect.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxCorrect.MaxLength = 50;
            this.TextboxCorrect.MouseState = MaterialSkin.MouseState.OUT;
            this.TextboxCorrect.Multiline = false;
            this.TextboxCorrect.Name = "TextboxCorrect";
            this.TextboxCorrect.Size = new System.Drawing.Size(759, 50);
            this.TextboxCorrect.TabIndex = 16;
            this.TextboxCorrect.Text = "";
            this.TextboxCorrect.TrailingIcon = null;
            // 
            // TextboxWrong1
            // 
            this.TextboxWrong1.AnimateReadOnly = false;
            this.TextboxWrong1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextboxWrong1.Depth = 0;
            this.TextboxWrong1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextboxWrong1.LeadingIcon = null;
            this.TextboxWrong1.Location = new System.Drawing.Point(457, 567);
            this.TextboxWrong1.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxWrong1.MaxLength = 50;
            this.TextboxWrong1.MouseState = MaterialSkin.MouseState.OUT;
            this.TextboxWrong1.Multiline = false;
            this.TextboxWrong1.Name = "TextboxWrong1";
            this.TextboxWrong1.Size = new System.Drawing.Size(759, 50);
            this.TextboxWrong1.TabIndex = 17;
            this.TextboxWrong1.Text = "";
            this.TextboxWrong1.TrailingIcon = null;
            // 
            // TextboxWrong2
            // 
            this.TextboxWrong2.AnimateReadOnly = false;
            this.TextboxWrong2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextboxWrong2.Depth = 0;
            this.TextboxWrong2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextboxWrong2.LeadingIcon = null;
            this.TextboxWrong2.Location = new System.Drawing.Point(457, 667);
            this.TextboxWrong2.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxWrong2.MaxLength = 50;
            this.TextboxWrong2.MouseState = MaterialSkin.MouseState.OUT;
            this.TextboxWrong2.Multiline = false;
            this.TextboxWrong2.Name = "TextboxWrong2";
            this.TextboxWrong2.Size = new System.Drawing.Size(759, 50);
            this.TextboxWrong2.TabIndex = 18;
            this.TextboxWrong2.Text = "";
            this.TextboxWrong2.TrailingIcon = null;
            // 
            // TextboxWrong3
            // 
            this.TextboxWrong3.AnimateReadOnly = false;
            this.TextboxWrong3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextboxWrong3.Depth = 0;
            this.TextboxWrong3.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextboxWrong3.LeadingIcon = null;
            this.TextboxWrong3.Location = new System.Drawing.Point(457, 753);
            this.TextboxWrong3.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxWrong3.MaxLength = 50;
            this.TextboxWrong3.MouseState = MaterialSkin.MouseState.OUT;
            this.TextboxWrong3.Multiline = false;
            this.TextboxWrong3.Name = "TextboxWrong3";
            this.TextboxWrong3.Size = new System.Drawing.Size(759, 50);
            this.TextboxWrong3.TabIndex = 19;
            this.TextboxWrong3.Text = "";
            this.TextboxWrong3.TrailingIcon = null;
            // 
            // TextboxQuestion
            // 
            this.TextboxQuestion.AnimateReadOnly = false;
            this.TextboxQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TextboxQuestion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TextboxQuestion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxQuestion.Depth = 0;
            this.TextboxQuestion.HideSelection = true;
            this.TextboxQuestion.Location = new System.Drawing.Point(457, 256);
            this.TextboxQuestion.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxQuestion.MaxLength = 32767;
            this.TextboxQuestion.MouseState = MaterialSkin.MouseState.OUT;
            this.TextboxQuestion.Name = "TextboxQuestion";
            this.TextboxQuestion.PasswordChar = '\0';
            this.TextboxQuestion.ReadOnly = false;
            this.TextboxQuestion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextboxQuestion.SelectedText = "";
            this.TextboxQuestion.SelectionLength = 0;
            this.TextboxQuestion.SelectionStart = 0;
            this.TextboxQuestion.ShortcutsEnabled = true;
            this.TextboxQuestion.Size = new System.Drawing.Size(759, 164);
            this.TextboxQuestion.TabIndex = 20;
            this.TextboxQuestion.TabStop = false;
            this.TextboxQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextboxQuestion.UseSystemPasswordChar = false;
            this.TextboxQuestion.Click += new System.EventHandler(this.materialMultiLineTextBox21_Click);
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel7.Location = new System.Drawing.Point(548, 62);
            this.materialLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(107, 41);
            this.materialLabel7.TabIndex = 21;
            this.materialLabel7.Text = "Fragen";
            // 
            // TextboxCategory
            // 
            this.TextboxCategory.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TextboxCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextboxCategory.Location = new System.Drawing.Point(457, 164);
            this.TextboxCategory.Margin = new System.Windows.Forms.Padding(40, 4, 4, 4);
            this.TextboxCategory.Multiline = true;
            this.TextboxCategory.Name = "TextboxCategory";
            this.TextboxCategory.Size = new System.Drawing.Size(291, 45);
            this.TextboxCategory.TabIndex = 22;
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSize = false;
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = ((System.Drawing.Image)(resources.GetObject("materialButton3.Icon")));
            this.materialButton3.Image = ((System.Drawing.Image)(resources.GetObject("materialButton3.Image")));
            this.materialButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialButton3.Location = new System.Drawing.Point(44, 62);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialButton3.Size = new System.Drawing.Size(60, 44);
            this.materialButton3.TabIndex = 23;
            this.materialButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            // 
            // fragenDB1
            // 
            this.fragenDB1.DataSetName = "FragenDB";
            this.fragenDB1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fragenTabelleBindingSource
            // 
            this.fragenTabelleBindingSource.DataMember = "FragenTabelle";
            this.fragenTabelleBindingSource.DataSource = this.fragenDB1;
            // 
            // ListboxQuestions
            // 
            this.ListboxQuestions.FormattingEnabled = true;
            this.ListboxQuestions.ItemHeight = 16;
            this.ListboxQuestions.Location = new System.Drawing.Point(44, 125);
            this.ListboxQuestions.Name = "ListboxQuestions";
            this.ListboxQuestions.Size = new System.Drawing.Size(371, 676);
            this.ListboxQuestions.TabIndex = 24;
            this.ListboxQuestions.SelectedIndexChanged += new System.EventHandler(this.ListboxQuestions_SelectedIndexChanged);
            // 
            // QuestionManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 907);
            this.Controls.Add(this.ListboxQuestions);
            this.Controls.Add(this.materialButton3);
            this.Controls.Add(this.TextboxCategory);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.TextboxQuestion);
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
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuestionManager";
            this.Padding = new System.Windows.Forms.Padding(4, 30, 4, 4);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.QuestionManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fragenDB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fragenTabelleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 TextboxQuestion;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.TextBox TextboxCategory;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private FragenDB fragenDB1;
        private System.Windows.Forms.BindingSource fragenTabelleBindingSource;
        private System.Windows.Forms.ListBox ListboxQuestions;
    }
}