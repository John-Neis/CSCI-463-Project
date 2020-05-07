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
        //static int mode = 0;
        //creation of login instance for startup
        static Login login = new Login();
        //creation of the account creation state 
        public static accountCreator accountCreator = new accountCreator();
        public static WelcomeForm wf = new WelcomeForm();
        public static Navigator menu = new Navigator();
        public static Overview ov = new Overview();
        public static AccountCreatedForm acf = new AccountCreatedForm();
        public static NetWorthHistoryForm nwhf = new NetWorthHistoryForm();
        public static NetWorthBreakDownForm nwbdf = new NetWorthBreakDownForm();
        public static AccountSummaryForm asf = new AccountSummaryForm();
        public static SettingsForm sf = new SettingsForm();
        //Jack's IP
        //public byte[] ip = { 192, 168, 0, 15 };
        //Sam's IP
        public byte[] ip = { 192, 168, 254, 20 };
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
            Console.WriteLine(DateTime.Now+": Attemping to create account");
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
            bool fieldsInvalid = false;
            string tempString;
            string temp2;
            //int tempNumber;

            string user;
            string pwd;
            string fname ;
            string lname;
            //username: invalid if username exists
            //UserAccount[] users = currentUsers.ToArray();
            tempString = accountCreator.usernameTextBox.Text;
            user = tempString;
            if (string.IsNullOrEmpty(tempString))
            {
                accountCreator.invalid_username_flag.Visible = true;
                fieldsInvalid = true;
            }
            //end username

            //firstname: must be a string
            tempString = accountCreator.firstnameTextBox.Text;
            fname = tempString;
            if (string.IsNullOrEmpty(tempString)) 
            { 
                accountCreator.invalid_firstname_flag.Visible = true; 
                fieldsInvalid = true; 
            }
            else
            {
                if (isAlpha(tempString) == false)
                {
                    accountCreator.invalid_firstname_flag.Visible = true;
                    fieldsInvalid = true;
                }
            }
            //end firstname
            //lastname: must be a string
            tempString = accountCreator.lastnameTextBox.Text;
            lname = tempString;
            if (string.IsNullOrEmpty(tempString))
            {
                accountCreator.invalid_lastname_flag.Visible = true;
                fieldsInvalid = true;
            }
            else
            {
                if (isAlpha(tempString) == false)
                {
                    accountCreator.invalid_lastname_flag.Visible = true;
                    fieldsInvalid = true;
                }

            }
            //end lastname
            //validate email: 
            tempString = accountCreator.emailTextBox.Text;
            if (string.IsNullOrEmpty(tempString))
            {
                accountCreator.invalid_email_flag.Visible = true;
                fieldsInvalid = true;
            }
            else
            {
                //check if this field fits a regex
            }
            //end email
            //validate phonenumber
            tempString = accountCreator.phoneNumberTextBox.Text;
            if(string.IsNullOrEmpty(tempString))
            {
                accountCreator.invalid_phonenumber_flag.Visible = true;
                fieldsInvalid = true;
            }
            else
            {
                //check if the phone number is valid
            }
            //end phone number
            //validate password
            tempString = accountCreator.passwordTextBox.Text;
            temp2 = accountCreator.confirmPasswordTextBox.Text;
            pwd = tempString;
            if (string.IsNullOrEmpty(tempString) || string.IsNullOrEmpty(temp2))
            {
                accountCreator.invalid_password_flag.Visible = true;
                accountCreator.invalid_password2_flag.Visible = true;
                fieldsInvalid = true;
            }
            else
            {
                //confirm the second password is the same as the first password
                if (!tempString.Equals(temp2))
                {
                    accountCreator.invalid_password_flag.Visible = true;
                    accountCreator.invalid_password2_flag.Visible = true;
                    fieldsInvalid = true;
                }
            }
            

            //Check if any of the fields are invalid and then display the message
            if (fieldsInvalid == true)
            {
                accountCreator.invalidFieldsLabel.Visible = true;
            }
            //If none of the fields are invalid, send a request to the database
            else
            {
                // Message code: 0 - Meaning the request is to add a user to the users database;
                string serverMessage = "0 " + user + " " + pwd + " " + fname + " " + lname + "\n";
                Console.WriteLine(serverMessage);
                byte[] messageSent = Encoding.ASCII.GetBytes(serverMessage);
                int byteSent = sender.Send(messageSent);
                byte[] messageReceived = new byte[1024];
                int byteRecv = sender.Receive(messageReceived);
                string reply = Encoding.ASCII.GetString(messageReceived, 0, byteRecv);
                char[] response = reply.ToCharArray();
                Console.WriteLine(DateTime.Now + ": Server Reply: " + reply);
                if (response[0] == '1')
                {
                    Console.WriteLine(DateTime.Now + ": Account Created Succssefully!");
                    accountCreationSucceeded();
                }
                else
                {
                    Console.WriteLine(DateTime.Now + ": Account Creation Failed!");
                    login.usernamePasswordInvalidText.Visible = true;
                }
            }

        }
        #region Acount Created Successfully
        public void accountCreationSucceeded()
        {
            this.upperSideBasePanel.Controls.Clear();
            this.upperSideBasePanel.Controls.Add(acf.accountCreatedBaseTLPanel);
            acf.accountCreatedBaseTLPanel.Visible = true;
        }
        #endregion
        #region show login panel function
        public void showLogin()
        {
            this.upperSideBasePanel.Controls.Clear();
            this.upperSideBasePanel.Controls.Add(login.loginPanel);
            login.loginPanel.Visible = true;
        }
        #endregion
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
            loadUserAccounts();
            showOverviewPanel();
        }
        #endregion

        #region load user Accounts form DB
        public void loadUserAccounts()
        {
            List<Account> accounts = new List<Account>();
            Account a1 = new Account(123, 3500, "Checking");//checking
            Account a2 = new Account(123, 10500, "Savings"); //savings
            Account a3 = new Account(123, 3654.31, "Loan");//loan
            accounts.Add(a1);
            accounts.Add(a2);
            accounts.Add(a3);
            currentUser.Accounts = accounts;
            currentUser.NetWorth = 10345.69;
            currentUser.TotalAssets = a1.Balance + a2.Balance;
            currentUser.TotalLiabilities = a3.Balance;
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

        #region Relating to Overview 
        public void showOverviewPanel()
        {
            currentPage = "overview";
            this.MoneyHubContentPanel.Controls.Clear();
            this.MoneyHubContentPanel.Controls.Add(ov.overviewBasePanel);
            populateOverviewFields();
            showNetWorthHistory();
            generateNetWorthChart();       
            generateNetWorthStats();
        }
        public void populateOverviewFields()
        {
            //start with account fields 
            List<Account> accounts = currentUser.Accounts;
            for(int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].AccountType.Equals("Checking"))
                {
                    ov.checkingAccountBalanceValue.Text = "$ " + accounts[i].Balance;
                    nwbdf.checkingAccountBalanceValue.Text = "$ " + accounts[i].Balance;
                }
                else if (accounts[i].AccountType.Equals("Savings"))
                {
                    ov.SavingsAccountBalanceValue.Text = "$ " + accounts[i].Balance;
                    nwbdf.savingsAccountBalanceValue.Text = "$ " + accounts[i].Balance;
                }
                else if (accounts[i].AccountType.Equals("Loan"))
                {
                    ov.loanBalanceValue.Text = "$ " + accounts[i].Balance;
                    nwbdf.loanAccountBalanceValue.Text = "$ " + accounts[i].Balance;
                }
            }
            //fill the total asset field
            nwbdf.totalNetWorthValue.Text = "$ " + currentUser.NetWorth;
            nwbdf.totalAssetsValue.Text = "$ " + currentUser.TotalAssets;
             
        }
        public void generateNetWorthChart()
        {
            //xvalues for dates
            List<DateTime> xValues = new List<DateTime>();
            //yvalues for dollar values
            List<double> yValues = new List<double>();

            xValues.Add(new DateTime(2014, 11, 6));
            yValues.Add(543.17);

            xValues.Add(new DateTime(2015, 4, 20));
            yValues.Add(834.69);

            xValues.Add(new DateTime(2016, 8, 23));
            yValues.Add(1465.96);

            xValues.Add(new DateTime(2017, 3, 18));
            yValues.Add(2040.32);

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

            xValues.Add(DateTime.Today);
            yValues.Add(currentUser.NetWorth);
            
            currentUser.NetWorthX = xValues;
            currentUser.NetWorthY = yValues;
            //One year worth of data is default
            setOneYearScaling();
        }
        #region Scaling Options for Chart
        public void setOneYearScaling()
        {
            List<DateTime> x = currentUser.NetWorthX;
            List<double> y = currentUser.NetWorthY;
            //To get just the recent year values, take the current date and compare it to each of the dates
            // in the given list
            DateTime currentDate = DateTime.Now;
            List<DateTime> tempx = new List<DateTime>();
            List<Double> tempy = new List<double>();
            int timeDiff = 0;
            for(int i=0; i< x.Count; i++)
            {
                timeDiff = GetMonthsBetween(x[i], DateTime.Today);
                if ( timeDiff <= 12)
                {
                    tempx.Add(x[i]);
                    tempy.Add(y[i]);
                }
            }
            nwhf.netWorthLineChart.Series["NetWorth"].Points.DataBindXY(tempx,tempy);

            nwhf.netWorthLineChart.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.DarkRed;
            nwhf.netWorthLineChart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.DarkRed;
            nwhf.netWorthLineChart.Series["NetWorth"].Color = Color.FromArgb(20,40,60);
            nwhf.netWorthLineChart.ChartAreas[0].AxisX.IsMarginVisible = false;
            nwhf.netWorthLineChart.ChartAreas[0].AxisX.Interval = 1.0;
            nwhf.netWorthLineChart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Months;
            nwhf.netWorthLineChart.ChartAreas[0].AxisX.LabelStyle.Format = "MM/dd/yyyy";
            nwhf.netWorthLineChart.Invalidate();
        }
        public void setThreeYearScaling()
        {
            List<DateTime> x = currentUser.NetWorthX;
            List<double> y = currentUser.NetWorthY;
            //To get just the recent year values, take the current date and compare it to each of the dates
            // in the given list
            DateTime currentDate = DateTime.Now;
            List<DateTime> tempx = new List<DateTime>();
            List<Double> tempy = new List<double>();
            int timeDiff = 0;
            for (int i = 0; i < x.Count; i++)
            {
                timeDiff = GetMonthsBetween(x[i], DateTime.Today);
                if (timeDiff <= 36)
                {
                    tempx.Add(x[i]);
                    tempy.Add(y[i]);
                }
            }
            nwhf.netWorthLineChart.Series["NetWorth"].Points.DataBindXY(tempx, tempy);

            nwhf.netWorthLineChart.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.DarkRed;
            nwhf.netWorthLineChart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.DarkRed;
            nwhf.netWorthLineChart.Series["NetWorth"].Color = Color.FromArgb(20, 40, 60);
            nwhf.netWorthLineChart.ChartAreas[0].AxisX.IsMarginVisible = false;
            nwhf.netWorthLineChart.ChartAreas[0].AxisX.Interval = 2.0;
            nwhf.netWorthLineChart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Months;
            nwhf.netWorthLineChart.ChartAreas[0].AxisX.LabelStyle.Format = "MM/dd/yyyy";
            nwhf.netWorthLineChart.Invalidate();
        }
        public void setAllTimeScaling()
        {
            nwhf.netWorthLineChart.Series["NetWorth"].Points.DataBindXY(currentUser.NetWorthX, currentUser.NetWorthY);

            nwhf.netWorthLineChart.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.DarkRed;
            nwhf.netWorthLineChart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.DarkRed;
            nwhf.netWorthLineChart.Series["NetWorth"].Color = Color.FromArgb(20, 40, 60);
            nwhf.netWorthLineChart.ChartAreas[0].AxisX.IsMarginVisible = false;
            nwhf.netWorthLineChart.ChartAreas[0].AxisX.Interval = 3.0;
            nwhf.netWorthLineChart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Months;
            nwhf.netWorthLineChart.ChartAreas[0].AxisX.LabelStyle.Format = "MM/dd/yyyy";
            nwhf.netWorthLineChart.Invalidate();
        }
        #endregion
        #region Generate NetWorthHistoryStats
        public void generateNetWorthStats()
        {
            double currentNetWorth = currentUser.NetWorth;
            List<DateTime> dates = currentUser.NetWorthX;
            List<double> values = currentUser.NetWorthY;
            //Need to set: 1. Date started tracking NetWorth, 2. Time Since then, 3. NetWorth Gains/Losses since first date, 4. Avg Yearly growth %/yr 
            //5. Minimum Net Worth, 6. Maximum Net Worth;
            //Start Date
            nwhf.startDateValue.Text = dates[0].Month.ToString()+"/"+dates[0].Day.ToString()+"/"+dates[0].Year.ToString();
            //time since then
            int temp = GetMonthsBetween(dates[0], DateTime.Today);
            int monthsElapsed = temp % 12;
            int yearsElapsed = temp / 12;
            nwhf.timeElapsedValue.Text = yearsElapsed+" Years "+monthsElapsed +" Months";
            //calc Gains or Losses
            double startAmount = values[0];
            double difference = currentUser.NetWorth - startAmount;
            if (difference > 0)
            {
                nwhf.totalNetWorthGrowthValue.Text = "$ " + difference;
            }
            else
            {
                nwhf.totalNetWorthGrowthValue.Text = "$ -" + difference;
            }
            //Find avg yearly difference
            nwhf.averageGrowthValue.Text = "$ " + (difference / yearsElapsed)+"/yr";
            //find min and find max
            double max = values[0];
            double min = values[0];
            DateTime minDate = dates[0];
            DateTime maxDate = dates[0];
            for(int i = 0; i < dates.Count; i++)
            {
                if (values[i] < min)
                {
                    min = values[i];
                    minDate = dates[i];
                }
                if(values[i]> max)
                {
                    max = values[i];
                    maxDate = dates[i];
                }
            }
            nwhf.maxNetWorthValue.Text = "$ " + max;
            nwhf.minNetWorthValue.Text = "$ " + min;
            nwhf.minNetWorthDate.Text = minDate.Month.ToString() + "/" + minDate.Day.ToString() + "/" + minDate.Year.ToString();
            nwhf.maxNetWorthDate.Text = maxDate.Month.ToString() + "/" + maxDate.Day.ToString() + "/" + maxDate.Year.ToString();
        }
        #endregion
        #region Show the NetWorth Breakdown
        public void showNetWorthBreakDown()
        {
            nwbdf.netWorthValue.Text = "$" + currentUser.NetWorth.ToString();
            ov.overviewContentBasePanel.Controls.Clear();
            ov.overviewContentBasePanel.Controls.Add(nwbdf.netWorthBreakDownBasePanel);
        }
        #endregion
        #region Show Net Worth History
        public void showNetWorthHistory()
        {
            nwhf.netWorthValue.Text = "$" + currentUser.NetWorth.ToString();
            ov.overviewContentBasePanel.Controls.Clear();
            ov.overviewContentBasePanel.Controls.Add(nwhf.netWorthHistoryBasePanel);
        }
        #endregion
        #endregion

        #region Show Accounts 
        public void showAccountsPanel()
        {
            currentPage = "accounts";
            this.MoneyHubContentPanel.Controls.Clear();
            this.MoneyHubContentPanel.Controls.Add(asf.accountSummaryBasePanel);
            generateDoughnutChart();
        }
        public void generateDoughnutChart()
        {

            List<Account> accounts = currentUser.Accounts;
            List<String> assetAccountTypes = new List<string>();
            List<double> assetAccountBalances = new List<double>();
            List<String> liabilityAccountTypes = new List<string>();
            List<double> liabilityAccountBalances = new List<double>();
            for (int i = 0; i < accounts.Count; i++)
            {
                if (!accounts[i].AccountType.Equals("Loan"))
                {
                    assetAccountTypes.Add(accounts[i].AccountType);
                    assetAccountBalances.Add(accounts[i].Balance);
                }
                else
                {
                    liabilityAccountTypes.Add(accounts[i].AccountType);
                    liabilityAccountBalances.Add(accounts[i].Balance);
                }
            }
             asf.assetDoughnutChart.Series["Assets"].IsValueShownAsLabel = true;
             asf.assetDoughnutChart.Series["Assets"].Points.DataBindXY(assetAccountTypes, assetAccountBalances);
            asf.liabilityDoughnutChart.Series["Liabilities"].IsValueShownAsLabel = true;
            asf.liabilityDoughnutChart.Series["Liabilities"].Points.DataBindXY(liabilityAccountTypes, liabilityAccountBalances);
            //nwbdf.netWorthDoughnutChart.Series["Net Worth"].Points.AddXY("Checking", (currentUser.NetWorth - 3500.43));
            // nwbdf.netWorthDoughnutChart.Series["Net Worth"].Points.AddXY("Checking", (-3500.43 + currentUser.NetWorth));
        }
        #endregion

        #region Show settings
        public void showSettingsPanel()
        {
            currentPage = "settings";
            this.MoneyHubContentPanel.Controls.Clear();
            this.MoneyHubContentPanel.Controls.Add(sf.settingsFormBasePanel);
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
        #region get months between two dates
        public static int GetMonthsBetween(DateTime from, DateTime to)
        {
            if (from > to) return GetMonthsBetween(to, from);

            var monthDiff = Math.Abs((to.Year * 12 + (to.Month - 1)) - (from.Year * 12 + (from.Month - 1)));

            if (from.AddMonths(monthDiff) > to || to.Day < from.Day)
            {
                return monthDiff - 1;
            }
            else
            {
                return monthDiff;
            }
        }
        #endregion
        #endregion
    }
}
