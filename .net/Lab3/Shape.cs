using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Shape
    {
        public double FindArea(double side, String choice)
        {
            switch (choice)
            {
                case "S":
                    return side * side;
                    break;
                case "C":
                    return Math.PI * side * side;
                    break;
            }
            return -1;
        }
        public double FindArea(double sideA, double sideB)
        {
            return sideA * sideB;
        }
    }


}
