﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyHub_User_Interface
{

    class UserAccount
    {
        private string _username = string.Empty;
        private string _userPassword = string.Empty;
        private string _userEmail = string.Empty;
        private string _userPhoneNumber = string.Empty;
        private string _userFirstName = string.Empty;
        private string _userLastName = string.Empty;
        private int _UserID;
        private bool _isAdmin = false;
        //Account of accounts 
        private List<Account> _accounts;
        private List<DateTime> _netWorthX;
        private List<double> _netWorthY;
        private double _netWorth;
        private double _totalAssets;
        private double _totalLiabilities;
        public UserAccount(string uname, string uPwd, string uemail, string uPhoneNum, string fname, string lname)
        {
            this._username = uname;
            this._userPassword = uPwd;
            this._userEmail = uemail;
            this._userPhoneNumber = uPhoneNum;
            this._userFirstName = fname;
            this._userLastName = lname;
            this._isAdmin = false;
            //TODO: somehow increment user id, 31800000, 31800001, 31800002, etc
        }
        public UserAccount()
        {
            
        }
        public void addAccount(AccountTypeEnum_T accountType)
        {
            //Use linked list of accounts to manage all of the accounts
            //creating an account will be a seperate function and will add more to this function
            //moneyHubAccounts.AddLast();
            
        }
        //Totals for Assets and Liabilities
        public double TotalAssets
        {
            get { return this._totalAssets; }
            set { this._totalAssets = value; }
        }
        public double TotalLiabilities
        {
            get { return this._totalLiabilities; }
            set { this._totalLiabilities = value;  }
        }
        //set of user Accounts
        public List<Account> Accounts
        {
            get { return this._accounts; }
            set { this._accounts = value; }
        }
        //set of values for a users networth history
        public double NetWorth
        {
            get { return this._netWorth; }
            set { this._netWorth = value; }
        }
        public List<DateTime> NetWorthX
        {
            get { return this._netWorthX; }
            set { this._netWorthX = value;  }
        }
        public List<double> NetWorthY
        {
            get { return this._netWorthY; }
            set { this._netWorthY = value; }
        }
        public string Username
        {
            get { return this._username; }
            set { this._username = value; }
        }
        public string userPassword
        {
            get { return this._userPassword; }
            set { this._userPassword = value; }
        }
        public string userEmail
        {
            get { return this._userEmail; }
            set { this._userEmail = value; }
        }
        public string userPhoneNumber
        {
            get { return this._userPhoneNumber; }
            set { this._userPhoneNumber = value; }
        }
        public string userFirstName
        {
            get { return this._userFirstName; }
            set { this._userFirstName = value; }
        }
        public string userLastName
        {
            get { return this._userLastName; }
            set { this._userLastName = value; }
        }
        public int UserID
        {
            get { return this.UserID; }
        }
        public bool isAdmin
        {
            get { return this._isAdmin; }
            set { this._isAdmin = isAdmin; }
        }
    }
}
