using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    interface Shape
    {
        public double Circle(double radius);
        public double Triangle(double a, double b);
        public double Square(double a);
    }
    internal class CalculateArea : Shape
    {
        String choice;
        public CalculateArea()
        {
            Console.WriteLine("Enter 1 for find Area of Circle \nEnter 2 for find Area of Triangle \nEnter 3 for find Area of Square");
            choice = Console.ReadLine();

            while (choice != "1" && choice != "2" && choice != "3")
            {
                Console.WriteLine("Please Enter Valid Choice! 😠😠");
                choice = Console.ReadLine();
            }
        }
        public double Circle(double radius)
        {
            return Math.PI*radius*radius;
        }
        public double Triangle(double a, double b)
        {
            return 0.5*a*b;
        }
        public double Square(double a)
        {
            return a*a;
        }

        public String GetChoice()
        { 
            return choice;
        }
    }
}
