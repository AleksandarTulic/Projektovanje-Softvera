using System;
using System.Collections.Generic;

namespace Dentil
{
    partial class Form1 : language.Translate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.b1 = new System.Windows.Forms.Button();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.l1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.b3 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // b1
            // 
            this.b1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b1.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(124, 301);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(150, 50);
            this.b1.TabIndex = 2;
            this.b1.Text = "Log In";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // tb1
            // 
            this.tb1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb1.Location = new System.Drawing.Point(152, 166);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(165, 20);
            this.tb1.TabIndex = 0;
            // 
            // tb2
            // 
            this.tb2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb2.Location = new System.Drawing.Point(152, 237);
            this.tb2.Name = "tb2";
            this.tb2.PasswordChar = '*';
            this.tb2.Size = new System.Drawing.Size(165, 20);
            this.tb2.TabIndex = 1;
            // 
            // l1
            // 
            this.l1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l1.AutoSize = true;
            this.l1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1.Location = new System.Drawing.Point(25, 1);
            this.l1.Name = "l1";
            this.l1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.l1.Size = new System.Drawing.Size(81, 18);
            this.l1.TabIndex = 5;
            this.l1.Text = "User name";
            this.l1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // l2
            // 
            this.l2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l2.AutoSize = true;
            this.l2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2.Location = new System.Drawing.Point(28, 1);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(75, 18);
            this.l2.TabIndex = 6;
            this.l2.Text = "Password";
            this.l2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pb1
            // 
            this.pb1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb1.Image = global::Dentil.Properties.Resources.admin;
            this.pb1.Location = new System.Drawing.Point(152, 12);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(96, 96);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1.TabIndex = 9;
            this.pb1.TabStop = false;
            this.pb1.MouseEnter += new System.EventHandler(this.pb1_MouseEnter);
            this.pb1.MouseLeave += new System.EventHandler(this.pb1_MouseLeave);
            // 
            // b3
            // 
            this.b3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b3.BackgroundImage = global::Dentil.Properties.Resources.next;
            this.b3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.Location = new System.Drawing.Point(345, 369);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(30, 30);
            this.b3.TabIndex = 4;
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b2
            // 
            this.b2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b2.BackgroundImage")));
            this.b2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.Location = new System.Drawing.Point(309, 369);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(30, 30);
            this.b2.TabIndex = 3;
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // cb1
            // 
            this.cb1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb1.FormattingEnabled = true;
            this.cb1.Location = new System.Drawing.Point(12, 378);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(49, 21);
            this.cb1.TabIndex = 10;
            this.cb1.SelectedIndexChanged += new System.EventHandler(this.cb1_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.l1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 166);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(131, 20);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.l2, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(15, 237);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(131, 20);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.b1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "Form1";
            this.Text = "Dentil";
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.PictureBox pb1;
        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

        public void translate(string curr, string want)
        {
            b1.Text = Program.lang.translate(b1.Text, curr, want);
            l1.Text = Program.lang.translate(l1.Text, curr, want);
            l2.Text = Program.lang.translate(l2.Text, curr, want);

            Program.lang.CurrLang = want;
        }
    }
}

