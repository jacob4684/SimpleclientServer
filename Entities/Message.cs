using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    /// <summary>
    /// create a message for the user to send
    /// </summary>
    public class Message
    {
        #region Fields
        /// <summary>
        /// contain contents there get send to the user
        /// </summary>
        private string contents;
        /// <summary>
        /// contain the user sends the message
        /// </summary>
        private User sender;
        /// <summary>
        /// contain the user who receives the message
        /// </summary>
        private User receiver;
        #endregion


        #region Constructor
        /// <summary>
        /// Construct the message
        /// </summary>
        /// <param name="contents">is the content of the message</param>
        /// <param name="sender">is the user who send the message</param>
        /// <param name="receiver">is the user who gets the message</param>
        public Message(string contents, User sender, User receiver)
        {
            Contents = contents;
            Sender = sender;
            Receiver = receiver;
        }
        #endregion


        #region Properties
        /// <summary>
        /// Get or sets the Contents
        /// </summary>
        public string Contents
        {
            get { return contents; }
            set { contents = value; }
        }
        /// <summary>
        /// Get or sets the Sender
        /// </summary>
        public User Sender
        {
            get { return sender; }
            set { sender = value; }
        }
        /// <summary>
        /// Get or sets the receiver
        /// </summary>
        public User Receiver
        {
            get { return receiver; }
            set { receiver = value; }
        }
        #endregion


        #region Methods
        #endregion
    }
}
