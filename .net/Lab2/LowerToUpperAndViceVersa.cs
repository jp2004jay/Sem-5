using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class LowerToUpperAndViceVersa
    {
        String name, output;

        public LowerToUpperAndViceVersa()
        {
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();
            output = String.Empty;
        }
        public void ConvertString()
        {
            foreach (Char ch in name.ToCharArray())
            {
                int ascii = Convert.ToInt32(ch);
                if (ascii >= 65 && ascii <= 90)
                {
                    output += Convert.ToChar(ascii + 32);
                }
                else if (ascii >= 97 && ascii <= 122)
                {
                    output += Convert.ToChar(ascii - 32);
                }
                else 
                {
                    output += Convert.ToChar(ascii);
                }
            }
            Console.WriteLine("Output is: {0}", output);
        }
    }
}
