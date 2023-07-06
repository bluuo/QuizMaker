namespace QuizMaker.Screens
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
            this.ButtonExit = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.Location = new System.Drawing.Point(52, 70);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(0);
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
            this.ButtonStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonStart.AutoSize = false;
            this.ButtonStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonStart.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonStart.Depth = 0;
            this.ButtonStart.HighEmphasis = true;
            this.ButtonStart.Icon = null;
            this.ButtonStart.Location = new System.Drawing.Point(70, 115);
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
            this.ButtonQuizManager.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonQuizManager.AutoSize = false;
            this.ButtonQuizManager.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonQuizManager.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonQuizManager.Depth = 0;
            this.ButtonQuizManager.HighEmphasis = true;
            this.ButtonQuizManager.Icon = null;
            this.ButtonQuizManager.Location = new System.Drawing.Point(70, 177);
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
            this.materialButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialButton2.AutoSize = false;
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(70, 239);
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
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonExit.AutoSize = false;
            this.ButtonExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonExit.CausesValidation = false;
            this.ButtonExit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonExit.Depth = 0;
            this.ButtonExit.HighEmphasis = true;
            this.ButtonExit.Icon = null;
            this.ButtonExit.Location = new System.Drawing.Point(70, 435);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonExit.Size = new System.Drawing.Size(161, 50);
            this.ButtonExit.TabIndex = 4;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonExit.UseAccentColor = false;
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel2.BackColor = System.Drawing.Color.Red;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel2.Location = new System.Drawing.Point(-4, 9);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(307, 53);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "QuizMaker";
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(300, 550);
            this.ControlBox = false;
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.ButtonQuizManager);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.materialLabel1);
            this.DrawerHighlightWithAccent = false;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 550);
            this.Name = "Menu";
            this.Opacity = 0D;
            this.Padding = new System.Windows.Forms.Padding(0);
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "QuizMaker";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton ButtonStart;
        private MaterialSkin.Controls.MaterialButton ButtonQuizManager;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton ButtonExit;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}

