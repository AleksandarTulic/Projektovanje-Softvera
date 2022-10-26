using DentilNew.controller;
using DentilNew.model.notification;
using DentilNew.model.validation;
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
        public static ToothController toothController = new ToothController();
        public static ProblemController problemController = new ProblemController();
        public static TreatmentController treatmentController = new TreatmentController();
        public static TypeProblemController typeProblemController = new TypeProblemController();
        public static PatientValidation patientValidation = new PatientValidation();
        public static PatientController patientController = new PatientController();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
