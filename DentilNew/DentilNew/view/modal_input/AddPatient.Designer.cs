namespace DentilNew.view.modal_input
{
    partial class AddPatient
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
            this.tb3 = new MaterialSkin.Controls.MaterialTextBox();
            this.mpb1 = new MaterialSkin.Controls.MaterialProgressBar();
            this.p1 = new System.Windows.Forms.Panel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.tb4 = new MaterialSkin.Controls.MaterialTextBox();
            this.tb5 = new MaterialSkin.Controls.MaterialTextBox();
            this.tb6 = new MaterialSkin.Controls.MaterialTextBox();
            this.p1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.b1.Location = new System.Drawing.Point(521, 362);
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
            this.tb1.AnimateReadOnly = false;
            this.tb1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb1.Depth = 0;
            this.tb1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb1.Hint = "ID";
            this.tb1.LeadingIcon = null;
            this.tb1.Location = new System.Drawing.Point(20, 64);
            this.tb1.MaxLength = 13;
            this.tb1.MouseState = MaterialSkin.MouseState.OUT;
            this.tb1.Multiline = false;
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(236, 50);
            this.tb1.TabIndex = 1;
            this.tb1.Text = "";
            this.tb1.TrailingIcon = null;
            this.tb1.TextChanged += new System.EventHandler(this.tb1_TextChanged);
            this.tb1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb1_KeyPress);
            // 
            // tb2
            // 
            this.tb2.AnimateReadOnly = false;
            this.tb2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb2.Depth = 0;
            this.tb2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb2.Hint = "Name";
            this.tb2.LeadingIcon = null;
            this.tb2.Location = new System.Drawing.Point(20, 129);
            this.tb2.MaxLength = 100;
            this.tb2.MouseState = MaterialSkin.MouseState.OUT;
            this.tb2.Multiline = false;
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(236, 50);
            this.tb2.TabIndex = 2;
            this.tb2.Text = "";
            this.tb2.TrailingIcon = null;
            this.tb2.TextChanged += new System.EventHandler(this.tb2_TextChanged);
            // 
            // tb3
            // 
            this.tb3.AnimateReadOnly = false;
            this.tb3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb3.Depth = 0;
            this.tb3.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb3.Hint = "Surname";
            this.tb3.LeadingIcon = null;
            this.tb3.Location = new System.Drawing.Point(20, 194);
            this.tb3.MaxLength = 100;
            this.tb3.MouseState = MaterialSkin.MouseState.OUT;
            this.tb3.Multiline = false;
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(236, 50);
            this.tb3.TabIndex = 3;
            this.tb3.Text = "";
            this.tb3.TrailingIcon = null;
            this.tb3.TextChanged += new System.EventHandler(this.tb3_TextChanged);
            // 
            // mpb1
            // 
            this.mpb1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mpb1.Depth = 0;
            this.mpb1.Location = new System.Drawing.Point(40, 375);
            this.mpb1.MouseState = MaterialSkin.MouseState.HOVER;
            this.mpb1.Name = "mpb1";
            this.mpb1.Size = new System.Drawing.Size(458, 5);
            this.mpb1.TabIndex = 7;
            // 
            // p1
            // 
            this.p1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p1.Controls.Add(this.materialLabel1);
            this.p1.Controls.Add(this.tb1);
            this.p1.Controls.Add(this.tb2);
            this.p1.Controls.Add(this.tb3);
            this.p1.Location = new System.Drawing.Point(20, 86);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(300, 267);
            this.p1.TabIndex = 8;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(20, 16);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(150, 19);
            this.materialLabel1.TabIndex = 9;
            this.materialLabel1.Text = "Required Information";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.tb4);
            this.panel1.Controls.Add(this.tb5);
            this.panel1.Controls.Add(this.tb6);
            this.panel1.Location = new System.Drawing.Point(329, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 267);
            this.panel1.TabIndex = 9;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(20, 16);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(179, 19);
            this.materialLabel2.TabIndex = 7;
            this.materialLabel2.Text = "Not Required Information";
            // 
            // tb4
            // 
            this.tb4.AnimateReadOnly = false;
            this.tb4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb4.Depth = 0;
            this.tb4.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb4.Hint = "Email";
            this.tb4.LeadingIcon = global::DentilNew.Properties.Resources.email;
            this.tb4.Location = new System.Drawing.Point(20, 63);
            this.tb4.MaxLength = 200;
            this.tb4.MouseState = MaterialSkin.MouseState.OUT;
            this.tb4.Multiline = false;
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(236, 50);
            this.tb4.TabIndex = 4;
            this.tb4.Text = "";
            this.tb4.TrailingIcon = null;
            // 
            // tb5
            // 
            this.tb5.AnimateReadOnly = false;
            this.tb5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb5.Depth = 0;
            this.tb5.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb5.Hint = "Phone";
            this.tb5.LeadingIcon = global::DentilNew.Properties.Resources.phone;
            this.tb5.Location = new System.Drawing.Point(20, 129);
            this.tb5.MaxLength = 30;
            this.tb5.MouseState = MaterialSkin.MouseState.OUT;
            this.tb5.Multiline = false;
            this.tb5.Name = "tb5";
            this.tb5.Size = new System.Drawing.Size(236, 50);
            this.tb5.TabIndex = 5;
            this.tb5.Text = "";
            this.tb5.TrailingIcon = null;
            this.tb5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb5_KeyPress);
            // 
            // tb6
            // 
            this.tb6.AnimateReadOnly = false;
            this.tb6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb6.Depth = 0;
            this.tb6.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb6.Hint = "Address";
            this.tb6.LeadingIcon = global::DentilNew.Properties.Resources.address;
            this.tb6.Location = new System.Drawing.Point(20, 194);
            this.tb6.MaxLength = 250;
            this.tb6.MouseState = MaterialSkin.MouseState.OUT;
            this.tb6.Multiline = false;
            this.tb6.Name = "tb6";
            this.tb6.Size = new System.Drawing.Size(236, 50);
            this.tb6.TabIndex = 6;
            this.tb6.Text = "";
            this.tb6.TrailingIcon = null;
            // 
            // AddPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 406);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.mpb1);
            this.Controls.Add(this.b1);
            this.MinimumSize = new System.Drawing.Size(621, 406);
            this.Name = "AddPatient";
            this.Text = "Add Patient";
            this.p1.ResumeLayout(false);
            this.p1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton b1;
        private MaterialSkin.Controls.MaterialTextBox tb1;
        private MaterialSkin.Controls.MaterialTextBox tb2;
        private MaterialSkin.Controls.MaterialTextBox tb3;
        private MaterialSkin.Controls.MaterialTextBox tb4;
        private MaterialSkin.Controls.MaterialTextBox tb5;
        private MaterialSkin.Controls.MaterialTextBox tb6;
        private MaterialSkin.Controls.MaterialProgressBar mpb1;
        private System.Windows.Forms.Panel p1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}