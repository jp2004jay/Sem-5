using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public interface Calculation
    {
        public double Addition();
        public double Substraction();
    }
    internal class Result : Calculation
    {
        double x, y;

        public Result()
        {
            Console.WriteLine("Enter a: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter b: ");
            y = Convert.ToDouble(Console.ReadLine());
        }
        public double Addition()
        {
            return x + y;
        }
        public double Substraction()
        {
            return x - y;
        }
    }
}
