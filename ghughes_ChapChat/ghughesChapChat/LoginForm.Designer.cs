namespace ghughesChapChat
{
    partial class LoginForm
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
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.usernameOK = new System.Windows.Forms.Button();
            this.usernameCancel = new System.Windows.Forms.Button();
            this.enterUsernameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameTextbox.Location = new System.Drawing.Point(34, 115);
            this.usernameTextbox.Margin = new System.Windows.Forms.Padding(6);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(402, 31);
            this.usernameTextbox.TabIndex = 0;
            this.usernameTextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // usernameOK
            // 
            this.usernameOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameOK.Location = new System.Drawing.Point(519, 111);
            this.usernameOK.Margin = new System.Windows.Forms.Padding(6);
            this.usernameOK.Name = "usernameOK";
            this.usernameOK.Size = new System.Drawing.Size(138, 44);
            this.usernameOK.TabIndex = 1;
            this.usernameOK.Text = "OK";
            this.usernameOK.UseVisualStyleBackColor = true;
            this.usernameOK.Click += new System.EventHandler(this.usernameOK_Click);
            // 
            // usernameCancel
            // 
            this.usernameCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameCancel.Location = new System.Drawing.Point(520, 177);
            this.usernameCancel.Margin = new System.Windows.Forms.Padding(6);
            this.usernameCancel.Name = "usernameCancel";
            this.usernameCancel.Size = new System.Drawing.Size(136, 46);
            this.usernameCancel.TabIndex = 2;
            this.usernameCancel.Text = "Cancel";
            this.usernameCancel.UseVisualStyleBackColor = true;
            this.usernameCancel.Click += new System.EventHandler(this.usernameCancel_Click);
            // 
            // enterUsernameLabel
            // 
            this.enterUsernameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.enterUsernameLabel.AutoSize = true;
            this.enterUsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterUsernameLabel.Location = new System.Drawing.Point(24, 44);
            this.enterUsernameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.enterUsernameLabel.Name = "enterUsernameLabel";
            this.enterUsernameLabel.Size = new System.Drawing.Size(474, 46);
            this.enterUsernameLabel.TabIndex = 3;
            this.enterUsernameLabel.Text = "Please enter a username:";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 246);
            this.Controls.Add(this.enterUsernameLabel);
            this.Controls.Add(this.usernameCancel);
            this.Controls.Add(this.usernameOK);
            this.Controls.Add(this.usernameTextbox);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Username";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button usernameOK;
        private System.Windows.Forms.Button usernameCancel;
        private System.Windows.Forms.Label enterUsernameLabel;
        public System.Windows.Forms.TextBox usernameTextbox;
    }
}