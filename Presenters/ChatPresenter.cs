using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVP_Chat.Models;
using MVP_Chat.Views;

namespace MVP_Chat.Presenters
{
    public class ChatPresenter
    {
        IChatView chatView;
     
       

        public ChatPresenter(IChatView chatView)
        {
            this.chatView = chatView;
        }

        public void SendMessage()
        {
            IMessage message = new Message(chatView.Sender, chatView.Receiver, chatView.MessageText);
           
            chatView.Messages.Add(message);
        }
    }
}
