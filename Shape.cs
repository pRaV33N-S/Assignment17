using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17
{
    internal class Shape
    {
        public string ShapeType { get; set; }
        public Shape(string shapeType)
        {
            ShapeType = shapeType;
        }
        public virtual double Area()
        {
            return 0;
        }
        public virtual double Perimeter()
        {
            return 0;
        }
        public virtual void Display()
        {
            Console.WriteLine($"Shape Type : {ShapeType}\nArea : {Area()}\nPerimeter : {Perimeter()}");
        }
    }
}
