using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    internal class Recursive
    {
        public void ExecuteNonRecursive(string message, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(message);
            }
        }

        public void ExecuteRecursive(string message, int n)
        {
            if(n > 0)
            {
                Console.WriteLine(message);
                ExecuteRecursive(message, n - 1);
            }
        }
    }
}
