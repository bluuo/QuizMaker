using System;
using System.Text.RegularExpressions;

namespace QuizMaker.Screens
{
    partial class PrePlayQuiz
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
            this.QuizBox = new MaterialSkin.Controls.MaterialListBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.TextboxName = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.TextboxAnzahl = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.TextboxKategorie = new MaterialSkin.Controls.MaterialTextBox();
            this.ButtonAdd = new MaterialSkin.Controls.MaterialButton();
            this.ButtonDelete = new MaterialSkin.Controls.MaterialButton();
            this.ButtonBack = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // QuizBox
            // 
            this.QuizBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.QuizBox.BackColor = System.Drawing.Color.White;
            this.QuizBox.BorderColor = System.Drawing.Color.LightGray;
            this.QuizBox.Depth = 0;
            this.QuizBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.QuizBox.Location = new System.Drawing.Point(23, 88);
            this.QuizBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.QuizBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.QuizBox.Name = "QuizBox";
            this.QuizBox.SelectedIndex = -1;
            this.QuizBox.SelectedItem = null;
            this.QuizBox.Size = new System.Drawing.Size(367, 450);
            this.QuizBox.TabIndex = 0;
            this.QuizBox.SelectedIndexChanged += new MaterialSkin.Controls.MaterialListBox.SelectedIndexChangedEventHandler(this.materialListBox1_SelectedIndexChanged);
            this.QuizBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.QuizBox_MouseDoubleClick_1);
            // 
            // materialButton1
            // 
            this.materialButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(685, 545);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(106, 36);
            this.materialButton1.TabIndex = 1;
            this.materialButton1.Text = "Spielstart";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = true;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // TextboxName
            // 
            this.TextboxName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextboxName.AnimateReadOnly = false;
            this.TextboxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextboxName.Depth = 0;
            this.TextboxName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextboxName.LeadingIcon = null;
            this.TextboxName.Location = new System.Drawing.Point(562, 93);
            this.TextboxName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextboxName.MaxLength = 50;
            this.TextboxName.MouseState = MaterialSkin.MouseState.OUT;
            this.TextboxName.Multiline = false;
            this.TextboxName.Name = "TextboxName";
            this.TextboxName.Size = new System.Drawing.Size(229, 50);
            this.TextboxName.TabIndex = 3;
            this.TextboxName.Text = "";
            this.TextboxName.TrailingIcon = null;
            this.TextboxName.TextChanged += new System.EventHandler(this.materialTextBox1_TextChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(411, 108);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(43, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Name";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(411, 188);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(129, 19);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "Anzahl der Fragen";
            // 
            // TextboxAnzahl
            // 
            this.TextboxAnzahl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextboxAnzahl.AnimateReadOnly = false;
            this.TextboxAnzahl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextboxAnzahl.Depth = 0;
            this.TextboxAnzahl.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextboxAnzahl.LeadingIcon = null;
            this.TextboxAnzahl.Location = new System.Drawing.Point(562, 173);
            this.TextboxAnzahl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextboxAnzahl.MaxLength = 50;
            this.TextboxAnzahl.MouseState = MaterialSkin.MouseState.OUT;
            this.TextboxAnzahl.Multiline = false;
            this.TextboxAnzahl.Name = "TextboxAnzahl";
            this.TextboxAnzahl.Size = new System.Drawing.Size(229, 50);
            this.TextboxAnzahl.TabIndex = 5;
            this.TextboxAnzahl.Text = "";
            this.TextboxAnzahl.TrailingIcon = null;
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(411, 266);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(68, 19);
            this.materialLabel3.TabIndex = 8;
            this.materialLabel3.Text = "Kategorie";
            // 
            // TextboxKategorie
            // 
            this.TextboxKategorie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextboxKategorie.AnimateReadOnly = false;
            this.TextboxKategorie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextboxKategorie.Depth = 0;
            this.TextboxKategorie.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextboxKategorie.LeadingIcon = null;
            this.TextboxKategorie.Location = new System.Drawing.Point(562, 251);
            this.TextboxKategorie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextboxKategorie.MaxLength = 50;
            this.TextboxKategorie.MouseState = MaterialSkin.MouseState.OUT;
            this.TextboxKategorie.Multiline = false;
            this.TextboxKategorie.Name = "TextboxKategorie";
            this.TextboxKategorie.Size = new System.Drawing.Size(229, 50);
            this.TextboxKategorie.TabIndex = 7;
            this.TextboxKategorie.Text = "";
            this.TextboxKategorie.TrailingIcon = null;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonAdd.Depth = 0;
            this.ButtonAdd.HighEmphasis = true;
            this.ButtonAdd.Icon = null;
            this.ButtonAdd.Location = new System.Drawing.Point(552, 325);
            this.ButtonAdd.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ButtonAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonAdd.Size = new System.Drawing.Size(112, 36);
            this.ButtonAdd.TabIndex = 9;
            this.ButtonAdd.Text = "Hinzufügen";
            this.ButtonAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonAdd.UseAccentColor = false;
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonDelete.Depth = 0;
            this.ButtonDelete.HighEmphasis = true;
            this.ButtonDelete.Icon = null;
            this.ButtonDelete.Location = new System.Drawing.Point(142, 545);
            this.ButtonDelete.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ButtonDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonDelete.Size = new System.Drawing.Size(124, 36);
            this.ButtonDelete.TabIndex = 10;
            this.ButtonDelete.Text = "Quiz Löschen";
            this.ButtonDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonDelete.UseAccentColor = false;
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonBack
            // 
            this.ButtonBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonBack.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonBack.Depth = 0;
            this.ButtonBack.HighEmphasis = true;
            this.ButtonBack.Icon = null;
            this.ButtonBack.Location = new System.Drawing.Point(23, 22);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ButtonBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonBack.Size = new System.Drawing.Size(78, 36);
            this.ButtonBack.TabIndex = 11;
            this.ButtonBack.Text = "Zurück";
            this.ButtonBack.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonBack.UseAccentColor = false;
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // PrePlayQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 600);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.TextboxKategorie);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.TextboxAnzahl);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.TextboxName);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.QuizBox);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PrePlayQuiz";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 2, 2);
            this.Sizable = false;
            this.Text = "PrePlayQuiz";
            this.Load += new System.EventHandler(this.PrePlayQuiz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }


        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion

        private MaterialSkin.Controls.MaterialListBox QuizBox;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialTextBox TextboxName;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox TextboxAnzahl;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox TextboxKategorie;
        private MaterialSkin.Controls.MaterialButton ButtonAdd;
        private MaterialSkin.Controls.MaterialButton ButtonDelete;
        private MaterialSkin.Controls.MaterialButton ButtonBack;
    }
}