using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class LongestWord
    {
        String s1;
        public LongestWord() 
        {
            Console.WriteLine("Enter any line: ");
            s1 = Console.ReadLine();
        }
        public String GetLongest() 
        {
            String[] s1Array = s1.Split(" ");
            int max = s1Array[0].Length;
            String maxString = s1Array[0];

            foreach (String temp in s1Array)
            {
                if (temp.Length > max)
                {
                    max = temp.Length;
                    maxString = temp;
                }
            }
            return maxString;
        }
    }
}
