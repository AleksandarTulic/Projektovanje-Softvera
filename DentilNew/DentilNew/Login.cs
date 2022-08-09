using DentilNew.model.logger;
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

namespace DentilNew
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label1.Text = Directory.GetCurrentDirectory();
            MyLogger.Logger.log("Sta ima");
            MyLogger.Logger.log("Sta ima");
            MyLogger.Logger.log("Sta ima");
            MyLogger.Logger.log("Sta ima");
        }
    }
}
