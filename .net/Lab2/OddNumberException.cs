using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class OddNumberException
    {
        int n;
        public OddNumberException() 
        {
            Console.WriteLine("Enter number: ");
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n % 2 != 0)
                {
                    throw new Exception("Odd Number Occur,🤣🤣");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally 
            { 
                Console.WriteLine("Complete... 👌👌");
            }
        }
    }
}
