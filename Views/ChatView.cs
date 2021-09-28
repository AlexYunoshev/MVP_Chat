using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVP_Chat.Models;
using MVP_Chat.Views;
using MVP_Chat.Presenters;

namespace MVP_Chat
{


    public partial class ChatView : Form, IChatView
    {
        private IUser sender;
        private IUser receiver;
        private List<IMessage> messages;

        public class MessageEventArgs : EventArgs
        {
            public IMessage Message { get; }
            public MessageEventArgs(IMessage message)
            {
                Message = message;
            }
        }

        public delegate void ChatHandler(IMessage message);
        public event ChatHandler MessageUpdateEvent;
        //public event EventHandler<MessageEventArgs> MessageUpdateEvent;


        public ChatView(IUser sender, IUser receiver)
        {
            InitializeComponent();
            Sender = sender;
            Receiver = receiver;
            SenderLogin = Sender.Login;
            ReceiverLogin = Receiver.Login;
            Messages = new List<IMessage>();
        }

        public IUser Sender { get => sender; set => sender = value; }
        public IUser Receiver { get => receiver; set => receiver = value; }
        public string SenderLogin { get => textBoxSenderLogin.Text; set => textBoxSenderLogin.Text = value; }
        public string ReceiverLogin { get => textBoxReceiverLogin.Text; set => textBoxReceiverLogin.Text = value; }
        public string MessageText { get => textBoxMessage.Text; set => textBoxMessage.Text = value; }
        public List<IMessage> Messages { get => messages; set => messages = value; }

        public void GetMessage(IMessage message)
        {
            listViewMessages.Items.Add(message.GetFullMessageText());
        }

        public void buttonSend_Click(object sender, EventArgs e)
        {
            ChatPresenter chatPresenter = new ChatPresenter(this);
            chatPresenter.SendMessage();
            listViewMessages.Items.Add(messages[messages.Count - 1].GetFullMessageText());
            MessageUpdateEvent?.Invoke(messages[messages.Count - 1]);
            //MessageUpdateEvent?.Invoke(this, new MessageEventArgs(messages[messages.Count - 1]));
        }
    }
}
