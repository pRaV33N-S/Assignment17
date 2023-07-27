﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17
{
    internal class Rectangle : Shape
    {
        public double length { get; set; }
        public double width { get; set; }
        public Rectangle(double length, double width) : base("Rectangle")
        {
            this.length = length;
            this.width = width;
        }
        public override double Area()
        {
            return length * width;
        }
        public override double Perimeter()
        {
            return 2 * (length + width);
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Length : {length}\nWidth : {width}");
            Console.WriteLine();
        }
    }
}
