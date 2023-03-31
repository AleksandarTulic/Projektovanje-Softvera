﻿namespace DentilNew
{
    partial class Treatment
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
            this.b1 = new MaterialSkin.Controls.MaterialButton();
            this.tb1 = new MaterialSkin.Controls.MaterialTextBox();
            this.tb2 = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // b1
            // 
            this.b1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.b1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.b1.Depth = 0;
            this.b1.HighEmphasis = true;
            this.b1.Icon = null;
            this.b1.Location = new System.Drawing.Point(115, 261);
            this.b1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.b1.MouseState = MaterialSkin.MouseState.HOVER;
            this.b1.Name = "b1";
            this.b1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.b1.Size = new System.Drawing.Size(64, 36);
            this.b1.TabIndex = 0;
            this.b1.Text = "Add";
            this.b1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.b1.UseAccentColor = false;
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // tb1
            // 
            this.tb1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb1.AnimateReadOnly = false;
            this.tb1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb1.Depth = 0;
            this.tb1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb1.Hint = "Service Name";
            this.tb1.LeadingIcon = null;
            this.tb1.Location = new System.Drawing.Point(26, 91);
            this.tb1.MaxLength = 200;
            this.tb1.MouseState = MaterialSkin.MouseState.OUT;
            this.tb1.Multiline = false;
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(250, 50);
            this.tb1.TabIndex = 1;
            this.tb1.Text = "";
            this.tb1.TrailingIcon = null;
            // 
            // tb2
            // 
            this.tb2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb2.AnimateReadOnly = false;
            this.tb2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb2.Depth = 0;
            this.tb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb2.Hint = "Service Cost";
            this.tb2.LeadingIcon = null;
            this.tb2.Location = new System.Drawing.Point(26, 172);
            this.tb2.MaxLength = 200;
            this.tb2.MouseState = MaterialSkin.MouseState.OUT;
            this.tb2.Multiline = false;
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(250, 50);
            this.tb2.TabIndex = 2;
            this.tb2.Text = "";
            this.tb2.TrailingIcon = null;
            this.tb2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb2_KeyPress);
            // 
            // Treatment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 324);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.b1);
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "Treatment";
            this.Text = "Service";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton b1;
        private MaterialSkin.Controls.MaterialTextBox tb1;
        private MaterialSkin.Controls.MaterialTextBox tb2;
    }
}