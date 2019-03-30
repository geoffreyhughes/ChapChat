using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ghughesChapChat
{

   
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.usernameTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnterKeyPress);

        }

        private void usernameOK_Click(object sender, EventArgs e)
        {
            UpdateDialogAndClose();
        }

        private void usernameCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return && usernameTextbox.Text != "")
            {
                UpdateDialogAndClose();
            }
        }

        private void UpdateDialogAndClose()
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
