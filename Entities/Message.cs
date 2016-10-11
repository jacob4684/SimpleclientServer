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
        /// text content of the Message
        /// </summary>
        private string contents;
        /// <summary>
        /// the sender of the Message
        /// </summary>
        private User sender;
        /// <summary>
        /// the receive of the Message
        /// </summary>
        private User receiver;
        #endregion


        #region Constructor
        /// <summary>
        /// Creates a new instance of contents, sender and receiver
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
        /// Get or sets the validated Contents
        /// </summary>
        public string Contents
        {
            get { return contents; }
            set
            {
                if ( value.Length > 255 )
                {
                    throw new ArgumentException("message to long");
                }
                else if (value == null)
                {
                    throw new ArgumentException("message can't be null");
                }
                else if (contents != value)
                {
                    contents = value;
                }
                
            }
        }
        /// <summary>
        /// Get or sets the validated Sender
        /// </summary>
        public User Sender
        {
            get { return sender; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Sender can't be null");
                }
                else if (sender != value)
                {
                    sender = value;
                }
              
            }
        }
        /// <summary>
        /// Get or sets the validated receiver
        /// </summary>
        public User Receiver
        {
            get { return receiver; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Receiver can't be null");
                }

                else if (receiver != value)
                {
                    receiver = value;
                }
            }
        }
        #endregion


        #region Methods
        #endregion
    }
}
