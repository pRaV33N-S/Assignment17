using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17
{
    internal class Circle : Shape
    {
        public double radius { get; set; }
        public Circle(double radius) : base("Circle")
        {
            this.radius = radius;
        }
        public override double Area()
        {
            return 22/7*radius*radius;
        }
        public override double Perimeter()
        {
            return 2 * 22 / 7 * radius;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Radius : {radius}");
            Console.WriteLine();
        }
    }
}
