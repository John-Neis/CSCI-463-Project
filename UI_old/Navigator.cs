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
    public partial class Navigator : Form
    {
        public Navigator()
        {
            InitializeComponent();
        }
        private void moveSidePanel(Control c)
        {
            selectedPanelIndicator.Height = c.Height;
            selectedPanelIndicator.Top = c.Top;
        }
        private void buttonHome_Click(object sender, EventArgs e)
        {
            moveSidePanel(buttonHome);
        }

        private void buttonAccount_Click(object sender, EventArgs e)
        {
            moveSidePanel(buttonAccount); 
        }
    }
}
