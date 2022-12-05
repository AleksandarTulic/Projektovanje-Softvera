namespace DentilNew.view
{
    partial class ViewDescription
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
            this.l1 = new MaterialSkin.Controls.MaterialLabel();
            this.mltb1 = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.SuspendLayout();
            // 
            // l1
            // 
            this.l1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l1.AutoSize = true;
            this.l1.Depth = 0;
            this.l1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.l1.Location = new System.Drawing.Point(18, 85);
            this.l1.MouseState = MaterialSkin.MouseState.HOVER;
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(81, 19);
            this.l1.TabIndex = 0;
            this.l1.Text = "Description";
            // 
            // mltb1
            // 
            this.mltb1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mltb1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mltb1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mltb1.Depth = 0;
            this.mltb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mltb1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mltb1.Location = new System.Drawing.Point(18, 118);
            this.mltb1.MouseState = MaterialSkin.MouseState.HOVER;
            this.mltb1.Name = "mltb1";
            this.mltb1.ReadOnly = true;
            this.mltb1.Size = new System.Drawing.Size(397, 237);
            this.mltb1.TabIndex = 1;
            this.mltb1.Text = "";
            // 
            // ViewDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 373);
            this.Controls.Add(this.mltb1);
            this.Controls.Add(this.l1);
            this.MinimumSize = new System.Drawing.Size(436, 373);
            this.Name = "ViewDescription";
            this.Text = "Treatment Description";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel l1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox mltb1;
    }
}