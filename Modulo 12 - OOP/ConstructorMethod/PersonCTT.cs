using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorMethod
{
    internal class PersonCTT
    {
        public string firstName;
        public string lastName;
        public int bornYear;
        public int age;

        public PersonCTT()
        {
            firstName = "Primeiro Nome";
            lastName = "Sobrenome";
            bornYear = 2026;
            age = 0;
        }

        public PersonCTT(string firstName, string lastName, int bornYear)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.bornYear = bornYear;
            age = CalcAge(bornYear);
        }

        public PersonCTT(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            CalcAge(this.bornYear);
        }

        private int CalcAge(int bornYear) {
            int actualYear = DateTime.Today.Year;
            return actualYear - bornYear;
        }
    }
}
