using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class ChangeCase
    {
        char ch;
        public ChangeCase() 
        {
            Console.WriteLine("Enter a single charactor: ");
            while (true)
            {
                try
                {
                    ch = Convert.ToChar(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Khabar nath padti ek var kidhu ema 😠😠: ");
                    continue;
                }
            }
        }

        public char Change() 
        {
            int ascii = Convert.ToInt32(ch);
            if (ascii >= 65 && ascii <= 90)
            {
                ascii += 32;
            }
            else if (ascii >= 97 && ascii <= 122)
            {
                ascii -= 32;
            }
            return Convert.ToChar(ascii);
        }
    }
}
