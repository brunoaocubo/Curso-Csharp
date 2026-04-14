using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    internal class BankAccount
    {
        private string _client;
        private double _balance;
        private double _taxeCashOut = 15;

        public string Client { get { return _client; }
            set
            {
                if(_client == null || _client == "")
                {
                    _client = value;
                }
            }
        }

        public void CheckBalance()
        {
            Console.WriteLine($"Nome:{Client}\nSaldo:{_balance}");
        }

        public void CashOut(double value)
        {
            value += _taxeCashOut;

            if(_balance >= value)
            {
                _balance -= value;
            }
        }

        public void Deposit(double value)
        {
            _balance += value;
        }
    }
}
