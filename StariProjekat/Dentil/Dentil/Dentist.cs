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
    public partial class Dentist : Form
    {
        Form logIn;
        public static forms.dentist.allOpPatients patient = null;
        public static forms.dentist.viewAppointments va = null;
        public static forms.profile.Settings settings = null;
        public static forms.profile.ViewProfile vp = null;

        public Dentist(Form logIn)
        {
            InitializeComponent();
            this.logIn = logIn;
            patient = new forms.dentist.allOpPatients(this, true);
            patient.setVisibility(false);
            va = new forms.dentist.viewAppointments(this, true);
            va.setVisibility(false);
            settings = new forms.profile.Settings(this, "dentist");
            settings.setVisibility(false);
            vp = new forms.profile.ViewProfile(this);
            vp.setVisibility(false);

            changeTheme();
            translate(Program.defaultLang, Program.lang.CurrLang);

            tssl1.Text = $"{this.Width.ToString()} x {this.Height.ToString()}px";
        }

        private void v1_Click(object sender, EventArgs e)
        {
            allFalse();
            patient.setVisibility(true);
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
            logIn.Visible = true;
        }

        private void Dentist_FormClosing(object sender, FormClosingEventArgs e)
        {
            logIn.Dispose();
        }

        private void Dentist_Resize(object sender, EventArgs e)
        {
            tssl1.Text = $"{this.Width.ToString()} x {this.Height.ToString()}px";
        }

        private void allFalse()
        {
            patient.setVisibility(false);
            va.setVisibility(false);
            settings.setVisibility(false);
            vp.setVisibility(false);
        }

        private void v2_Click(object sender, EventArgs e)
        {
            allFalse();
            va.setVisibility(true);
        }

        private void v32_Click(object sender, EventArgs e)
        {
            allFalse();
            settings.setVisibility(true);
        }

        private void v31_Click(object sender, EventArgs e)
        {
            allFalse();
            vp.setVisibility(true);
        }

        public static void changeThemeAll()
        {
            va.changeTheme();
            patient.changeTheme();
            vp.changeTheme();
        }

        public static void translateAll(string curr, string want)
        {
            va.translate(curr, want);
            patient.translate(curr, want);
            vp.translate(curr, want);
        }
    }
}
