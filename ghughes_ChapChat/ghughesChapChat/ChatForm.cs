using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapNet;

namespace ghughesChapChat
{
    public partial class ChatForm : Form, IChapChatReceiver
    {
        delegate void MessageDelegate(string message);
        delegate int AddUsernameDelegate(object username);
        delegate void RemoveUsernameDelegate(object username);

        LoginForm loginForm;
        ChapChatNetDriver netDriver;

        public ChatForm()
        {
            InitializeComponent();
            loginForm = new LoginForm();
            netDriver = new ChapChatNetDriver(this);
            
            DialogResult result = loginForm.ShowDialog();
            onlineUsers.Items.Add(loginForm.usernameTextbox.Text);

            if (result == DialogResult.Cancel)
            {
                Close();
            }

            netDriver.SendConnect();

            netDriver.OnUserConnect = AddUsername;
            netDriver.OnUserDisconnect = RemoveUsername;
        }

        public ChatForm(string username)
        {
            InitializeComponent();
            onlineUsers.Text = username;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            messageBox.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Users Online
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if (messageBox.Text != "")
            {
                SendTextMessage();
            }
        }

        private void ChatHistory_TextChanged_1(object sender, EventArgs e)
        {
            // Chat History Box
        }

        private void ChatSending_TextChanged(object sender, EventArgs e)
        {
            // Chat Sending Box
        }

        private void ChatSending_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && messageBox.Text != "" && !e.Shift)
            {
                SendTextMessage();
                e.SuppressKeyPress = true;
            }
        }

        public void OnReceiveMessage(string sender, string receivedMessage)
        {
            if (!onlineUsers.Items.Contains(sender))
            {
                this.Invoke(new AddUsernameDelegate(onlineUsers.Items.Add), sender);
            }
            Invoke(new MessageDelegate(chatBoxHistory.AppendText), "[" + sender + "] " + DateTime.Now.ToLongTimeString() + ": " + receivedMessage + Environment.NewLine);
        }

        public string GetUsername()
        {
            return loginForm.usernameTextbox.Text;
        }

        public void AddUsername(string username)
        {
            if (!onlineUsers.Items.Contains(username))
            {
                this.Invoke(new AddUsernameDelegate(onlineUsers.Items.Add), username);
            }
        }

        public void RemoveUsername(string username)
        {
            if (onlineUsers.Items.Contains(username))
            {
               this.Invoke(new RemoveUsernameDelegate(onlineUsers.Items.Remove), username);
            }
        }

        private void ChatForm_Load(object sender, EventArgs e)
        {
            if (loginForm.DialogResult == DialogResult.Cancel)
            {
                Close();
            }
        }

        public void SendTextMessage()
        {
            netDriver.SendMessage(messageBox.Text);
            chatBoxHistory.Text += "[" + loginForm.usernameTextbox.Text + "] " + DateTime.Now.ToLongTimeString() + ": " + messageBox.Text;
            chatBoxHistory.Text += Environment.NewLine;
            messageBox.Text = "";
        }
    }
}
