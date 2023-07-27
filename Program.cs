using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle ci = new Circle(5);
            ci.Display();
            Rectangle rect = new Rectangle(10, 15);
            rect.Display();
            Trianglee tri = new Trianglee(5, 8, 4);
            tri.Display();
        }
    }
}
