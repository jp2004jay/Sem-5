using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab4
{
    internal class ListClass
    {
        List<String> list = new List<string>();

        public ListClass() 
        {
            list.Add("Viral");
            PrintList();
            list.Add("Jenish");
            PrintList();
            list.Add("Abhishek");
            PrintList();
            list.Remove("Viral");
            PrintList();
            list.RemoveRange(0, 1);
            PrintList();
            list.Clear();
            PrintList();
        }

        public void PrintList()
        {
            foreach (String item in list)
            {
                Console.Write("{0}, ", item);
            }
            Console.Write("\n");
        }
    }
}
