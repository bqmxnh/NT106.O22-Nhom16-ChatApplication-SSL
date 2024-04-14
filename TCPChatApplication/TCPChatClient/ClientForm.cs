using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TCPChatClient
{
    public partial class ClientForm : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        private Thread thread;
        private bool isConnected = false;
        private bool isClosingByButton = false;
        private string nickname;

        // Danh sách emoji Unicode
        private readonly string[] emojis = new string[]
        {
            "\U0001F600", // 😀
            "\U0001F601", // 😁
            "\U0001F602"  // 😂
            // Có thể hêm các emoji khác vào đây
        };

        public ClientForm()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(ClientForm_FormClosing);
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            client = new TcpClient();
            try
            {
                client.Connect("127.0.0.1", 8888);
                stream = client.GetStream();
                nickname = NicknameTextBox.Text;
                byte[] nicknameData = Encoding.UTF8.GetBytes(nickname);
                stream.Write(nicknameData, 0, nicknameData.Length);
                thread = new Thread(ReceiveMessages);
                thread.Start();
                isConnected = true;
                UpdateConnectionStatus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to server: " + ex.Message);
            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if (isConnected && stream != null)
            {
                string message = MessageTextBox.Text;
                byte[] messageData = Encoding.UTF8.GetBytes(message);
                stream.Write(messageData, 0, messageData.Length);
                stream.Flush();
                UpdateChatBox($"You: {message}");
                MessageTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Not connected to server.");
            }
        }

        private void ReceiveMessages()
        {
            while (isConnected && stream != null)
            {
                byte[] data = new byte[4096];
                int bytesRead = 0;
                try
                {
                    bytesRead = stream.Read(data, 0, 4096);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error receiving data: " + ex.Message);
                    break;
                }

                if (bytesRead == 0)
                {
                    Console.WriteLine("Disconnected from server.");
                    break;
                }
                string message = Encoding.UTF8.GetString(data, 0, bytesRead);
                UpdateChatBox(message);
            }
        }

        private void UpdateChatBox(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(UpdateChatBox), message);
                return;
            }

            ChatTextBox.AppendText(message + Environment.NewLine);
        }

        private void UpdateConnectionStatus()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(UpdateConnectionStatus));
                return;
            }
            ConnectionStatusLabel.Text = isConnected ? "Connected" : "Disconnected";
        }

        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            isClosingByButton = e.CloseReason == CloseReason.UserClosing;
            if (isClosingByButton)
            {
                Application.Exit();
                Environment.Exit(0);
            }
        }

        private void EmojiButton_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem danh sách emoji đã có sẵn chưa
            if (EmojiListBox.Items.Count == 0)
            {
                // Nếu danh sách rỗng, thêm emoji vào danh sách
                foreach (string emoji in emojis)
                {
                    EmojiListBox.Items.Add(emoji);
                }
            }

            // Đảo ngược trạng thái hiển thị của danh sách emoji
            EmojiListBox.Visible = !EmojiListBox.Visible;
        }


        private void EmojiListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EmojiListBox.SelectedItem != null)
            {
                MessageTextBox.Text += EmojiListBox.SelectedItem.ToString();
                EmojiListBox.Visible = false;
            }
        }
    }
}
