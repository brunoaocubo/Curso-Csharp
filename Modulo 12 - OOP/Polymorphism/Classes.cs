using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    abstract class Form
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int Ray { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Iniciando os desenhos");
        }

        public virtual void Area()
        {
            double area = Width * Height;
            Console.WriteLine($"Área {area}");
        }
    }

    public class Circle : Form
    {
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Desenhando um Círculo");
        }

        public override void Area()
        {
            double area = 3.14 * (Ray * Ray);
            Console.WriteLine($"Área Círculo: {area}");
        }
    }

    public class Rectangle : Form
    {
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Desenhando um Retângulo");
        }

        public override void Area()
        {
            base.Area(); 
        }
    }

    public class Triangle : Form
    {
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Desenhando um Triângulo");
        }

        public override void Area()
        {
            double area = 3.14 * (Width * Height) / 2;
            Console.WriteLine($"Área Triângulo: {area}");
        }
    }
}
