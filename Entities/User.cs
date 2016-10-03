using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class User
    {
        #region Fields
        private string userName;
        private string password;
        #endregion
        public User(string userName,string password)
        {
            UserName = userName;
            Password = password;
        }
        #region Properties
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        #endregion

    }
}
