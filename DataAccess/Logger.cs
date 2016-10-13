using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    /// <summary>
    /// used to send logfile to the debug folder 
    /// </summary>
    public static class Logger
    {
        /// <summary>
        /// the place where the log is save on the pc
        /// </summary>
        private readonly static string Path;
        /// <summary>
        /// tries to insert debug+\log.txt into Path throws Exception if it cant
        /// </summary>
        static Logger()
        {
            try
            {
                string codebase = Assembly.GetExecutingAssembly().CodeBase;
                UriBuilder uri = new UriBuilder(codebase);
                string path = Uri.UnescapeDataString(uri.Path);
                Path = System.IO.Path.GetDirectoryName(path)+ "\\log.txt";
            }
            catch (Exception)
            {

                throw;
            }


        }
        /// <summary>
        /// if the message are not null create a logfile with timestamp on 
        /// </summary>
        /// <param name="message">is the message for the logfile</param>
        public static void Log(string message)
        {
            if (message != null)
            {
                DateTime dateTimeNow = new DateTime();
                dateTimeNow = DateTime.Now;
                //System.IO.File.WriteAllText(Path, dateTimeNow.ToString("f", CultureInfo.CreateSpecificCulture("da-Dk")) +" "+ message);
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(Path,true))
                {
                    file.WriteLine($"{dateTimeNow.ToString("f", CultureInfo.CreateSpecificCulture("da-Dk"))} {message}");
                    
                }
            }

        }
    }
}
