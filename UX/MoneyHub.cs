using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyHub_User_Interface
{
    public partial class MoneyHubHome : Form
    {
        #region define global variables
        //used for testing, 1 is dev mode, 0 is production.
        static int mode = 1;
        //creation of login instance for startup
        static Login login = new Login();
        //creation of the account creation state 
        static accountCreator accountCreator = new accountCreator();
        List <UserAccount> currentUsers = new List<UserAccount>();
        #endregion
        public MoneyHubHome()
        {
            InitializeComponent();
            launchInMode(mode);
        }
        #region Startup function
        public void launchInMode(int config)
        {
            if(config == 1) //dev configuration
            {
                // do anything special for developer config like creating a fake account for testing purposes
                UserAccount test = new UserAccount("sam", "sam", "sdressler318@gmail.com", "7632631370", "Sam", "Dressler");
                currentUsers.Add(test);
            }
            else
            {
                //do something else or nothing for normal usage
            }
            //common stuff to do on startup.
            this.upperSideBasePanel.Controls.Add(login.loginPanel);

        }
        #endregion
        #region Create new Account
        public void createAccount()
        {
            login.usernameTextBox.Text = string.Empty;
            login.passwordTextBox.Text = string.Empty;
            this.upperSideBasePanel.Controls.Add(accountCreator.accountCreatorPanel);
            accountCreator.accountCreatorPanel.Visible = true; 
            login.loginPanel.Visible = false;
        }
        public void generateAccount()
        {

        }

        #region Event if account creation is cancelled
        public void cancelAccountCreation()
        {
            wait(100);
            accountCreator.accountCreatorPanel.Visible = false;
            login.loginPanel.Visible = true;
        }
        #endregion
        #endregion
        
        #region Log user in
        public void logUserIn()
        {
             validateUser();   
            
        }
        private void validateUser()
        {
            string uname = login.usernameTextBox.Text.Trim(' ');
            string pwd = login.passwordTextBox.Text.Trim(' ');
            bool usernameValid = false;
            bool pwdValid = false;
            UserAccount[] users = currentUsers.ToArray();
            if(!string.IsNullOrEmpty(uname))
            {
                for (int i = 0; i < users.Length; i++)
                {
                    if (users[i].username == uname)
                    {
                        usernameValid = true;
                        login.usernamePasswordInvalidText.Visible = false;
                    }
                }
                if(usernameValid == false)
                {
                    login.usernamePasswordInvalidText.Visible = true;
                }
                if (!string.IsNullOrEmpty(pwd))
                {
                    for (int i = 0; i < users.Length; i++)
                    {
                        if (users[i].userPassword == pwd)
                        {
                            pwdValid = true;
                            login.usernamePasswordInvalidText.Visible = false;
                        }
                    }
                    if(pwdValid == false)
                    {
                        login.usernamePasswordInvalidText.Visible = true;
                    }
                }
            }
            if(pwdValid == true && usernameValid == true)
            {
                Console.WriteLine(DateTime.Now + ": Login validated!");
                login.loginPanel.Visible = false;
                loginValidated();
            }
        }
        private void loginValidated()
        {

        }

        #endregion

        #region exit application
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            const string message = "Close the applcation?";
            const string caption = "Exit Application";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #endregion
        #region utility
        private void wait(int time)
        {
            //time to wait in Milliseconds
            Task.Delay(time).Wait();
        }
        #endregion


    }
}
