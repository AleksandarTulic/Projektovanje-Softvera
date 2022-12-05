namespace DentilNew
{
    partial class Login
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
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            this.tb1 = new MaterialSkin.Controls.MaterialTextBox();
            this.tb2 = new MaterialSkin.Controls.MaterialTextBox();
            this.mb1 = new MaterialSkin.Controls.MaterialButton();
            this.pb1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb1
            // 
            this.tb1.AccessibleDescription = "";
            this.tb1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb1.AnimateReadOnly = false;
            this.tb1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb1.Depth = 0;
            this.tb1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb1.Hint = "Username";
            this.tb1.LeadingIcon = null;
            this.tb1.Location = new System.Drawing.Point(48, 247);
            this.tb1.MaxLength = 50;
            this.tb1.MouseState = MaterialSkin.MouseState.OUT;
            this.tb1.Multiline = false;
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(304, 50);
            this.tb1.TabIndex = 13;
            this.tb1.Text = "";
            this.tb1.TrailingIcon = null;
            // 
            // tb2
            // 
            this.tb2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb2.AnimateReadOnly = false;
            this.tb2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb2.Depth = 0;
            this.tb2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb2.Hint = "Password";
            this.tb2.LeadingIcon = null;
            this.tb2.Location = new System.Drawing.Point(48, 319);
            this.tb2.MaxLength = 50;
            this.tb2.MouseState = MaterialSkin.MouseState.OUT;
            this.tb2.Multiline = false;
            this.tb2.Name = "tb2";
            this.tb2.Password = true;
            this.tb2.Size = new System.Drawing.Size(304, 50);
            this.tb2.TabIndex = 14;
            this.tb2.Text = "";
            this.tb2.TrailingIcon = null;
            // 
            // mb1
            // 
            this.mb1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mb1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mb1.BackColor = System.Drawing.Color.White;
            this.mb1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mb1.Depth = 0;
            this.mb1.HighEmphasis = true;
            this.mb1.Icon = null;
            this.mb1.Location = new System.Drawing.Point(166, 424);
            this.mb1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mb1.MouseState = MaterialSkin.MouseState.HOVER;
            this.mb1.Name = "mb1";
            this.mb1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mb1.Size = new System.Drawing.Size(68, 36);
            this.mb1.TabIndex = 15;
            this.mb1.Text = "Log In";
            this.mb1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mb1.UseAccentColor = false;
            this.mb1.UseVisualStyleBackColor = false;
            this.mb1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // pb1
            // 
            this.pb1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb1.Image = global::DentilNew.Properties.Resources.dentist;
            this.pb1.InitialImage = global::DentilNew.Properties.Resources.dentist;
            this.pb1.Location = new System.Drawing.Point(152, 108);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(96, 96);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1.TabIndex = 9;
            this.pb1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 535);
            this.Controls.Add(this.mb1);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.pb1);
            this.MinimumSize = new System.Drawing.Size(400, 535);
            this.Name = "Login";
            this.Text = "Dentil";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
        private MaterialSkin.Controls.MaterialTextBox tb1;
        private MaterialSkin.Controls.MaterialTextBox tb2;
        private MaterialSkin.Controls.MaterialButton mb1;
        private System.Windows.Forms.PictureBox pb1;
    }
}

