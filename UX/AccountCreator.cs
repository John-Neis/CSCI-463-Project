using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyHub_User_Interface
{
    public partial class accountCreator : Form
    {
        public accountCreator()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            clearFields();
            Program.mh.cancelAccountCreation();
        }
        private void clearFields()
        {
            this.usernameTextBox.Text = string.Empty;
            this.passwordTextBox.Text = string.Empty;
            this.firstnameTextBox.Text = string.Empty;
            this.lastnameTextBox.Text = string.Empty;
            this.passwordTextBox.Text = string.Empty;
            this.phoneNumberTextBox.Text = string.Empty;
            this.emailTextBox.Text = string.Empty;
            this.confirmPasswordTextBox.Text = string.Empty;
            return;
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            Program.mh.generateAccount();
        }
    }
}
