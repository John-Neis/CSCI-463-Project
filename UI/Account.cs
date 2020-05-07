using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyHub_User_Interface
{
    class Account
    {
        private int accountNumber = 0;
        string accountType;
        private double balance = 0;
        public Account()
        {

        }
        public Account(int aNum, double bal, string type)
        {
            this.accountNumber = aNum;
            this.balance = bal;
            this.accountType = type;
        }
        public int AccountNumber
        {
            set { this.accountNumber = value; }
            get { return this.accountNumber; }
        }
        public double Balance
        {
            set { this.balance = value; }
            get { return balance; }
        }
        public string AccountType
        {
            set { this.accountType = value; }
            get { return this.accountType; }
        }

    }
}
