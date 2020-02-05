using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyHub
{
    public class User
    {
        #region Variables
        //Variables
        private String username = string.Empty;
        private String password = string.Empty;
        private String firstName = string.Empty;
        private String lastName = string.Empty;
        private DateTime DOB;
        #endregion
        #region User Constructors
        public User(String username, String password)
        {
            this.username = username;
            this.password = password;
        }
        public User(String username, String password, String firstName, String lastName, DateTime date)
        {
            this.username = username;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
            this.DOB = date;
        }
        public User()
        {

        }
        #endregion Constructors
        #region Getters and Setters
        public String getUsername()
        {
            return this.username;
        }
        public void setUsername(String user)
        {
            this.username = user;
        }
        public void setPassword(String pwd)
        {
            this.password = pwd;
        }
        public void setFirstName(string firstName)
        {
            this.firstName = firstName;
        }
        public string getFirstName()
        {
            return this.firstName;
        }
        public void setLastName(string lastName)
        {
            this.lastName = lastName;
        }
        public string getLastName()
        {
            return this.firstName;
        }
        #endregion Get/Set
    }
}
