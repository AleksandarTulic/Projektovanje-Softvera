namespace DentilNew.view
{
    partial class ViewLastSeen
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
            this.lv1 = new MaterialSkin.Controls.MaterialListView();
            this.ch1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lv1
            // 
            this.lv1.AutoSizeTable = false;
            this.lv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lv1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch1,
            this.ch2,
            this.ch3,
            this.ch4});
            this.lv1.Depth = 0;
            this.lv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv1.FullRowSelect = true;
            this.lv1.GridLines = true;
            this.lv1.HideSelection = false;
            this.lv1.Location = new System.Drawing.Point(3, 64);
            this.lv1.MinimumSize = new System.Drawing.Size(200, 100);
            this.lv1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lv1.MouseState = MaterialSkin.MouseState.OUT;
            this.lv1.Name = "lv1";
            this.lv1.OwnerDraw = true;
            this.lv1.Size = new System.Drawing.Size(600, 383);
            this.lv1.TabIndex = 0;
            this.lv1.UseCompatibleStateImageBehavior = false;
            this.lv1.View = System.Windows.Forms.View.Details;
            // 
            // ch1
            // 
            this.ch1.Text = "Name";
            this.ch1.Width = 150;
            // 
            // ch2
            // 
            this.ch2.Text = "Surname";
            this.ch2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ch2.Width = 150;
            // 
            // ch3
            // 
            this.ch3.Text = "Date";
            this.ch3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ch3.Width = 150;
            // 
            // ch4
            // 
            this.ch4.Text = "Time";
            this.ch4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ch4.Width = 150;
            // 
            // ViewLastSeen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 450);
            this.Controls.Add(this.lv1);
            this.MinimumSize = new System.Drawing.Size(606, 450);
            this.Name = "ViewLastSeen";
            this.Text = "Last Seen";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView lv1;
        private System.Windows.Forms.ColumnHeader ch1;
        private System.Windows.Forms.ColumnHeader ch2;
        private System.Windows.Forms.ColumnHeader ch3;
        private System.Windows.Forms.ColumnHeader ch4;
    }
}