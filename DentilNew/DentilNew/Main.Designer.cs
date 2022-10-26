namespace DentilNew
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.b2 = new MaterialSkin.Controls.MaterialButton();
            this.b1 = new MaterialSkin.Controls.MaterialButton();
            this.b3 = new MaterialSkin.Controls.MaterialButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.il1 = new System.Windows.Forms.ImageList(this.components);
            this.ni1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Controls.Add(this.tabPage5);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.il1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(794, 383);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPage1.Controls.Add(this.b2);
            this.tabPage1.Controls.Add(this.b1);
            this.tabPage1.Controls.Add(this.b3);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.ImageKey = "menu_1.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 42);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(786, 337);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // b2
            // 
            this.b2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.b2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.b2.Depth = 0;
            this.b2.HighEmphasis = true;
            this.b2.Icon = null;
            this.b2.Location = new System.Drawing.Point(91, 91);
            this.b2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.b2.MouseState = MaterialSkin.MouseState.HOVER;
            this.b2.Name = "b2";
            this.b2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.b2.Size = new System.Drawing.Size(73, 36);
            this.b2.TabIndex = 2;
            this.b2.Text = "Delete";
            this.b2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.b2.UseAccentColor = false;
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b1
            // 
            this.b1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.b1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.b1.Depth = 0;
            this.b1.HighEmphasis = true;
            this.b1.Icon = null;
            this.b1.Location = new System.Drawing.Point(91, 43);
            this.b1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.b1.MouseState = MaterialSkin.MouseState.HOVER;
            this.b1.Name = "b1";
            this.b1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.b1.Size = new System.Drawing.Size(114, 36);
            this.b1.TabIndex = 1;
            this.b1.Text = "Add Patient";
            this.b1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.b1.UseAccentColor = false;
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // b3
            // 
            this.b3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.b3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.b3.Depth = 0;
            this.b3.HighEmphasis = true;
            this.b3.Icon = null;
            this.b3.Location = new System.Drawing.Point(91, 139);
            this.b3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.b3.MouseState = MaterialSkin.MouseState.HOVER;
            this.b3.Name = "b3";
            this.b3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.b3.Size = new System.Drawing.Size(90, 36);
            this.b3.TabIndex = 0;
            this.b3.Text = "Update";
            this.b3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.b3.UseAccentColor = false;
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage2.ImageKey = "menu_8.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 42);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(786, 337);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage3.ImageKey = "menu_6.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 42);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(786, 337);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage4.ImageKey = "menu_10.png";
            this.tabPage4.Location = new System.Drawing.Point(4, 42);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(786, 337);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage5.ImageKey = "menu_11.png";
            this.tabPage5.Location = new System.Drawing.Point(4, 42);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(786, 337);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // il1
            // 
            this.il1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("il1.ImageStream")));
            this.il1.TransparentColor = System.Drawing.Color.Transparent;
            this.il1.Images.SetKeyName(0, "menu_1.png");
            this.il1.Images.SetKeyName(1, "menu_2.png");
            this.il1.Images.SetKeyName(2, "menu_3.png");
            this.il1.Images.SetKeyName(3, "menu_4.png");
            this.il1.Images.SetKeyName(4, "menu_5.png");
            this.il1.Images.SetKeyName(5, "menu_6.png");
            this.il1.Images.SetKeyName(6, "menu_7.png");
            this.il1.Images.SetKeyName(7, "menu_8.png");
            this.il1.Images.SetKeyName(8, "menu_9.png");
            this.il1.Images.SetKeyName(9, "menu_10.png");
            this.il1.Images.SetKeyName(10, "menu_11.png");
            // 
            // ni1
            // 
            this.ni1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ni1.BalloonTipText = "Open Dentil";
            this.ni1.BalloonTipTitle = "Dentil";
            this.ni1.Icon = ((System.Drawing.Icon)(resources.GetObject("ni1.Icon")));
            this.ni1.Text = "Dentil";
            this.ni1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ni1_MouseDoubleClick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dentil";
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList il1;
        private System.Windows.Forms.NotifyIcon ni1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private MaterialSkin.Controls.MaterialButton b2;
        private MaterialSkin.Controls.MaterialButton b1;
        private MaterialSkin.Controls.MaterialButton b3;
    }
}