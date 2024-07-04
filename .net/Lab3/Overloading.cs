using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Overloading
    {
        public void Sum(int a, int b)
        {
            Console.WriteLine("a+b: {0}", a + b);
        }
        public void Sum(float a, float b)
        {
            Console.WriteLine("a+b: {0}", a + b);
        }
    }
}
