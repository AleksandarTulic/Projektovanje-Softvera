using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dentil.forms.dentist
{
    public partial class BillInput : Form
    {
        bool typeOp = true;
        int id = 0;
        public BillInput(bool typeOp, int id)
        {
            this.id = id;
            this.typeOp = typeOp;
            InitializeComponent();
            translate(Program.defaultLang, Program.lang.CurrLang);
            changeTheme();
            fill();
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (lb2.SelectedIndex < 0)
                return;

            lb1.Items.Add(lb2.SelectedItem);
            arrBill1.Add(arrBill2[lb2.SelectedIndex]);
            arrBill2.RemoveAt(lb2.SelectedIndex);
            lb2.Items.RemoveAt(lb2.SelectedIndex);
        }

        private void b4_Click(object sender, EventArgs e)
        {
            if (lb1.SelectedIndex < 0)
                return;

            lb2.Items.Add(lb1.SelectedItem);
            arrBill2.Add(arrBill1[lb1.SelectedIndex]);
            arrBill1.RemoveAt(lb1.SelectedIndex);
            lb1.Items.RemoveAt(lb1.SelectedIndex);
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (lb1.SelectedIndex < 0 && lb2.SelectedIndex < 0)
                return;

            if (lb1.SelectedIndex < 0)
            {
                IsBillMoreInfo mi = new IsBillMoreInfo(arrBill2[lb2.SelectedIndex]);
                mi.ShowDialog();
            }
            else
            {
                IsBillMoreInfo mi = new IsBillMoreInfo(arrBill1[lb1.SelectedIndex]);
                mi.ShowDialog();
            }
            
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (typeOp)
            {
                VisitInput.bill = new bill.Bill(arrBill1);
                this.Dispose();
            }
            else
            {
                bill.Bill bill = new bill.Bill(arrBill1);
                bool f = dbManagement.Insert.insertBill(id, bill);

                if (f)
                {
                    List<string> dateTime = dbManagement.Query.getDateTimeBill(id);
                    bill.setDate(new elements.helpElements.Date(dateTime[0]));
                    bill.setTime(new elements.helpElements.Time(dateTime[1]));

                    bill.writeToFile($"{id}.txt");
                    MessageBox.Show(Program.lang.translate("Operation successful", Program.defaultLang, Program.lang.CurrLang), Program.lang.translate("Add Bill", Program.defaultLang, Program.lang.CurrLang),
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show(Program.lang.translate("Operation not successful", Program.defaultLang, Program.lang.CurrLang), Program.lang.translate("Add Bill", Program.defaultLang, Program.lang.CurrLang),
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
