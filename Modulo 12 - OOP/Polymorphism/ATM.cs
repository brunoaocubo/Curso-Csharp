using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class ATM : IAccount
    {
        public string User { get; set; }

        public void Balance()
        {
            
        }

        public void CashOut()
        {
            
        }

        public void Deposit()
        {
            
        }

        public void RequestLoan()
        {

        }
    }

    interface IAccount //Funciona como um abstract, mas com um contrato para a classe que herdar.
    {
        string User { get; set; }
        void Deposit();
        void CashOut();
        void Balance();
    }
}
