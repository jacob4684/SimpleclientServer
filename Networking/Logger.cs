using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Networking
{
    public static class Logger
    {
        readonly static string path;
        


        static Logger()
        {
            path = "vejen til";
        }
        public static void Log(string message, bool OmitDate)
        {
            if (!OmitDate)
                message = DateTime.Now + " " + message;
            Trace.WriteLine(message);
        }
        static void Log(string message) { Log(message, false); }
    }
}
