using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Chat.Models
{
    public class Message : IMessage
    {
        private IUser sender;
        private IUser receiver;
        private string messageText;

        public Message(IUser sender, IUser receiver, string messageText)
        {
            Sender = sender;
            Receiver = receiver;
            MessageText = messageText;
        }

        public string GetFullMessageText()
        {
            return "From: " + this.Sender.Login + "     To: " + this.Receiver.Login + "     Message: " + this.MessageText + "      " + new DateTime().ToShortTimeString();
        }

        public IUser Sender { get => sender; set => sender = value; }
        public IUser Receiver { get => receiver; set => receiver = value; }
        public string MessageText { get => messageText; set => messageText = value; }
    }
}
