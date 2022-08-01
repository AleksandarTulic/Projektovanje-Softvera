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
    public partial class Other : Form
    {
        Form logIn;
        public static forms.dentist.allOpPatients patient = null;
        public static forms.dentist.viewAppointments va = null;
        public static forms.profile.Settings settings = null;
        public static forms.profile.ViewProfile vp = null;

        public Other(Form logIn)
        {
            InitializeComponent();
            this.logIn = logIn;
            patient = new forms.dentist.allOpPatients(this, false);
            patient.setVisibility(false);
            va = new forms.dentist.viewAppointments(this, false);
            va.setVisibility(false);
            settings = new forms.profile.Settings(this, "other");
            settings.setVisibility(false);
            vp = new forms.profile.ViewProfile(this);
            vp.setVisibility(false); //neki exception se desio na view profile
            
            translate(Program.defaultLang, Program.lang.CurrLang);
            changeTheme();

            tssl1.Text = $"{this.Width.ToString()} x {this.Height.ToString()}px";
        }

        private void v1_Click(object sender, EventArgs e)
        {
            allFalse();
            patient.setVisibility(true);
        }

        private void Other_Resize(object sender, EventArgs e)
        {
            tssl1.Text = $"{this.Width.ToString()} x {this.Height.ToString()}px";
        }

        private void Other_FormClosing(object sender, FormClosingEventArgs e)
        {
            logIn.Dispose();
        }

        private void v2_Click(object sender, EventArgs e)
        {
            allFalse();
            va.setVisibility(true);
        }

        private void v3_Click(object sender, EventArgs e)
        {
            allFalse();
        }

        private void v41_Click(object sender, EventArgs e)
        {
            allFalse();
            vp.setVisibility(true);
        }

        private void v42_Click(object sender, EventArgs e)
        {
            allFalse();
            settings.setVisibility(true);
        }

        private void v43_Click(object sender, EventArgs e)
        {
            allFalse();
            logIn.Visible = true;
            this.Dispose();
        }

        private void allFalse()
        {
            patient.setVisibility(false);
            va.setVisibility(false);
            settings.setVisibility(false);
            vp.setVisibility(false);
        }

        public static void translateAll(string curr, string want)
        {
            va.translate(curr, want);
            patient.translate(curr, want);
            vp.translate(curr, want);
        }

        public static void changeThemeAll()
        {
            va.changeTheme();
            patient.changeTheme();
            vp.changeTheme();
        }
    }
}
