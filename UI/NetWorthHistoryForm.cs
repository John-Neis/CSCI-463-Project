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
    public partial class NetWorthHistoryForm : Form
    {
        public NetWorthHistoryForm()
        {
            InitializeComponent();
        }

        private void oneYearRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Program.mh.setOneYearScaling();
        }

        private void threeYearRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Program.mh.setThreeYearScaling();
        }
        private void allTimeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Program.mh.setAllTimeScaling();
        }

        private void buttonSeeBreakDown_Click(object sender, EventArgs e)
        {
            Program.mh.showNetWorthBreakDown();
        }
    }
}
