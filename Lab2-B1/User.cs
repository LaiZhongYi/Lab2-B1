using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_B1
{
    class User
    {
        private string userName = "admin";
        private string password = "admin";

        public string Password
        {
            get
            {
                return password;
            }
            
        }

        public string UserName
        {
            get
            {
                return userName;
            }
        }
    }
}
