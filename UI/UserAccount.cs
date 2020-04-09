using System;
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

        }
        public string username
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
