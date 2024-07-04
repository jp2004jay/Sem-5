using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    abstract class Sum
    {
        abstract public int SumOfTwo(int a, int b);
        abstract public int SumOfThree(int a, int b, int c);
    }
    internal class Calculate : Sum
    {
        String choice;
        public Calculate() 
        {
            Console.WriteLine("Enter 1 for two numbers sum \nEnter 2 for three numbers sum");
            choice = Console.ReadLine();

            while (choice != "1" && choice != "2")
            {
                Console.WriteLine("Please Enter Valid Choice! 😠😠");
                choice = Console.ReadLine();
            }
        }
        public override int SumOfTwo(int a, int b)
        {
            return a + b;
        }
        public override int SumOfThree(int a, int b, int c)
        {
            return a + b + c;
        }
        public String GetChoice()
        {
            return choice;
        }
    }
}
