namespace ghughesChapChat
{
    partial class ChatForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sendButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.UsersOnline = new System.Windows.Forms.Label();
            this.chatBoxHistory = new System.Windows.Forms.TextBox();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.ChatHistoryLabel = new System.Windows.Forms.Label();
            this.onlineUsers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // sendButton
            // 
            this.sendButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sendButton.Location = new System.Drawing.Point(460, 825);
            this.sendButton.Margin = new System.Windows.Forms.Padding(6);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(150, 44);
            this.sendButton.TabIndex = 1;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearButton.Location = new System.Drawing.Point(622, 825);
            this.clearButton.Margin = new System.Windows.Forms.Padding(6);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(150, 44);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // UsersOnline
            // 
            this.UsersOnline.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UsersOnline.AutoSize = true;
            this.UsersOnline.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersOnline.Location = new System.Drawing.Point(884, 63);
            this.UsersOnline.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.UsersOnline.Name = "UsersOnline";
            this.UsersOnline.Size = new System.Drawing.Size(240, 44);
            this.UsersOnline.TabIndex = 5;
            this.UsersOnline.Text = "Users Online";
            // 
            // chatBoxHistory
            // 
            this.chatBoxHistory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chatBoxHistory.Cursor = System.Windows.Forms.Cursors.Default;
            this.chatBoxHistory.Location = new System.Drawing.Point(24, 115);
            this.chatBoxHistory.Margin = new System.Windows.Forms.Padding(6);
            this.chatBoxHistory.Multiline = true;
            this.chatBoxHistory.Name = "chatBoxHistory";
            this.chatBoxHistory.ReadOnly = true;
            this.chatBoxHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.chatBoxHistory.Size = new System.Drawing.Size(744, 592);
            this.chatBoxHistory.TabIndex = 6;
            this.chatBoxHistory.TextChanged += new System.EventHandler(this.ChatHistory_TextChanged_1);
            // 
            // messageBox
            // 
            this.messageBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.messageBox.Location = new System.Drawing.Point(24, 746);
            this.messageBox.Margin = new System.Windows.Forms.Padding(6);
            this.messageBox.Multiline = true;
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(744, 64);
            this.messageBox.TabIndex = 7;
            this.messageBox.TextChanged += new System.EventHandler(this.ChatSending_TextChanged);
            this.messageBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChatSending_KeyDown);
            // 
            // ChatHistoryLabel
            // 
            this.ChatHistoryLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ChatHistoryLabel.AutoSize = true;
            this.ChatHistoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChatHistoryLabel.Location = new System.Drawing.Point(296, 63);
            this.ChatHistoryLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ChatHistoryLabel.Name = "ChatHistoryLabel";
            this.ChatHistoryLabel.Size = new System.Drawing.Size(175, 44);
            this.ChatHistoryLabel.TabIndex = 8;
            this.ChatHistoryLabel.Text = "Chat Box";
            // 
            // onlineUsers
            // 
            this.onlineUsers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.onlineUsers.BackColor = System.Drawing.SystemColors.Menu;
            this.onlineUsers.FormattingEnabled = true;
            this.onlineUsers.ItemHeight = 25;
            this.onlineUsers.Location = new System.Drawing.Point(792, 150);
            this.onlineUsers.Name = "onlineUsers";
            this.onlineUsers.Size = new System.Drawing.Size(426, 479);
            this.onlineUsers.TabIndex = 9;
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 1023);
            this.Controls.Add(this.onlineUsers);
            this.Controls.Add(this.ChatHistoryLabel);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.chatBoxHistory);
            this.Controls.Add(this.UsersOnline);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.sendButton);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChatForm";
            this.Text = "ghughes\'s ChapChat";
            this.Load += new System.EventHandler(this.ChatForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label UsersOnline;
        private System.Windows.Forms.TextBox chatBoxHistory;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.Label ChatHistoryLabel;
        private System.Windows.Forms.ListBox onlineUsers;
    }
}

