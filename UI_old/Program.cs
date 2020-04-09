using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyHub_User_Interface
{

    static class Program
    {
        public static MoneyHubHome mh;
        //Windows requires this
        [STAThread]
        //Enable console debug information to be visible
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        //variables
        static extern bool AttachConsole(int dwProcessId);
        private const int ATTACH_PARENT_PROCESS = -1;

        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AttachConsole(ATTACH_PARENT_PROCESS);
            mh = new MoneyHubHome();
            Application.Run(mh);
        }
    }
}
