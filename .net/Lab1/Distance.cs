using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Distance
    {
        double dist1;
        double dist2;
        double dist3;

        public Distance()
        {
            Console.WriteLine("Enter Distance 1: ");
            dist1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Distance 2: ");
            dist2 = Convert.ToDouble(Console.ReadLine());
        }

        public void Sum()
        {
            dist3 = dist1 + dist2;            
        }
        public void DisplayDistance()
        {
            Console.WriteLine("Total: {0}", dist3);
        }
    }
}
