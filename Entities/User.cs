using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    /// <summary>
    /// creates users who can send messages
    /// </summary>
    public class User
    {
        #region Fields
        /// <summary>
        /// contain the users name
        /// </summary>
        private string userName;
        /// <summary>
        /// contain the users password
        /// </summary>
        private string password;
        #endregion
        #region Constructor
        /// <summary>
        /// Construct the user with name and password
        /// </summary>
        /// <param name="userName">is the user name</param>
        /// <param name="password">is the user password</param>
        public User(string userName,string password)
        {
            UserName = userName;
            Password = password;
        }
        #endregion
        #region Properties
        /// <summary>
        /// Get or sets the Password. Validates it so its lower then 21 and not null or white space
        /// </summary>
        public string Password
        {
            get { return password; }
            set
            {
                if (value.Length>20 && value.Trim().Length==0)
                {
                    throw new ArgumentException("Password to long have to be less then 21 and not null or white space ");
                }
                password = value;
            }
        }
        /// <summary>
        /// Get or sets the UserName. Validates it so its lower then 31 and not null or white space
        /// </summary>
        public string UserName
        {
            get { return userName; }
            set
            {
                if (value.Length > 30 && value.Trim().Length == 0)
                {
                    throw new ArgumentException("Username to long have to be less then 31 and not null or white space ");
                }
                userName = value;
            }
        }
        #endregion

    }
}
