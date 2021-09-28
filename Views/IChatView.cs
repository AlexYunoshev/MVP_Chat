using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVP_Chat.Models;

namespace MVP_Chat.Views
{
    public interface IChatView
    {
        List<IMessage> Messages { get; set; }
        IUser Sender { get; set; }
        IUser Receiver { get; set; }

        string SenderLogin { get; set; }
        string ReceiverLogin { get; set; }
        string MessageText { get; set; }

        
    }
}
