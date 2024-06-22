using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Rectangle
    {
        double area;

        public Rectangle(double a, double b)
        {
            area = a * b;
        }

        public void DisplayArea()
        {
            Console.WriteLine("Area: {0}", area);
        }
    }
}
