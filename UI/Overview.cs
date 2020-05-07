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
    public partial class Overview : Form
    {
        public Overview()
        {
            InitializeComponent();
        }
        Navigator n = new Navigator();
        private void seeCheckingDetailsButton_Click(object sender, EventArgs e)
        {
            n.moveSidePanel(n.buttonAccount);
            Program.mh.showAccountsPanel();
        }

        private void seeSavingsDetailsButton_Click(object sender, EventArgs e)
        {
            n.moveSidePanel(n.buttonAccount);
            Program.mh.showAccountsPanel();
        }

        private void seeLoanDetailsButton_Click(object sender, EventArgs e)
        {
            n.moveSidePanel(n.buttonAccount);
            Program.mh.showAccountsPanel();
        }
    }
}
