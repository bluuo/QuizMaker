namespace QuizMaker.Screens
{
    partial class GeneratorPopup
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
            this.ButtonGenerate = new MaterialSkin.Controls.MaterialButton();
            this.ButtonCancel = new MaterialSkin.Controls.MaterialButton();
            this.NumberSlider = new MaterialSkin.Controls.MaterialSlider();
            this.TextboxCategory = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.LevelSlider = new MaterialSkin.Controls.MaterialSlider();
            this.SuspendLayout();
            // 
            // ButtonGenerate
            // 
            this.ButtonGenerate.AutoSize = false;
            this.ButtonGenerate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonGenerate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonGenerate.Depth = 0;
            this.ButtonGenerate.HighEmphasis = true;
            this.ButtonGenerate.Icon = null;
            this.ButtonGenerate.Location = new System.Drawing.Point(194, 268);
            this.ButtonGenerate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonGenerate.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonGenerate.Name = "ButtonGenerate";
            this.ButtonGenerate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonGenerate.Size = new System.Drawing.Size(158, 36);
            this.ButtonGenerate.TabIndex = 0;
            this.ButtonGenerate.Text = "Übernehmen";
            this.ButtonGenerate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonGenerate.UseAccentColor = false;
            this.ButtonGenerate.UseVisualStyleBackColor = true;
            this.ButtonGenerate.Click += new System.EventHandler(this.ButtonGenerate_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.AutoSize = false;
            this.ButtonCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonCancel.Depth = 0;
            this.ButtonCancel.HighEmphasis = true;
            this.ButtonCancel.Icon = null;
            this.ButtonCancel.Location = new System.Drawing.Point(27, 268);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonCancel.Size = new System.Drawing.Size(159, 36);
            this.ButtonCancel.TabIndex = 1;
            this.ButtonCancel.Text = "Abbrechen";
            this.ButtonCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonCancel.UseAccentColor = false;
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // NumberSlider
            // 
            this.NumberSlider.Depth = 0;
            this.NumberSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NumberSlider.Location = new System.Drawing.Point(27, 82);
            this.NumberSlider.MouseState = MaterialSkin.MouseState.HOVER;
            this.NumberSlider.Name = "NumberSlider";
            this.NumberSlider.RangeMax = 25;
            this.NumberSlider.RangeMin = 1;
            this.NumberSlider.Size = new System.Drawing.Size(325, 40);
            this.NumberSlider.TabIndex = 2;
            this.NumberSlider.Text = "Anzahl der Fragen";
            this.NumberSlider.Value = 1;
            this.NumberSlider.ValueMax = 25;
            // 
            // TextboxCategory
            // 
            this.TextboxCategory.AnimateReadOnly = false;
            this.TextboxCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextboxCategory.Depth = 0;
            this.TextboxCategory.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextboxCategory.LeadingIcon = null;
            this.TextboxCategory.Location = new System.Drawing.Point(154, 139);
            this.TextboxCategory.MaxLength = 50;
            this.TextboxCategory.MouseState = MaterialSkin.MouseState.OUT;
            this.TextboxCategory.Multiline = false;
            this.TextboxCategory.Name = "TextboxCategory";
            this.TextboxCategory.Size = new System.Drawing.Size(198, 50);
            this.TextboxCategory.TabIndex = 3;
            this.TextboxCategory.Text = "";
            this.TextboxCategory.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(24, 152);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(68, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Kategorie";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // LevelSlider
            // 
            this.LevelSlider.Depth = 0;
            this.LevelSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LevelSlider.Location = new System.Drawing.Point(27, 208);
            this.LevelSlider.MouseState = MaterialSkin.MouseState.HOVER;
            this.LevelSlider.Name = "LevelSlider";
            this.LevelSlider.RangeMax = 5;
            this.LevelSlider.RangeMin = 1;
            this.LevelSlider.ShowValue = false;
            this.LevelSlider.Size = new System.Drawing.Size(325, 40);
            this.LevelSlider.TabIndex = 5;
            this.LevelSlider.Text = "Schwierigkeitsgrad";
            this.LevelSlider.Value = 1;
            this.LevelSlider.ValueMax = 5;
            // 
            // GeneratorPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 324);
            this.Controls.Add(this.LevelSlider);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.TextboxCategory);
            this.Controls.Add(this.NumberSlider);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonGenerate);
            this.Name = "GeneratorPopup";
            this.Text = "Fragen Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton ButtonGenerate;
        private MaterialSkin.Controls.MaterialButton ButtonCancel;
        private MaterialSkin.Controls.MaterialSlider NumberSlider;
        private MaterialSkin.Controls.MaterialTextBox TextboxCategory;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSlider LevelSlider;
    }
}