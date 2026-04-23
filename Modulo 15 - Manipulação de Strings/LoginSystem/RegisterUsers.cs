using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginSystem
{
    internal static class RegisterUsers
    {
        public static User[] Users =
        {
            new User(){   Username = "admin", Password = "admin123"   },
            new User(){   Username = "admin1", Password = "admin456"   },
            new User(){   Username = "admin2", Password = "admin"   },
        };

        private static User _userLogged = null;

        public static User UserLogged 
        { 
            get { return _userLogged;  } 
            private set { _userLogged = value; } 
        }
        
        public static bool Login(User userArgs)
        {
            foreach (User user in Users)
            {
                if (userArgs.Username == user.Username && userArgs.Password == user.Password)
                {
                    _userLogged = user;
                    return true;
                }
            }
            return false;
        }
    }
}
