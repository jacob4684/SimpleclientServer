using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Message
    {
        #region Fields
        private string contents;
        private string sender;
        private string receiver;
        #endregion


        #region Constructor
        public Message(string contents, string sender, string receiver)
        {
            Contents = contents;
            Sender = sender;
            Receiver = receiver;
        }
        #endregion


        #region Properties
        public string Contents
        {
            get { return contents; }
            set { contents = value; }
        }
        public string Sender
        {
            get { return sender; }
            set { sender = value; }
        }

        public string Receiver
        {
            get { return receiver; }
            set { receiver = value; }
        }
        #endregion


        #region Methods
        #endregion
    }
}
