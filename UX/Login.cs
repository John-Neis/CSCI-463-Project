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
    public partial class Login : Form
    {
        #region Login

        #region initialize variables
        //Variables "192.168.51.209"
        //byte[] ip = { 192, 168, 51, 209};
        //Sam's pc ip
        String ip = "192.168.51.209";
        int port = 4444;
        string message = "Test2";
        ServerConnector client = new ServerConnector();
        
        //User currentUser = null;
        User testUser = new User("test", "test");
        Home application = new Home();
        String userText = string.Empty;
        String pwdText = string.Empty;
        #endregion
        #region Startup
        public Login()
        {
            //this.client.ExecuteClient(ip, port, message);
            InitializeComponent();
        }
        #endregion
        #region User Attempts to Login 
        private void loginButton_Click(object sender, EventArgs e)
        {
            userText = this.usernameText.Text;
            pwdText = this.passwordText.Text;
            if (!userText.Equals(string.Empty) && !pwdText.Equals(string.Empty))
            {
                this.credentialsInvalidText.Visible = false;
                //TODO: Check the userText against the database to see if there is an 
                //      account with that user name and then check the password if there is.
                //for now the code will check to see if the user is test and password is test.
                if (userText.Equals("test"))
                {
                    if (pwdText.Equals("test"))
                    {
                        Console.WriteLine(DateTime.Now + ": Login Succeeded, User: " + testUser.getUsername());
                        application.Show();
                        this.Hide();
                    }
                    else
                    {
                        Console.WriteLine(DateTime.Now + ": Login Credentials Invalid:");
                        this.credentialsInvalidText.Text = "Password is incorrect";
                        this.credentialsInvalidText.Visible = true;
                    }
                }
                else
                {
                    Console.WriteLine(DateTime.Now + ": Username Invalid:");
                    this.credentialsInvalidText.Text = "Username not recognized";
                    this.credentialsInvalidText.Visible = true;
                }
            }
            else
            {
                Console.WriteLine(DateTime.Now + ": Login Credentials Invalid:");
                this.credentialsInvalidText.Visible = true;
            }
        }
        #endregion

        #endregion
    }
}
