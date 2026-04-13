using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisMethod
{
    internal class Acess
    {
        string password = "123";

        public bool Login(string password)
        {
            return this.password == password;
        }
    }
}
