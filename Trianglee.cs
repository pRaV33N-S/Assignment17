using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17
{
    internal class Trianglee : Shape
    {
        public double sideA { get; set; }
        public double sideB { get; set; }
        public double sideC { get; set; }
        public Trianglee(double a, double b, double c) : base("Trianglee")
        {
            this.sideA = a;
            this.sideB = b;
            this.sideC = c;
        }
        public override double Area()
        {
            double s = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
        }
        public override double Perimeter()
        {
            return sideA + sideB+sideC;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Side A : {sideA}\nSide B : {sideB}\nSide C : {sideC}");
            Console.WriteLine();
        }
    }
}
