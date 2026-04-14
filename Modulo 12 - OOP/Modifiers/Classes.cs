using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modifiers
{
    internal class Classes
    {
        private string name;
        public string lastName;

        private void Method1() { }
        public void Method2() { }

    }

    class Human
    {
        public string name;
        protected string lastName;
        internal int idade; // Restringe para dentro do nameespace "Modifiers".
    }

    class Man : Human
    {
        public void Method1()
        {
            lastName = "Variavel com Protected";
            idade = 0;
        }
    }
}
