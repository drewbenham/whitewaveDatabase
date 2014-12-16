using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Database
{
    public class UserLoggedIn
    {
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public UserLoggedIn(string username)
        {
            this.username = username;
        }
        
    }
}