using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;

namespace TCPChatServer
{
    public partial class ServerForm : Form
    {
        

        public ServerForm()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(ServerForm_FormClosing);
        }

        private void StartServerButton_Click_1(object sender, EventArgs e)
        {
            
        }

        private void ListenForClients()
        {
           
        }

        private void HandleClientComm(object? client)
        {
           
        }
        // Gửi tin nhắn từ server đến tất cả client
        private void SendServerMessage(string message)
        {
           
        }
        // Sự kiện click cho nút gửi tin nhắn từ server đến client
        private void SendToClientsButton_Click(object sender, EventArgs e)
        {
           
        }
        private void UpdateStatus(string message)
        {
           
        }

        private void ServerForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
           
        }
    }
}
