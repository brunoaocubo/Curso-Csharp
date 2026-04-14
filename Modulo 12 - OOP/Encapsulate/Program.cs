using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount client1 = new BankAccount();

            client1.Client = "Tulia";
            client1.Client = "Jasmine";
            client1.Deposit(50);
            client1.CheckBalance();

        }
    }
}
