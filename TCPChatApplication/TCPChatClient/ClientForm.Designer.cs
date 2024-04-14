namespace TCPChatClient
{
    partial class ClientForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            NicknameTextBox = new TextBox();
            ConnectButton = new Button();
            ConnectionStatusLabel = new Label();
            ChatTextBox = new TextBox();
            MessageTextBox = new TextBox();
            SendButton = new Button();
            EmojiButton = new Button();
            EmojiListBox = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(146, 25);
            label1.TabIndex = 0;
            label1.Text = "Enter a nickname";
            // 
            // NicknameTextBox
            // 
            NicknameTextBox.Location = new Point(164, 9);
            NicknameTextBox.Name = "NicknameTextBox";
            NicknameTextBox.Size = new Size(396, 31);
            NicknameTextBox.TabIndex = 1;
            // 
            // ConnectButton
            // 
            ConnectButton.Location = new Point(566, 9);
            ConnectButton.Name = "ConnectButton";
            ConnectButton.Size = new Size(112, 34);
            ConnectButton.TabIndex = 2;
            ConnectButton.Text = "Connect";
            ConnectButton.UseVisualStyleBackColor = true;
            ConnectButton.Click += ConnectButton_Click;
            // 
            // ConnectionStatusLabel
            // 
            ConnectionStatusLabel.AutoSize = true;
            ConnectionStatusLabel.Location = new Point(702, 12);
            ConnectionStatusLabel.Name = "ConnectionStatusLabel";
            ConnectionStatusLabel.Size = new Size(60, 25);
            ConnectionStatusLabel.TabIndex = 3;
            ConnectionStatusLabel.Text = "Status";
            // 
            // ChatTextBox
            // 
            ChatTextBox.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ChatTextBox.Location = new Point(12, 64);
            ChatTextBox.Multiline = true;
            ChatTextBox.Name = "ChatTextBox";
            ChatTextBox.Size = new Size(776, 332);
            ChatTextBox.TabIndex = 4;
            // 
            // MessageTextBox
            // 
            MessageTextBox.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MessageTextBox.Location = new Point(12, 407);
            MessageTextBox.Name = "MessageTextBox";
            MessageTextBox.Size = new Size(530, 31);
            MessageTextBox.TabIndex = 5;
            // 
            // SendButton
            // 
            SendButton.Location = new Point(676, 407);
            SendButton.Name = "SendButton";
            SendButton.Size = new Size(112, 34);
            SendButton.TabIndex = 6;
            SendButton.Text = "Send";
            SendButton.UseVisualStyleBackColor = true;
            SendButton.Click += SendButton_Click;
            // 
            // EmojiButton
            // 
            EmojiButton.Location = new Point(558, 407);
            EmojiButton.Name = "EmojiButton";
            EmojiButton.Size = new Size(112, 34);
            EmojiButton.TabIndex = 7;
            EmojiButton.Text = "Emoji";
            EmojiButton.UseVisualStyleBackColor = true;
            EmojiButton.Click += EmojiButton_Click;
            // 
            // EmojiListBox
            // 
            EmojiListBox.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmojiListBox.FormattingEnabled = true;
            EmojiListBox.ItemHeight = 32;
            EmojiListBox.Location = new Point(558, 284);
            EmojiListBox.Name = "EmojiListBox";
            EmojiListBox.Size = new Size(180, 100);
            EmojiListBox.TabIndex = 8;
            EmojiListBox.Visible = false;
            EmojiListBox.SelectedIndexChanged += EmojiListBox_SelectedIndexChanged;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(EmojiListBox);
            Controls.Add(EmojiButton);
            Controls.Add(SendButton);
            Controls.Add(MessageTextBox);
            Controls.Add(ChatTextBox);
            Controls.Add(ConnectionStatusLabel);
            Controls.Add(ConnectButton);
            Controls.Add(NicknameTextBox);
            Controls.Add(label1);
            Name = "ClientForm";
            Text = "Client";
            FormClosing += ClientForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox NicknameTextBox;
        private Button ConnectButton;
        private Label ConnectionStatusLabel;
        private TextBox ChatTextBox;
        private TextBox MessageTextBox;
        private Button SendButton;
        private Button EmojiButton;
        private ListBox EmojiListBox;
    }
}
