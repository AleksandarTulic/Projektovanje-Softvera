using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dentil
{
    public partial class Admin : Form
    {
        Form logIn;
        public static forms.profile.ViewProfile viewProfile = null;
        public static forms.profile.Settings settings = null;
        public static forms.admin.Elements viewElements = null;
        public static forms.admin.ViewSchedul viewSchedule = null;
        public static forms.admin.viewPersona viewPersonal = null;
        public Admin(Form logIn)
        {
            this.logIn = logIn;
            InitializeComponent();
            viewProfile = new forms.profile.ViewProfile(this);
            viewProfile.setVisibility(false);
            viewElements = new forms.admin.Elements(this);
            viewElements.setVisibility(false);
            viewSchedule = new forms.admin.ViewSchedul(this);
            viewSchedule.setVisibility(false);
            viewPersonal = new forms.admin.viewPersona(this);
            viewPersonal.setVisibility(false);
            settings = new forms.profile.Settings(this, "admin");
            settings.setVisibility(false);

            this.translate(Program.defaultLang, Program.lang.CurrLang);

            tssl1.Text = $"{this.Width.ToString()} x {this.Height.ToString()}px";

            this.changeTheme();
        }

        private void Admin_Resize(object sender, EventArgs e)
        {
            tssl1.Text = $"{this.Width.ToString()} x {this.Height.ToString()}px";
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            logIn.Dispose();
        }

        private void allFalse()
        {
            viewProfile.setVisibility(false);
            viewSchedule.setVisibility(false);
            viewElements.setVisibility(false);
            viewPersonal.setVisibility(false);
            settings.setVisibility(false);
        }

        private void v21_Click(object sender, EventArgs e)
        {
            //allFalse();
            forms.admin.PersonalInput pi = new forms.admin.PersonalInput();
            pi.ShowDialog();
        }

        private void v31_Click(object sender, EventArgs e)
        {
            //allFalse();
            Dentil.forms.admin.ScheduleInput si = new forms.admin.ScheduleInput();
            si.ShowDialog();
        }

        private void v32_Click(object sender, EventArgs e)
        {
            allFalse();
            viewSchedule.setVisibility(true);
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
            logIn.Visible = true;
        }

        private void v51_Click(object sender, EventArgs e)
        {
            allFalse();
            viewProfile.setVisibility(true);
        }

        private void v52_Click(object sender, EventArgs e)
        {
            allFalse();
            settings.setVisibility(true);
        }

        public static void changeThemeAll()
        {
            viewElements.changeTheme();
            viewSchedule.changeTheme();
            viewPersonal.changeTheme();
            settings.changeTheme();
            //nisam za view profile
        }

        public static void translateAll(string curr, string want)
        {
            viewElements.translate(curr, want);
            viewSchedule.translate(curr, want);
            viewPersonal.translate(curr, want);
            //nisam za view profile
        }

        private void v4_Click(object sender, EventArgs e)
        {
            allFalse();
            viewElements.setVisibility(true);
        }

        private void v2_Click(object sender, EventArgs e)
        {
            allFalse();
            viewPersonal.setVisibility(true);
        }
    }
}
