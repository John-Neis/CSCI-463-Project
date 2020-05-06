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
using System.Windows.Forms.DataVisualization.Charting;

namespace MoneyHub_User_Interface
{
    public partial class MoneyHubForm : Form
    {
        #region define global variables
        //used for testing, 1 is dev mode, 0 is production.
        static int mode = 0;
        //creation of login instance for startup
        static Login login = new Login();
        //creation of the account creation state 
        static accountCreator accountCreator = new accountCreator();
        static WelcomeForm wf = new WelcomeForm();
        static Navigator menu = new Navigator();
        static Overview ov = new Overview();

        //Jack's IP
        public byte[] ip = { 192, 168, 0, 15 };
        //Sam's IP
        //public byte[] ip = { 192, 168, 254, 20 };
        public int port = 1338;
        public IPAddress ipAddr;
        public IPEndPoint localEndPoint;
        public Socket sender;

        static UserAccount currentUser = new UserAccount();
        string currentPage = "overview";
        //int numberOfUsers = 0;
        #endregion
        public MoneyHubForm()
        {
            InitializeComponent();
            startup();
        }
        #region Startup function
        public void startup()
        {
            try
            {
                ipAddr = new IPAddress(ip);
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
                    Console.WriteLine(DateTime.Now + ": (ERROR) Connection Failed, Server May be Down!");
                    Console.WriteLine("Socket exception : {0}", se.ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Unexpected exception : {0}", e.ToString());
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine(e.ToString());
            }
            //Add forms to MH Client
            this.upperSideBasePanel.Controls.Add(login.loginPanel);
            this.MoneyHubContentPanel.Controls.Add(wf.welcomeFormBasePanel);
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
            //int tempNumber;

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
                /*for (int i = 0; i < numberOfUsers; i++)
                {
                    //if (users[i].username == temp)
                    //{
                        //accountCreator.invalid_username_flag.Visible = true;
                        //fieldInvalid = true;
                        //posibly add a message for this error in specific

                    //}
                }*/
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
            Console.WriteLine(DateTime.Now + ": Pre-Login");
            validateUser();   
        }
        private void validateUser()
        { 
            string uname = login.usernameTextBox.Text.Trim(' ');
            string pwd = login.passwordTextBox.Text.Trim(' ');
            string serverMsg;
            Console.WriteLine(DateTime.Now + ": Attempting to validate user: \"" + uname + "\" ...");
            //UserAccount[] users = currentUsers.ToArray();
            //int currentUserIndex = 0;
            String reply = string.Empty;
            if (!string.IsNullOrEmpty(uname) && !string.IsNullOrEmpty(pwd))
            {
                // Message code: 1
                serverMsg = "1 " + uname + " " + pwd + "\n";

                // Creation of message that
                // we will send to Server
                byte[] messageSent = Encoding.ASCII.GetBytes(serverMsg);
                try
                {
                    int byteSent = sender.Send(messageSent);
                    byte[] messageReceived = new byte[1024];
                    int byteRecv = sender.Receive(messageReceived);
                    reply = Encoding.ASCII.GetString(messageReceived, 0, byteRecv);
                    /*
                        Note: The reply from the server follows a strict format.
                        The first byte will be either 0 or 1. (1 is assuming database integrity)
                        Each subsequent value will be delimited by ':'
                        Database column names will be followed by "->", and the value of that records column will proceed.
                        The final value of the string will be "NULL".
                        In the case that the first byte is 0, the reply from the server will always be "0:NULL".
                        This will indicate a bad login, and will be used to prompt the user to reenter their information.
                     */
                    //pares server response
                    char[] response = reply.ToCharArray();
                    Console.WriteLine(DateTime.Now + ": Server Reply: " + reply);
                    if (response[0] == '1')
                    {
                        Console.WriteLine(DateTime.Now + ": Login Attempt Succeeded");
                        currentUser.Username = uname;
                        currentUser.NetWorth = 10345.23;
                        //Don't set the password in the currentUser's userAccount object since its not needed

                        loginValidated();
                    }
                    else
                    {
                        Console.WriteLine(DateTime.Now + ": Login Attempt Failed");
                        login.usernamePasswordInvalidText.Visible = true;
                    }
                }
                catch(SocketException se)
                {
                    Console.WriteLine(DateTime.Now + ": (ERROR) Connection Failed, Server May be Down!");
                    Console.WriteLine(se.ToString());
                    login.usernamePasswordInvalidText.Visible = true;
                }
            }
            //If one of the fields are empty say login attempt is invalid invalid 
            else
            {
                Console.WriteLine(DateTime.Now + ": Login Attempt Failed: \"NULL\" username or Password");
                login.usernamePasswordInvalidText.Visible = true;
            }
        }
        private void loginValidated()
        {
            
            login.usernamePasswordInvalidText.Visible = false;
            login.loginPanel.Visible = false;
            if (login.remeberUserCheckBox.CheckState == CheckState.Unchecked)
            {
                login.usernameTextBox.Text = string.Empty;
                login.passwordTextBox.Text = string.Empty;
            }
            login.loginPanel.Visible = false;
            this.upperSideBasePanel.Controls.Add(menu.navPanel);
            menu.navPanel.Visible = true;
            this.welcomeUserLabel.Visible = true;
            this.logoutPictureBox.Visible = true;
            this.welcomeUserLabel.Text = "Welcome Back, " + currentUser.Username;
            showOverviewPanel();
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
            Console.WriteLine(DateTime.Now + ": Logging Out Current User");
            this.logoutPictureBox.Visible = false;
            this.welcomeUserLabel.Visible = false;
            menu.navPanel.Visible = false;
            login.loginPanel.Visible = true;
            this.MoneyHubContentPanel.Controls.Clear();
            this.MoneyHubContentPanel.Controls.Add(wf.welcomeFormBasePanel);          
        }
        #endregion

        #region Show Overview 
        public void generateNetWorthChart()
        {
            //xvalues for dates
            List<DateTime> xValues = new List<DateTime>();
            //yvalues for dollar values
            List<double> yValues = new List<double>();
            xValues.Add(new DateTime(2017, 3, 18));
            yValues.Add(5040.32);

            xValues.Add(new DateTime(2018, 1, 8));
            yValues.Add(1473.91);
            
            xValues.Add(new DateTime(2018, 12, 24));
            yValues.Add(378.27);
            
            xValues.Add(new DateTime(2019, 8, 14));
            yValues.Add(3421.10);
            
            xValues.Add(new DateTime(2019, 10, 4));
            yValues.Add(1400.85);
            
            xValues.Add(new DateTime(2019, 12, 20));
            yValues.Add(4340.54);

            xValues.Add(new DateTime(2020, 4, 5));
            yValues.Add(6340.30);
            currentUser.NetWorthX = xValues;
            currentUser.NetWorthY = yValues;
            //One year worth of data is default
            setOneYearScaling();
        }
        public void setOneYearScaling()
        {
           // List<DateTime> x = currentUser.NetWorthX;
           // List<double> y = currentUser.NetWorthY;
            ////To get just the recent year values, take the current date and compare it to each of the dates
            //// in the given list
           // DateTime currentDate = DateTime.Now;
           // Console.WriteLine("Current Date: "+currentDate);
            //Console.WriteLine("Date we are plotting from then on: "+currentDate.AddYears(-1));
            //List<DateTime> tempx = new List<DateTime>();
            //List<Double> tempy = new List<double>();
            //for (int i = 0; i < tempx.Count; i++)
            //{
            //    Console.WriteLine(i);
            //    Console.WriteLine("here");
            //    Console.WriteLine(x[i]);
            //    Console.WriteLine(y[i]);
            //    if (x[i].CompareTo(currentDate.AddYears(-1)) >= 0)
            //    {
            //        tempx.Add(x[i]);
            //        tempy.Add(y[i]);
            //    }
            //}
            ov.netWorthChart.Series["NetWorth"].Points.DataBindXY(currentUser.NetWorthX, currentUser.NetWorthY);
            ov.netWorthChart.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.DarkRed;
            ov.netWorthChart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.DarkRed;
            ov.netWorthChart.Series["NetWorth"].Color = Color.FromArgb(20,40,60);
            ov.netWorthChart.ChartAreas[0].AxisX.Interval = 3.0;
            ov.netWorthChart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Months;
            ov.netWorthChart.ChartAreas[0].AxisX.LabelStyle.Format = "MM/dd/yyyy";
            ov.netWorthChart.Invalidate();
        }
        public void showOverviewPanel()
        {
            currentPage = "overview";
            this.MoneyHubContentPanel.Controls.Clear();
            this.MoneyHubContentPanel.Controls.Add(ov.overviewBasePanel);
            ov.netWorthValue.Text = "$" + currentUser.NetWorth.ToString();
            generateNetWorthChart();
            Console.WriteLine("here");
        }
        #endregion
        #region Show Accounts 
        public void showAccountsPanel()
        {
            currentPage = "accounts";
            this.MoneyHubContentPanel.Controls.Clear();
            //this.appBasePanel.Controls.
        }
        #endregion
        #region Show settings
        public void showSettingsPanel()
        {
            currentPage = "settings";
            this.MoneyHubContentPanel.Controls.Clear();
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
