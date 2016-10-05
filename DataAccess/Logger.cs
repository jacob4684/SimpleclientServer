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
    public static class Logger
    {
        /// <summary>
        /// the place where the log is save on the pc
        /// </summary>
        private readonly static string Path;

        static Logger()
        {
            try
            {
                string codebase = Assembly.GetExecutingAssembly().CodeBase;
                UriBuilder uri = new UriBuilder(codebase);
                string path = Uri.UnescapeDataString(uri.Path);
                Path = System.IO.Path.GetDirectoryName(path);
            }
            catch (Exception)
            {

                throw;
            }


        }
        public static void Log(string message)
        {
            if (message != null)
            {
                DateTime dateTimeNow = new DateTime();
                dateTimeNow = DateTime.Now;
                File.WriteAllText(Path, dateTimeNow.ToString("f", CultureInfo.CreateSpecificCulture("da-Dk")) + message);
            }

        }

    }
}
