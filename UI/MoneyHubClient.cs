using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Text;

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
        static Navigator menu = new Navigator();

        public byte[] ip = { 24, 220, 156, 95 };
        public int port = 1338;
        public IPAddress ipAddr;
        public IPEndPoint localEndPoint;
        public Socket sender;

        //List <UserAccount> currentUsers = new List<UserAccount>();
        //static UserAccount currentUser;
        int numberOfUsers = 0;
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
                test.isAdmin = true;
                //currentUser = test;
                //currentUsers.Add(test);
                numberOfUsers++;

                try
                {

                    ipAddr = new IPAddress(ip);
                    //Console.WriteLine(ipAddr.ToString());
                    localEndPoint = new IPEndPoint(ipAddr, port);

                    sender = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                    //Console.WriteLine(localEndPoint.Address);

                    try
                    {
                        // Connect Socket to the remote
                        // endpoint using method Connect()
                        sender.Connect(localEndPoint);
                        // We print EndPoint information
                        // that we are connected
                        Console.WriteLine("Socket connected to -> {0}", sender.RemoteEndPoint.ToString());

                    }
                    catch (ArgumentNullException ane)
                    {
                        Console.WriteLine("Argument null exception : {0}", ane.ToString());
                    }
                    catch (SocketException se)
                    {
                        Console.WriteLine("Socket exception : {0}", se.ToString());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Unexpected exception : {0}", e.ToString());
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }


            }
            else
            {            
                //do something else or nothing for normal usage
               
            }
            //common stuff to do on startup.
            this.upperSideBasePanel.Controls.Add(login.loginPanel);
            //ON STARTUP: fill the currentUsers list with results from the database 
        }
        #endregion

        #region Create new Account
        //This function switches the left panel to the account creation screen
        public void createAccount()
        {
            this.upperSideBasePanel.Controls.Add(accountCreator.accountCreatorPanel);
            accountCreator.accountCreatorPanel.Visible = true; 
            login.loginPanel.Visible = false;

        }
        //once the user enters the information for the new account, the fields are validated.
        public void generateAccount()
        {
            Console.WriteLine("Attempt to Create");
            validateFields();
            //add the function to generate the userID 31800000, 31800001
        }
        //Validate Fields:
        //Function checks each of the fields in the account creator window
        //Any fields that are empty will cause the overall invalid flag to be set as
        //well as the flag for that individual field.
        private void validateFields()
        {
            accountCreator.clearFlags();
            bool fieldInvalid = false;
            string temp;
            string temp2;
            int tempNumber;

            string user = "";
            string pwd = "";
            string fname = "";
            string lname = "";
            //username: invalid if username exists
            //UserAccount[] users = currentUsers.ToArray();
            temp = accountCreator.usernameTextBox.Text;
            user = temp;
            if (string.IsNullOrEmpty(temp))
            {
                accountCreator.invalid_username_flag.Visible = true;
                fieldInvalid = true;
            }
            else
            {
                //TODO: this will need to be changed to send the new username to the database to see if it exists
                for (int i = 0; i < numberOfUsers; i++)
                {
                    //if (users[i].username == temp)
                    //{
                        //accountCreator.invalid_username_flag.Visible = true;
                        //fieldInvalid = true;
                        //posibly add a message for this error in specific

                    //}
                }
            }
            //end username

            //firstname: must be a string
            temp = accountCreator.firstnameTextBox.Text;
            fname = temp;
            if (string.IsNullOrEmpty(temp)) 
            { 
                accountCreator.invalid_firstname_flag.Visible = true; 
                fieldInvalid = true; 
            }
            else
            {
                if (isAlpha(temp) == false)
                {
                    accountCreator.invalid_firstname_flag.Visible = true;
                    fieldInvalid = true;
                }
            }
            //end firstname
            //lastname: must be a string
            temp = accountCreator.lastnameTextBox.Text;
            lname = temp;
            if (string.IsNullOrEmpty(temp))
            {
                accountCreator.invalid_lastname_flag.Visible = true;
                fieldInvalid = true;
            }
            else
            {
                if (isAlpha(temp) == false)
                {
                    accountCreator.invalid_lastname_flag.Visible = true;
                    fieldInvalid = true;
                }

            }
            //end lastname
            //validate email: 
            temp = accountCreator.emailTextBox.Text;
            if (string.IsNullOrEmpty(temp))
            {
                accountCreator.invalid_email_flag.Visible = true;
                fieldInvalid = true;
            }
            else
            {
                //check if this field fits a regex
            }
            //end email
            //validate phonenumber
            temp = accountCreator.phoneNumberTextBox.Text;
            if(string.IsNullOrEmpty(temp))
            {
                accountCreator.invalid_phonenumber_flag.Visible = true;
                fieldInvalid = true;
            }
            else
            {
                //check if the phone number is valid
            }
            //end phone number
            //validate password
            temp = accountCreator.passwordTextBox.Text;
            pwd = temp;
            if (string.IsNullOrEmpty(temp))
            {
                accountCreator.invalid_password_flag.Visible = true;
                fieldInvalid = true;
            }
            else
            {
                //validate password
            }
            //confirm the second password is the same as the first password
            temp2 = accountCreator.confirmPasswordTextBox.Text;
            if (string.IsNullOrEmpty(temp2))
            {
                accountCreator.invalid_password2_flag.Visible = true;
                fieldInvalid = true;
            }
            else
            {
                //validate password2
            }
            

            //Check if any of the fields are invalid and then display the message
            if (fieldInvalid == true)
            {
                accountCreator.invalidFieldsLabel.Visible = true;
            }
            else
            {
            }

            // Message code: 0
            string serverMessage = "0 " + user + " " + pwd + " " + fname + " " + lname + "\n";
            Console.WriteLine(serverMessage);
            byte[] messageSent = Encoding.ASCII.GetBytes(serverMessage);
            int byteSent = sender.Send(messageSent);
        }
        #region Event if account creation is cancelled
        public void cancelAccountCreation()
        {
            wait(100);
            if (login.remeberUserCheckBox.CheckState == CheckState.Unchecked)
            {
                login.usernameTextBox.Text = string.Empty;
                login.passwordTextBox.Text = string.Empty;
            }
            accountCreator.accountCreatorPanel.Visible = false;
            login.loginPanel.Visible = true;
        }
        #endregion
        #endregion
        
        #region Log user in
        public void logUserIn()
        {
            Console.WriteLine("Pre-login");
            validateUser();   
        }
        private void validateUser()
        {

            string uname = login.usernameTextBox.Text.Trim(' ');
            string pwd = login.passwordTextBox.Text.Trim(' ');
            string serverMsg;

            bool usernameValid = false;
            bool pwdValid = false;
            //UserAccount[] users = currentUsers.ToArray();
            //int currentUserIndex = 0;
            if (!string.IsNullOrEmpty(uname))
            {
                // Message code: 1
                serverMsg = "1 " + uname + " " + pwd + "\n";

                // Creation of message that
                // we will send to Server
                byte[] messageSent = Encoding.ASCII.GetBytes(serverMsg);
                int byteSent = sender.Send(messageSent);

                byte[] messageReceived = new byte[1024];
                int byteRecv = sender.Receive(messageReceived);
                string reply = Encoding.ASCII.GetString(messageReceived, 0, byteRecv);

                /*
                    Note: The reply from the server follows a strict format.
                    The first byte will be either 0 or 1. (1 is assuming database integrity)
                    Each subsequent value will be delimited by ':'
                    Database column names will be followed by "->", and the value of that records column will proceed.
                    The final value of the string will be "NULL".
                    In the case that the first byte is 0, the reply from the server will always be "0:NULL".
                    This will indicate a bad login, and will be used to prompt the user to reenter their information.
                 */

                Console.WriteLine("From Server: " + reply);
            }
            else
            {
                login.usernamePasswordInvalidText.Visible = true;
            }
            if (pwdValid == true && usernameValid == true)
            {
                //currentUser = users[currentUserIndex];
                Console.WriteLine(DateTime.Now + ": Login validated!");
                login.loginPanel.Visible = false;
                loginValidated();
            }
        }
        private void loginValidated()
        {
            if(login.remeberUserCheckBox.CheckState == CheckState.Unchecked)
            {
                login.usernameTextBox.Text = string.Empty;
                login.passwordTextBox.Text = string.Empty;
            }
            login.loginPanel.Visible = false;
            this.upperSideBasePanel.Controls.Add(menu.navPanel);
            menu.navPanel.Visible = true;
            this.welcomeUserLabel.Visible = true;
            this.logoutPictureBox.Visible = true;
            //this.welcomeUserLabel.Text = "Welcome Back, " + currentUser.userFirstName;
        }

        #endregion

        #region Log user out
        private void logoutPictureBox_Click(object sender, EventArgs e)
        {
            const string message = "Are you sure you want to log out?";
            const string caption = "Log Out";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LogUserOut();
            }
        }
        public void LogUserOut()
        {
            this.logoutPictureBox.Visible = false;
            this.welcomeUserLabel.Visible = false;
            menu.navPanel.Visible = false;
            login.loginPanel.Visible = true;
        }
        #endregion

        #region utility
        private void wait(int time)
        {
            //time to wait in Milliseconds
            Task.Delay(time).Wait();
        }
        private bool isAlpha(String strToCheck)
        {
            Regex objAlphaPattern = new Regex("[a-zA-Z]+");
            return objAlphaPattern.IsMatch(strToCheck);
        }
        //Minimize the form
        private void minimizePictureBox_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

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

        #endregion


    }
}
