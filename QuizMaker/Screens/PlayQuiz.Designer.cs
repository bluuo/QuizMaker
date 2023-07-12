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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Antwort_D = new MaterialSkin.Controls.MaterialButton();
            this.Antwort_C = new MaterialSkin.Controls.MaterialButton();
            this.Antwort_B = new MaterialSkin.Controls.MaterialButton();
            this.Antwort_A = new MaterialSkin.Controls.MaterialButton();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(12, 93);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(1194, 283);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Fragetext";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.Antwort_D);
            this.groupBox1.Controls.Add(this.Antwort_C);
            this.groupBox1.Controls.Add(this.Antwort_B);
            this.groupBox1.Controls.Add(this.Antwort_A);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(42, 530);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(1137, 442);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // Antwort_D
            // 
            this.Antwort_D.AutoSize = false;
            this.Antwort_D.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Antwort_D.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Antwort_D.Depth = 0;
            this.Antwort_D.HighEmphasis = true;
            this.Antwort_D.Icon = null;
            this.Antwort_D.Location = new System.Drawing.Point(602, 250);
            this.Antwort_D.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.Antwort_D.MouseState = MaterialSkin.MouseState.HOVER;
            this.Antwort_D.Name = "Antwort_D";
            this.Antwort_D.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Antwort_D.Size = new System.Drawing.Size(509, 150);
            this.Antwort_D.TabIndex = 10;
            this.Antwort_D.Text = "Antwort_D";
            this.Antwort_D.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Antwort_D.UseAccentColor = false;
            this.Antwort_D.UseVisualStyleBackColor = true;
            // 
            // Antwort_C
            // 
            this.Antwort_C.AutoSize = false;
            this.Antwort_C.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Antwort_C.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Antwort_C.Depth = 0;
            this.Antwort_C.HighEmphasis = true;
            this.Antwort_C.Icon = null;
            this.Antwort_C.Location = new System.Drawing.Point(14, 250);
            this.Antwort_C.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.Antwort_C.MouseState = MaterialSkin.MouseState.HOVER;
            this.Antwort_C.Name = "Antwort_C";
            this.Antwort_C.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Antwort_C.Size = new System.Drawing.Size(509, 150);
            this.Antwort_C.TabIndex = 9;
            this.Antwort_C.Text = "Antwort_C";
            this.Antwort_C.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Antwort_C.UseAccentColor = false;
            this.Antwort_C.UseVisualStyleBackColor = true;
            // 
            // Antwort_B
            // 
            this.Antwort_B.AutoSize = false;
            this.Antwort_B.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Antwort_B.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Antwort_B.Depth = 0;
            this.Antwort_B.HighEmphasis = true;
            this.Antwort_B.Icon = null;
            this.Antwort_B.Location = new System.Drawing.Point(602, 42);
            this.Antwort_B.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.Antwort_B.MouseState = MaterialSkin.MouseState.HOVER;
            this.Antwort_B.Name = "Antwort_B";
            this.Antwort_B.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Antwort_B.Size = new System.Drawing.Size(509, 150);
            this.Antwort_B.TabIndex = 8;
            this.Antwort_B.Text = "Antwort_B";
            this.Antwort_B.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Antwort_B.UseAccentColor = false;
            this.Antwort_B.UseVisualStyleBackColor = true;
            // 
            // Antwort_A
            // 
            this.Antwort_A.AutoSize = false;
            this.Antwort_A.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Antwort_A.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Antwort_A.Depth = 0;
            this.Antwort_A.HighEmphasis = true;
            this.Antwort_A.Icon = null;
            this.Antwort_A.Location = new System.Drawing.Point(14, 42);
            this.Antwort_A.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.Antwort_A.MouseState = MaterialSkin.MouseState.HOVER;
            this.Antwort_A.Name = "Antwort_A";
            this.Antwort_A.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Antwort_A.Size = new System.Drawing.Size(509, 150);
            this.Antwort_A.TabIndex = 7;
            this.Antwort_A.Text = "Antwort_A";
            this.Antwort_A.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Antwort_A.UseAccentColor = false;
            this.Antwort_A.UseVisualStyleBackColor = true;
            this.Antwort_A.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSize = false;
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(42, 43);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialButton3.Size = new System.Drawing.Size(136, 63);
            this.materialButton3.TabIndex = 10;
            this.materialButton3.Text = "Zurück";
            this.materialButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            this.materialButton3.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // PlayQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1218, 985);
            this.Controls.Add(this.materialButton3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.materialLabel1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "PlayQuiz";
            this.Padding = new System.Windows.Forms.Padding(6, 46, 6, 6);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialButton Antwort_A;
        private MaterialSkin.Controls.MaterialButton Antwort_D;
        private MaterialSkin.Controls.MaterialButton Antwort_C;
        private MaterialSkin.Controls.MaterialButton Antwort_B;
        private MaterialSkin.Controls.MaterialButton materialButton3;
    }
}