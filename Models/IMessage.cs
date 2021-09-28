using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Chat.Models
{
    public interface IMessage
    {
        IUser Sender { get; set; }
        IUser Receiver { get; set; }
        string MessageText { get; set; }
        string GetFullMessageText();
    }
}
