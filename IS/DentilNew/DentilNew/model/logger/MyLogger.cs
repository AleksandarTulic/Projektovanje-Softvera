using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;

namespace DentilNew.model.logger
{
    internal class MyLogger
    {
        private static readonly string FILEPATH = Directory.GetCurrentDirectory() + "\\..\\..\\model\\logger\\history\\" + (DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond) + ".log";
        private static MyLogger logger = new MyLogger();

        private MyLogger()
        {
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public void log(String message)
        {
            using (StreamWriter w = File.AppendText(MyLogger.FILEPATH))
            {
                w.Write("\r\nLog Entry : ");
                w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                w.WriteLine("Message: {0}", message);
                w.WriteLine("================================================================================================\n");
            }
        }

        public static MyLogger Logger{
            get{ return logger;}
        }
    }
}
