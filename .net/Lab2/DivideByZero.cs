using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class DivideByZero
    {
        double a;
        double b;
        double ans;
        public DivideByZero() 
        {
            Console.WriteLine("Enter a: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter b: ");
            b = Convert.ToDouble(Console.ReadLine());
        }

        public void GetDivision()
        {
            try
            {
                if (b == 0)
                {
                    throw new DivideByZeroException();
                }
                else
                {
                    ans = a / b;
                    Console.WriteLine("a/b = {0}", ans);
                }
            }
            catch (DivideByZeroException e)
            { 
                Console.WriteLine("😂😂😂 \nPrint Error: {0}", e.ToString());
            }
        }
    }
}
