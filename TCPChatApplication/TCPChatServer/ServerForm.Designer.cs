namespace TCPChatServer
{
    partial class ServerForm
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
            StatusTextBox = new TextBox();
            ServerMessageTextBox = new TextBox();
            SendToClientsButton = new Button();
            StartServerButton = new Button();
            SuspendLayout();
            // 
            // StatusTextBox
            // 
            StatusTextBox.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StatusTextBox.Location = new Point(12, 12);
            StatusTextBox.Multiline = true;
            StatusTextBox.Name = "StatusTextBox";
            StatusTextBox.Size = new Size(776, 385);
            StatusTextBox.TabIndex = 0;
            // 
            // ServerMessageTextBox
            // 
            ServerMessageTextBox.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ServerMessageTextBox.Location = new Point(12, 403);
            ServerMessageTextBox.Name = "ServerMessageTextBox";
            ServerMessageTextBox.Size = new Size(540, 31);
            ServerMessageTextBox.TabIndex = 1;
            // 
            // SendToClientsButton
            // 
            SendToClientsButton.Location = new Point(558, 400);
            SendToClientsButton.Name = "SendToClientsButton";
            SendToClientsButton.Size = new Size(112, 34);
            SendToClientsButton.TabIndex = 2;
            SendToClientsButton.Text = "Send";
            SendToClientsButton.UseVisualStyleBackColor = true;
            SendToClientsButton.Click += SendToClientsButton_Click;
            // 
            // StartServerButton
            // 
            StartServerButton.Location = new Point(676, 400);
            StartServerButton.Name = "StartServerButton";
            StartServerButton.Size = new Size(112, 34);
            StartServerButton.TabIndex = 3;
            StartServerButton.Text = "Start";
            StartServerButton.UseVisualStyleBackColor = true;
            StartServerButton.Click += StartServerButton_Click_1;
            // 
            // ServerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(StartServerButton);
            Controls.Add(SendToClientsButton);
            Controls.Add(ServerMessageTextBox);
            Controls.Add(StatusTextBox);
            Name = "ServerForm";
            Text = "Server";
            FormClosing += ServerForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox StatusTextBox;
        private TextBox ServerMessageTextBox;
        private Button SendToClientsButton;
        private Button StartServerButton;
    }
}
