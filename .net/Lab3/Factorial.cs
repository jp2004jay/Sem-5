using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Factorial
    {
        public delegate int findFactorial(int num);
        public void runmain()
        {
            
            findFactorial findFac = new findFactorial(Factorial.actualLogicToFindFactorial);

            Console.WriteLine("5! = {0}", findFac(5));
            Console.WriteLine("2! = {0}", findFac(2));
            Console.WriteLine("0! = {0}", findFac(0));
            Console.WriteLine("4! = {0}", findFac(4));
        }
        public static int actualLogicToFindFactorial(int n) 
        {
            if (n == 0 || n == 1) 
            { 
                return 1; 
            }
            else
            {
                return n * actualLogicToFindFactorial(n - 1);
            }
        }
    }
}
