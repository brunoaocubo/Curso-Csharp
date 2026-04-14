using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    internal class GetSet
    {
        private string _name;
        public string LastName { get; } = "Brennford";
        private int _age;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value > 18)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Idade majoritaria inferior a 18 anos.");
                }
            }
        }
    }
}
