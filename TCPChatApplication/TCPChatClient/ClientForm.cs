using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace TCPChatClient
{
    public partial class ClientForm : Form
    {
        

        public ClientForm()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(ClientForm_FormClosing);
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
           
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
        }

        private void ReceiveMessages()
        {
            
        }

        private void UpdateChatBox(string message)
        {
            
        }

        private void UpdateConnectionStatus()
        {
            
        }

        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void EmojiButton_Click(object sender, EventArgs e)
        {
           
        }

        private void EmojiListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
