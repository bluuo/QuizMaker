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
            this.Antwort1 = new MaterialSkin.Controls.MaterialRadioButton();
            this.Antwort2 = new MaterialSkin.Controls.MaterialRadioButton();
            this.Antwort3 = new MaterialSkin.Controls.MaterialRadioButton();
            this.Antwort4 = new MaterialSkin.Controls.MaterialRadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonNext = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(6, 53);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(597, 147);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Fragetext";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // Antwort1
            // 
            this.Antwort1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Antwort1.AutoSize = true;
            this.Antwort1.Depth = 0;
            this.Antwort1.Location = new System.Drawing.Point(37, 20);
            this.Antwort1.Margin = new System.Windows.Forms.Padding(0);
            this.Antwort1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Antwort1.MouseState = MaterialSkin.MouseState.HOVER;
            this.Antwort1.Name = "Antwort1";
            this.Antwort1.Ripple = true;
            this.Antwort1.Size = new System.Drawing.Size(103, 37);
            this.Antwort1.TabIndex = 1;
            this.Antwort1.TabStop = true;
            this.Antwort1.Text = "Antwort 1";
            this.Antwort1.UseVisualStyleBackColor = true;
            this.Antwort1.CheckedChanged += new System.EventHandler(this.Antwort1_CheckedChanged);
            // 
            // Antwort2
            // 
            this.Antwort2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Antwort2.AutoSize = true;
            this.Antwort2.Depth = 0;
            this.Antwort2.Location = new System.Drawing.Point(37, 75);
            this.Antwort2.Margin = new System.Windows.Forms.Padding(0);
            this.Antwort2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Antwort2.MouseState = MaterialSkin.MouseState.HOVER;
            this.Antwort2.Name = "Antwort2";
            this.Antwort2.Ripple = true;
            this.Antwort2.Size = new System.Drawing.Size(103, 37);
            this.Antwort2.TabIndex = 2;
            this.Antwort2.TabStop = true;
            this.Antwort2.Text = "Antwort 2";
            this.Antwort2.UseVisualStyleBackColor = true;
            this.Antwort2.CheckedChanged += new System.EventHandler(this.Antwort2_CheckedChanged);
            // 
            // Antwort3
            // 
            this.Antwort3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Antwort3.AutoSize = true;
            this.Antwort3.Depth = 0;
            this.Antwort3.Location = new System.Drawing.Point(37, 130);
            this.Antwort3.Margin = new System.Windows.Forms.Padding(0);
            this.Antwort3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Antwort3.MouseState = MaterialSkin.MouseState.HOVER;
            this.Antwort3.Name = "Antwort3";
            this.Antwort3.Ripple = true;
            this.Antwort3.Size = new System.Drawing.Size(103, 37);
            this.Antwort3.TabIndex = 3;
            this.Antwort3.TabStop = true;
            this.Antwort3.Text = "Antwort 3";
            this.Antwort3.UseVisualStyleBackColor = true;
            this.Antwort3.CheckedChanged += new System.EventHandler(this.Antwort3_CheckedChanged);
            // 
            // Antwort4
            // 
            this.Antwort4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Antwort4.AutoSize = true;
            this.Antwort4.Depth = 0;
            this.Antwort4.Location = new System.Drawing.Point(37, 185);
            this.Antwort4.Margin = new System.Windows.Forms.Padding(0);
            this.Antwort4.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Antwort4.MouseState = MaterialSkin.MouseState.HOVER;
            this.Antwort4.Name = "Antwort4";
            this.Antwort4.Ripple = true;
            this.Antwort4.Size = new System.Drawing.Size(103, 37);
            this.Antwort4.TabIndex = 4;
            this.Antwort4.TabStop = true;
            this.Antwort4.Text = "Antwort 4";
            this.Antwort4.UseVisualStyleBackColor = true;
            this.Antwort4.CheckedChanged += new System.EventHandler(this.Antwort4_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.Antwort4);
            this.groupBox1.Controls.Add(this.Antwort1);
            this.groupBox1.Controls.Add(this.Antwort2);
            this.groupBox1.Controls.Add(this.Antwort3);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(203, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 238);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // ButtonNext
            // 
            this.ButtonNext.AutoSize = false;
            this.ButtonNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonNext.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonNext.Depth = 0;
            this.ButtonNext.HighEmphasis = true;
            this.ButtonNext.Icon = null;
            this.ButtonNext.Location = new System.Drawing.Point(227, 450);
            this.ButtonNext.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonNext.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonNext.Size = new System.Drawing.Size(143, 38);
            this.ButtonNext.TabIndex = 6;
            this.ButtonNext.Text = "Weiter";
            this.ButtonNext.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonNext.UseAccentColor = false;
            this.ButtonNext.UseVisualStyleBackColor = true;
            // 
            // PlayQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(609, 521);
            this.Controls.Add(this.ButtonNext);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.materialLabel1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "PlayQuiz";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRadioButton Antwort1;
        private MaterialSkin.Controls.MaterialRadioButton Antwort2;
        private MaterialSkin.Controls.MaterialRadioButton Antwort3;
        private MaterialSkin.Controls.MaterialRadioButton Antwort4;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialButton ButtonNext;
    }
}