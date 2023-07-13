namespace QuizMaker.Screens
{
    partial class PlayQuiz
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
            this.LabelFrage = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.ProgressBar = new MaterialSkin.Controls.MaterialProgressBar();
            this.labelCurrentQ = new MaterialSkin.Controls.MaterialLabel();
            this.labelQCount = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.Antwort_A = new System.Windows.Forms.Button();
            this.Antwort_B = new System.Windows.Forms.Button();
            this.Antwort_C = new System.Windows.Forms.Button();
            this.Antwort_D = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelFrage
            // 
            this.LabelFrage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelFrage.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LabelFrage.Depth = 0;
            this.LabelFrage.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LabelFrage.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.LabelFrage.Location = new System.Drawing.Point(6, 83);
            this.LabelFrage.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelFrage.Name = "LabelFrage";
            this.LabelFrage.Size = new System.Drawing.Size(597, 147);
            this.LabelFrage.TabIndex = 0;
            this.LabelFrage.Text = "Fragetext";
            this.LabelFrage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelFrage.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSize = false;
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(21, 22);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialButton3.Size = new System.Drawing.Size(68, 33);
            this.materialButton3.TabIndex = 10;
            this.materialButton3.Text = "Zurück";
            this.materialButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            this.materialButton3.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProgressBar.Depth = 0;
            this.ProgressBar.Location = new System.Drawing.Point(190, 57);
            this.ProgressBar.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(229, 5);
            this.ProgressBar.TabIndex = 11;
            this.ProgressBar.Click += new System.EventHandler(this.ProgressBar_Click);
            // 
            // labelCurrentQ
            // 
            this.labelCurrentQ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCurrentQ.AutoSize = true;
            this.labelCurrentQ.Depth = 0;
            this.labelCurrentQ.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelCurrentQ.Location = new System.Drawing.Point(285, 30);
            this.labelCurrentQ.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelCurrentQ.Name = "labelCurrentQ";
            this.labelCurrentQ.Size = new System.Drawing.Size(10, 19);
            this.labelCurrentQ.TabIndex = 12;
            this.labelCurrentQ.Text = "0";
            this.labelCurrentQ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelQCount
            // 
            this.labelQCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelQCount.AutoSize = true;
            this.labelQCount.Depth = 0;
            this.labelQCount.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelQCount.Location = new System.Drawing.Point(314, 30);
            this.labelQCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelQCount.Name = "labelQCount";
            this.labelQCount.Size = new System.Drawing.Size(10, 19);
            this.labelQCount.TabIndex = 13;
            this.labelQCount.Text = "0";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(301, 30);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(8, 19);
            this.materialLabel1.TabIndex = 14;
            this.materialLabel1.Text = "/";
            // 
            // Antwort_A
            // 
            this.Antwort_A.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Antwort_A.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Antwort_A.FlatAppearance.BorderSize = 0;
            this.Antwort_A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Antwort_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Antwort_A.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Antwort_A.Location = new System.Drawing.Point(21, 299);
            this.Antwort_A.Name = "Antwort_A";
            this.Antwort_A.Size = new System.Drawing.Size(254, 85);
            this.Antwort_A.TabIndex = 15;
            this.Antwort_A.Text = "button1";
            this.Antwort_A.UseVisualStyleBackColor = false;
            this.Antwort_A.Click += new System.EventHandler(this.Antwort_A_Click_1);
            // 
            // Antwort_B
            // 
            this.Antwort_B.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Antwort_B.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Antwort_B.FlatAppearance.BorderSize = 0;
            this.Antwort_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Antwort_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Antwort_B.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Antwort_B.Location = new System.Drawing.Point(333, 299);
            this.Antwort_B.Name = "Antwort_B";
            this.Antwort_B.Size = new System.Drawing.Size(254, 85);
            this.Antwort_B.TabIndex = 16;
            this.Antwort_B.Text = "button1";
            this.Antwort_B.UseVisualStyleBackColor = false;
            this.Antwort_B.Click += new System.EventHandler(this.Antwort_B_Click_1);
            // 
            // Antwort_C
            // 
            this.Antwort_C.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Antwort_C.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Antwort_C.FlatAppearance.BorderSize = 0;
            this.Antwort_C.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Antwort_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Antwort_C.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Antwort_C.Location = new System.Drawing.Point(21, 418);
            this.Antwort_C.Name = "Antwort_C";
            this.Antwort_C.Size = new System.Drawing.Size(254, 85);
            this.Antwort_C.TabIndex = 17;
            this.Antwort_C.Text = "button1";
            this.Antwort_C.UseVisualStyleBackColor = false;
            this.Antwort_C.Click += new System.EventHandler(this.Antwort_C_Click_1);
            // 
            // Antwort_D
            // 
            this.Antwort_D.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Antwort_D.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Antwort_D.FlatAppearance.BorderSize = 0;
            this.Antwort_D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Antwort_D.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Antwort_D.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Antwort_D.Location = new System.Drawing.Point(333, 418);
            this.Antwort_D.Name = "Antwort_D";
            this.Antwort_D.Size = new System.Drawing.Size(254, 85);
            this.Antwort_D.TabIndex = 18;
            this.Antwort_D.Text = "button1";
            this.Antwort_D.UseVisualStyleBackColor = false;
            this.Antwort_D.Click += new System.EventHandler(this.Antwort_D_Click_1);
            // 
            // PlayQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(609, 520);
            this.Controls.Add(this.Antwort_D);
            this.Controls.Add(this.Antwort_C);
            this.Controls.Add(this.Antwort_B);
            this.Controls.Add(this.Antwort_A);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.labelQCount);
            this.Controls.Add(this.labelCurrentQ);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.materialButton3);
            this.Controls.Add(this.LabelFrage);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "PlayQuiz";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel LabelFrage;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        public MaterialSkin.Controls.MaterialProgressBar ProgressBar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        public MaterialSkin.Controls.MaterialLabel labelCurrentQ;
        public MaterialSkin.Controls.MaterialLabel labelQCount;
        private System.Windows.Forms.Button Antwort_A;
        private System.Windows.Forms.Button Antwort_B;
        private System.Windows.Forms.Button Antwort_C;
        private System.Windows.Forms.Button Antwort_D;
    }
}