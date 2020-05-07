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
    public partial class NetWorthBreakDownForm : Form
    {
        public NetWorthBreakDownForm()
        {
            InitializeComponent();
        }
        Navigator n = new Navigator();
        private void buttonSeeNetWorthHistory_Click(object sender, EventArgs e)
        {
            Program.mh.showNetWorthHistory();
        }

        private void addAccountButton_Click(object sender, EventArgs e)
        {
            n.moveSidePanel(n.buttonAccount);
            Program.mh.showAccountsPanel();
            //TODO: Open the tab to open a new account
        }
    }
}
