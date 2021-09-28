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

namespace MVP_Chat
{
    public partial class MainView : Form
    {
        ChatView chatViewOleksandr = new ChatView(Data.Users[0], Data.Users[1]);
        ChatView chatViewSerhii = new ChatView(Data.Users[1], Data.Users[0]);

        public MainView()
        {
            InitializeComponent();
        }

        private void buttonOpenChatOleksandr_Click(object sender, EventArgs e)
        {
            chatViewOleksandr.Show();
            chatViewOleksandr.MessageUpdateEvent += chatViewSerhii.GetMessage;
        }

        private void buttonOpenChatSerhii_Click(object sender, EventArgs e)
        {
            chatViewSerhii.Show();
            chatViewSerhii.MessageUpdateEvent += chatViewOleksandr.GetMessage;
        }
    }
}
