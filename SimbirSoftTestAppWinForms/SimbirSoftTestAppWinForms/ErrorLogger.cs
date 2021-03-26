using System;
using System.IO;

namespace SimbirSoftTestAppWinForms
{
    public class ErrorLogger
    {
        public ErrorLogger(Exception ex)
        {
            ErrorLogging(ex);
        }
        private void ErrorLogging(Exception ex)
        {
            if(!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\Logs"))
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"\Logs");

            string errorsPath = AppDomain.CurrentDomain.BaseDirectory + @"\Logs\ErrorLog.txt";

            if (File.Exists(errorsPath))
            {
                File.AppendAllText(errorsPath, ErrorDetails(ex));
            }
            else
            {
                File.WriteAllText(errorsPath, ErrorDetails(ex));
            }
        }

        private string ErrorDetails(Exception ex)
        {
            return "Time: " + DateTime.Now + Environment.NewLine + ex.Message + "\nInner exception:\n" + 
                ex.InnerException + "\nStack trace:\n" + ex.StackTrace + "\nException method:\n" +
                ex.TargetSite + "\nException source:\n" +
                ex.Source +
                ex.Data + "\nException data:\n" +
                "\n-------------------------------\n";
        }
    }
}
