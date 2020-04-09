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
        
        List <UserAccount> currentUsers = new List<UserAccount>();
        static UserAccount currentUser;
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
                currentUser = test;
                currentUsers.Add(test);
                numberOfUsers++;
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
            this.upperSideBasePanel.Controls.Add(accountCreator.accountCreatorPanel);
            accountCreator.accountCreatorPanel.Visible = true; 
            login.loginPanel.Visible = false;
        }
        public void generateAccount()
        {
            validateFields();
            //add the function to generate the userID 31800000, 31800001
        }
        //Validate Fields:
        //Function checks each of the fields in the account creator window
        //Any fields that are empty will cause the field invalid flag to be set as
        //well as the flag for that individual field.
        private void validateFields()
        {
            accountCreator.clearFlags();
            bool fieldInvalid = false;
            string temp;
            string temp2;
            int tempNumber;
            //username: invalid if username exists
            UserAccount[] users = currentUsers.ToArray();
            temp = accountCreator.usernameTextBox.Text;
            if (string.IsNullOrEmpty(temp))
            {
                accountCreator.invalid_username_flag.Visible = true;
                fieldInvalid = true;
            }
            else
            {
                for (int i = 0; i < numberOfUsers; i++)
                {
                    if (users[i].username == temp)
                    {
                        accountCreator.invalid_username_flag.Visible = true;
                        fieldInvalid = true;
                        //posibly add a message for this error in specific

                    }
                }
            }
            //end username

            //firstname: must be a string
            temp = accountCreator.firstnameTextBox.Text;
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
             validateUser();   
            
        }
        private void validateUser()
        {
            string uname = login.usernameTextBox.Text.Trim(' ');
            string pwd = login.passwordTextBox.Text.Trim(' ');
            bool usernameValid = false;
            bool pwdValid = false;
            UserAccount[] users = currentUsers.ToArray();
            int currentUserIndex = 0;
            if(!string.IsNullOrEmpty(uname))
            {
                for (int i = 0; i < users.Length; i++)
                {
                    if (users[i].username == uname)
                    {
                        usernameValid = true;
                        currentUserIndex = i;
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
                            currentUserIndex = i;
                            login.usernamePasswordInvalidText.Visible = false;
                        }
                    }
                    if(pwdValid == false)
                    {
                        login.usernamePasswordInvalidText.Visible = true;
                    }
                }
                else
                {
                    login.usernamePasswordInvalidText.Visible = true;
                }
            }
            else
            {
                login.usernamePasswordInvalidText.Visible = true;
            }
            if(pwdValid == true && usernameValid == true)
            {
                currentUser = users[currentUserIndex];
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
            this.welcomeUserLabel.Text = "Welcome Back, " + currentUser.userFirstName;
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
