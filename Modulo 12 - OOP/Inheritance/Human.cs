using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Human
    {
        public virtual void Eyes()
        {
            Console.WriteLine("Human.Eyes");
        }

        public virtual void Hair()
        {
            Console.WriteLine("Human.Hair");
        }
    }

    class Person : Human
    {
        public sealed override void Eyes()
        {
            Console.WriteLine("Pessoa.Eyes");
        }

        public override void Hair()
        {
            Console.WriteLine("Pessoa.Hair");
        }
    }

    class Man : Person
    {
        /* 
         * NÃO É POSSIVEL SOBRESCREVER PORQUE O MÉTODO EM PESSOA ESTÁ COMO "SEALED"
         
        public override void Eyes()
        {
            Console.WriteLine("Man.Eyes");
        }*/

        public override void Hair()
        {
            Console.WriteLine("Man.Hair");
        }
    }
}
