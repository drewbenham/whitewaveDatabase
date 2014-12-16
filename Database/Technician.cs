using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Database
{
    public class Technician
    {
        private string name;
        private string email;
        private string userName;
        private string password;

        public Technician(string name, string email, string userName, string password)
        {
            this.name = name;
            this.email = email;
            this.userName = userName;
            this.password = password;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}