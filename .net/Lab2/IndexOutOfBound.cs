using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class IndexOutOfBound
    {
        int[] numbers = new int[4];
        int n;
        public IndexOutOfBound() 
        {
            Console.WriteLine("How many numbers do you want to enter?: ");
            n = Convert.ToInt32(Console.ReadLine());
        }
        public void AddNumbers()
        {
            for (int i = 0; i < n; i++)
            {
                try
                {
                    Console.WriteLine("Enter number: ");
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }
                catch (IndexOutOfRangeException e)
                { 
                    Console.WriteLine("Sorry bro! Internal Capacity is 4. 🤔\nPrint Error: {0}", e.ToString());
                }
            }
        }
    }
}
