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
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(6, 38);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(609, 147);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Fragetext";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Antwort1
            // 
            this.Antwort1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Antwort1.Depth = 0;
            this.Antwort1.Location = new System.Drawing.Point(47, 200);
            this.Antwort1.Margin = new System.Windows.Forms.Padding(0);
            this.Antwort1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Antwort1.MouseState = MaterialSkin.MouseState.HOVER;
            this.Antwort1.Name = "Antwort1";
            this.Antwort1.Ripple = true;
            this.Antwort1.Size = new System.Drawing.Size(524, 37);
            this.Antwort1.TabIndex = 1;
            this.Antwort1.TabStop = true;
            this.Antwort1.Text = "Antwort 1";
            this.Antwort1.UseVisualStyleBackColor = true;
            // 
            // Antwort2
            // 
            this.Antwort2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Antwort2.Depth = 0;
            this.Antwort2.Location = new System.Drawing.Point(47, 256);
            this.Antwort2.Margin = new System.Windows.Forms.Padding(0);
            this.Antwort2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Antwort2.MouseState = MaterialSkin.MouseState.HOVER;
            this.Antwort2.Name = "Antwort2";
            this.Antwort2.Ripple = true;
            this.Antwort2.Size = new System.Drawing.Size(524, 37);
            this.Antwort2.TabIndex = 2;
            this.Antwort2.TabStop = true;
            this.Antwort2.Text = "Antwort 2";
            this.Antwort2.UseVisualStyleBackColor = true;
            // 
            // Antwort3
            // 
            this.Antwort3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Antwort3.Depth = 0;
            this.Antwort3.Location = new System.Drawing.Point(47, 312);
            this.Antwort3.Margin = new System.Windows.Forms.Padding(0);
            this.Antwort3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Antwort3.MouseState = MaterialSkin.MouseState.HOVER;
            this.Antwort3.Name = "Antwort3";
            this.Antwort3.Ripple = true;
            this.Antwort3.Size = new System.Drawing.Size(524, 37);
            this.Antwort3.TabIndex = 3;
            this.Antwort3.TabStop = true;
            this.Antwort3.Text = "Antwort 3";
            this.Antwort3.UseVisualStyleBackColor = true;
            // 
            // Antwort4
            // 
            this.Antwort4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Antwort4.Depth = 0;
            this.Antwort4.Location = new System.Drawing.Point(47, 368);
            this.Antwort4.Margin = new System.Windows.Forms.Padding(0);
            this.Antwort4.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Antwort4.MouseState = MaterialSkin.MouseState.HOVER;
            this.Antwort4.Name = "Antwort4";
            this.Antwort4.Ripple = true;
            this.Antwort4.Size = new System.Drawing.Size(524, 37);
            this.Antwort4.TabIndex = 4;
            this.Antwort4.TabStop = true;
            this.Antwort4.Text = "Antwort 4";
            this.Antwort4.UseVisualStyleBackColor = true;
            // 
            // PlayQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(621, 647);
            this.Controls.Add(this.Antwort4);
            this.Controls.Add(this.Antwort3);
            this.Controls.Add(this.Antwort2);
            this.Controls.Add(this.Antwort1);
            this.Controls.Add(this.materialLabel1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "PlayQuiz";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRadioButton Antwort1;
        private MaterialSkin.Controls.MaterialRadioButton Antwort2;
        private MaterialSkin.Controls.MaterialRadioButton Antwort3;
        private MaterialSkin.Controls.MaterialRadioButton Antwort4;
    }
}