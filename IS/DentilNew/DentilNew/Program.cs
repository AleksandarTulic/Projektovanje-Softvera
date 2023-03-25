using DentilNew.controller;
using DentilNew.model.dto;
using DentilNew.model.notification;
using DentilNew.model.security;
using DentilNew.model.theme;
using DentilNew.model.validation;
using DentilNew.view.modal_input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentilNew
{
    internal static class Program
    {
        public static Notification notification = new Notification();
        public static Crypt crypt = new Crypt();
        public static ToothController toothController = new ToothController();
        public static ProblemController problemController = new ProblemController();
        public static ServiceController treatmentController = new ServiceController();
        public static TypeProblemController typeProblemController = new TypeProblemController();
        public static PatientValidation patientValidation = new PatientValidation();
        public static PatientController patientController = new PatientController();
        public static VisitController visitController = new VisitController();
        public static LoginController loginController = new LoginController();
        public static VisitServiceController visitTreatmentController = new VisitServiceController();
        public static HistoryVisitController lastSeenController = new HistoryVisitController();
        public static AppointmentController appointmentController = new AppointmentController();
        public static DentistDTO dto = null;
        public static Theme theme = new Theme();
        public static readonly bool SQL_ACTIVE = true;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
