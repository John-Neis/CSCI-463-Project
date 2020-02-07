using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyHub
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        #region Form Closing
        private void exitMenuStripButton_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sign out?", "Confirm Sign out", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Console.WriteLine(DateTime.Now + ": User Signed out");

                //Environment.Exit(0);
            }
        }
        #endregion form closing
    }
}
