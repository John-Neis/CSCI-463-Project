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
        private void exitMenuStripButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Exit MoneyHub?", "Confirm Exit", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Console.WriteLine(DateTime.Now + ": Application Exited");
                Environment.Exit(0);
            }
        }

        #endregion form closing
    }
}
