using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyHub
{
    public class User
    {
        //Variables
        private String username = string.Empty;
        private String password = string.Empty;

        public User(String username, String password)
        {
            this.username = username;
            this.password = password;
        }
        public String getUsername()
        {
            return this.username;
        }
        public void setUsername(String user)
        {
            this.username = user;
        }
        public String getPassword()
        {
            return this.password;
        }
        public void setPassword(String pwd)
        {
            this.password = pwd;
        }
    }
}
