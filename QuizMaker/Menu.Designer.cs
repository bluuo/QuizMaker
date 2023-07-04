namespace QuizMaker
{
    partial class Menu
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
            this.ButtonStart = new MaterialSkin.Controls.MaterialButton();
            this.ButtonQuizManager = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel1.Location = new System.Drawing.Point(59, 108);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(194, 39);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Menü";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // ButtonStart
            // 
            this.ButtonStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ButtonStart.AutoSize = false;
            this.ButtonStart.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonStart.Depth = 0;
            this.ButtonStart.HighEmphasis = true;
            this.ButtonStart.Icon = null;
            this.ButtonStart.Location = new System.Drawing.Point(76, 170);
            this.ButtonStart.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonStart.Size = new System.Drawing.Size(161, 50);
            this.ButtonStart.TabIndex = 1;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonStart.UseAccentColor = false;
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // ButtonQuizManager
            // 
            this.ButtonQuizManager.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ButtonQuizManager.AutoSize = false;
            this.ButtonQuizManager.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonQuizManager.Depth = 0;
            this.ButtonQuizManager.HighEmphasis = true;
            this.ButtonQuizManager.Icon = null;
            this.ButtonQuizManager.Location = new System.Drawing.Point(76, 232);
            this.ButtonQuizManager.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonQuizManager.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonQuizManager.Name = "ButtonQuizManager";
            this.ButtonQuizManager.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonQuizManager.Size = new System.Drawing.Size(161, 50);
            this.ButtonQuizManager.TabIndex = 2;
            this.ButtonQuizManager.Text = "Quiz verwalten";
            this.ButtonQuizManager.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonQuizManager.UseAccentColor = false;
            this.ButtonQuizManager.UseVisualStyleBackColor = true;
            // 
            // materialButton2
            // 
            this.materialButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialButton2.AutoSize = false;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(76, 294);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(161, 50);
            this.materialButton2.TabIndex = 3;
            this.materialButton2.Text = "Fragen verwalten";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 550);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.ButtonQuizManager);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.materialLabel1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "Menu";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 0, 0);
            this.Text = "QuizMaker";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton ButtonStart;
        private MaterialSkin.Controls.MaterialButton ButtonQuizManager;
        private MaterialSkin.Controls.MaterialButton materialButton2;
    }
}

