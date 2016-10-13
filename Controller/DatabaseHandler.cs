using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class DatabaseHandler
    {
        public static void MakeUser(string userName, string password)
        {
            DataAccess.Login(userName,password);
        }
    }
}
