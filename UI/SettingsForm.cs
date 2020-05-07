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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void deleteAccountButton_MouseHover(object sender, EventArgs e)
        {
            this.alertPictureBox.Visible = true;
        }

        private void deleteAccountButton_MouseLeave(object sender, EventArgs e)
        {
            this.alertPictureBox.Visible = false;
        }
    }
}
