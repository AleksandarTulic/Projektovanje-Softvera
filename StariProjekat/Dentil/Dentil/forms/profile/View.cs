using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dentil.forms.profile
{
    public class View : common.Common
    {
        TableLayoutPanel tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        Label mainInfo = new System.Windows.Forms.Label();
        Label label2 = new System.Windows.Forms.Label();
        Label label3 = new System.Windows.Forms.Label();
        Label label4 = new System.Windows.Forms.Label();
        Label label5 = new System.Windows.Forms.Label();
        Label label6 = new System.Windows.Forms.Label();
        Label label7 = new System.Windows.Forms.Label();
        Label label8 = new System.Windows.Forms.Label();
        Label label9 = new System.Windows.Forms.Label();
        TableLayoutPanel tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
        Label label10 = new System.Windows.Forms.Label();
        Label label11 = new System.Windows.Forms.Label();
        Label label12 = new System.Windows.Forms.Label();
        Label label13 = new System.Windows.Forms.Label();
        Label label14 = new System.Windows.Forms.Label();
        Label label15 = new System.Windows.Forms.Label();
        Label label16 = new System.Windows.Forms.Label();
        Label label17 = new System.Windows.Forms.Label();
        Label label18 = new System.Windows.Forms.Label();
        Label label19 = new System.Windows.Forms.Label();
        TableLayoutPanel tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
        TableLayoutPanel tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
        Label label20 = new System.Windows.Forms.Label();
        Label label21 = new System.Windows.Forms.Label();
        Label label22 = new System.Windows.Forms.Label();
        Label label23 = new System.Windows.Forms.Label();
        Label residency = new System.Windows.Forms.Label();
        Label contInfo = new System.Windows.Forms.Label();
        Label bankInfo = new System.Windows.Forms.Label();
        Label label27 = new System.Windows.Forms.Label();
        List <Panel> colorArr = new List<Panel> ();

        public View(Form a)
        {
            this.p.SuspendLayout();
            this.p.BackColor = System.Drawing.Color.White;
            this.p.Controls.Add(this.label27);
            this.p.Controls.Add(this.bankInfo);
            this.p.Controls.Add(this.contInfo);
            this.p.Controls.Add(this.residency);
            this.p.Controls.Add(this.tableLayoutPanel4);
            this.p.Controls.Add(this.tableLayoutPanel3);
            this.p.Controls.Add(this.tableLayoutPanel2);
            this.p.Controls.Add(this.mainInfo);
            this.p.Controls.Add(this.tableLayoutPanel1);
            this.p.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p.Location = new System.Drawing.Point(20, 54);
            this.p.Name = "p5";
            this.p.Size = new System.Drawing.Size(1017, 433);
            this.p.TabIndex = 6;

            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(22, 128);
            this.tableLayoutPanel1.Name = "typ";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 120);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.mainInfo.AutoSize = true;
            this.mainInfo.Name = "mainInfo";
            this.mainInfo.Size = new System.Drawing.Size(180, 20);
            this.mainInfo.TabIndex = 1;
            this.mainInfo.Text = "Main Information";
            mainInfo.AutoSize = true;

            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 68);
            this.label4.Name = "Surname";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Gender";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = Program.user.Id;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(132, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = Program.user.Name;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(132, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = Program.user.Surname;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(132, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = Program.user.Gender;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label15, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label14, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label13, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 90);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "City";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Street";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Street Number";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(129, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = Program.user.City;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(129, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = Program.user.Street;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(129, 68);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = Program.user.StreetNum.ToString();
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(129, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = Program.user.Bank;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(29, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "Bank";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(29, 40);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 13);
            this.label18.TabIndex = 5;
            this.label18.Text = "Bank Account";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(129, 40);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 13);
            this.label19.TabIndex = 6;
            this.label19.Text = Program.user.NumAccount;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel2.AutoSize = false;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label17, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label19, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label18, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label16, 1, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(200, 62);
            this.tableLayoutPanel3.TabIndex = 7;
            tableLayoutPanel3.Font = new System.Drawing.Font("Microsoft sans serif", 12);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label23, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label20, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label21, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label22, 0, 1);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(200, 62);
            this.tableLayoutPanel4.TabIndex = 8;
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(29, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 13);
            this.label20.TabIndex = 9;
            this.label20.Text = "Email";
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(129, 9);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 13);
            this.label21.TabIndex = 10;
            this.label21.Text = Program.user.Email;
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(29, 40);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(41, 13);
            this.label22.TabIndex = 11;
            this.label22.Text = "Phone";
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(129, 40);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(41, 13);
            this.label23.TabIndex = 12;
            this.label23.Text = Program.user.Phone;
            // 
            // label24
            // 
            this.residency.AutoSize = true;
            this.residency.Name = "residency";
            this.residency.Size = new System.Drawing.Size(41, 13);
            this.residency.TabIndex = 9;
            this.residency.Text = "Residency";
            // 
            // label25
            // 
            this.contInfo.AutoSize = true;
            this.contInfo.Name = "contInfo";
            this.contInfo.Size = new System.Drawing.Size(41, 13);
            this.contInfo.TabIndex = 10;
            this.contInfo.Text = "Contact Information";
            // 
            // label26
            // 
            this.bankInfo.AutoSize = true;
            this.bankInfo.Name = "bankInfo";
            this.bankInfo.Size = new System.Drawing.Size(41, 13);
            this.bankInfo.TabIndex = 11;
            this.bankInfo.Text = "Bank Information";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(19, 22);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(41, 13);
            this.label27.TabIndex = 12;
            this.label27.Text = "label27";
            a.Controls.Add(p);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            a.ResumeLayout(false);
            a.PerformLayout();

            this.p.ResumeLayout(false);
            this.p.PerformLayout();

            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel4.AutoSize = true;
            tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft sans serif", 12);
            tableLayoutPanel2.Font = new System.Drawing.Font("Microsoft sans serif", 12);
            tableLayoutPanel3.Font = new System.Drawing.Font("Microsoft sans serif", 12);
            tableLayoutPanel4.Font = new System.Drawing.Font("Microsoft sans serif", 12);

            bankInfo.Font = new System.Drawing.Font("Microsoft sans serif", 12);
            residency.Font = new System.Drawing.Font("Microsoft sans serif", 12);
            mainInfo.Font = new System.Drawing.Font("Microsoft sans serif", 12);
            contInfo.Font = new System.Drawing.Font("Microsoft sans serif", 12);

            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableLayoutPanel3.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableLayoutPanel4.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;

            tableLayoutPanel2.Location = new System.Drawing.Point(tableLayoutPanel1.Location.X + 40 + tableLayoutPanel1.Width, tableLayoutPanel1.Location.Y);
            tableLayoutPanel3.Location = new System.Drawing.Point(tableLayoutPanel2.Location.X + 40 + tableLayoutPanel2.Width, tableLayoutPanel2.Location.Y);
            tableLayoutPanel4.Location = new System.Drawing.Point(tableLayoutPanel3.Location.X + 40 + tableLayoutPanel3.Width, tableLayoutPanel3.Location.Y);

            mainInfo.Location = new System.Drawing.Point(tableLayoutPanel1.Location.X, tableLayoutPanel1.Location.Y - 50);
            residency.Location = new System.Drawing.Point(tableLayoutPanel2.Location.X, tableLayoutPanel2.Location.Y - 50);
            bankInfo.Location = new System.Drawing.Point(tableLayoutPanel3.Location.X, tableLayoutPanel3.Location.Y - 50);
            contInfo.Location = new System.Drawing.Point(tableLayoutPanel4.Location.X, tableLayoutPanel4.Location.Y - 50);

            for (int i = 0; i < 4; i++)
                colorArr.Add(new Panel());

            colorArr[0].Location = new System.Drawing.Point(mainInfo.Location.X, mainInfo.Location.Y + mainInfo.Height + 1);
            colorArr[0].Width = mainInfo.Width + 20;
            colorArr[0].Height = 3;
            colorArr[0].Name = "mainInfo";
            colorArr[0].BackColor = System.Drawing.Color.DeepSkyBlue;
            colorArr[0].TabIndex = 1;
            p.Controls.Add(colorArr[0]);

            colorArr[1].Location = new System.Drawing.Point(residency.Location.X, residency.Location.Y + residency.Height + 1);
            colorArr[1].Size = new System.Drawing.Size(residency.Width + 20, 3);
            colorArr[1].Name = "residency";
            colorArr[1].BackColor = System.Drawing.Color.DeepSkyBlue;
            colorArr[1].TabIndex = 1;
            p.Controls.Add(colorArr[1]);

            colorArr[2].Location = new System.Drawing.Point(bankInfo.Location.X, bankInfo.Location.Y + bankInfo.Height + 1);
            colorArr[2].Size = new System.Drawing.Size(bankInfo.Width + 20, 3);
            colorArr[2].Name = "residency";
            colorArr[2].BackColor = System.Drawing.Color.DeepSkyBlue;
            colorArr[2].TabIndex = 1;
            p.Controls.Add(colorArr[2]);

            colorArr[3].Location = new System.Drawing.Point(contInfo.Location.X, contInfo.Location.Y + contInfo.Height + 1);
            colorArr[3].Size = new System.Drawing.Size(contInfo.Width + 20, 3);
            colorArr[3].Name = "residency";
            colorArr[3].BackColor = System.Drawing.Color.DeepSkyBlue;
            colorArr[3].TabIndex = 1;
            p.Controls.Add(colorArr[3]);

            p.AutoScroll = true;
            p.AutoScrollMinSize = new System.Drawing.Size(200, 200);

            p.BringToFront();
        }
    }
}
