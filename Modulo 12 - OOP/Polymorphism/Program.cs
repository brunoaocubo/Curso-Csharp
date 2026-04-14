using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Form form = new Form();
            Form triangle = new Triangle();
            Form circle = new Circle();
            Form rectangle = new Rectangle();
            
            //Console.WriteLine("\nForma:");
            //form.Draw();
            Console.WriteLine("\nTriângulo:");
            triangle.Draw();
            triangle.Area();
            Console.WriteLine("\nCirculo:");
            circle.Draw();
            circle.Area();
            Console.WriteLine("\nRetângulo:");
            rectangle.Draw();
            rectangle.Area();
        }
    }
}
