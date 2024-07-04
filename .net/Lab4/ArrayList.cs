using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab4
{
    internal class ArrayListClass
    {
        ArrayList arrayList = new ArrayList();
        public ArrayListClass() 
        {
            arrayList.Add("Jay Ramani");
            PrintList();
            arrayList.Add("Parth Thoriya");
            PrintList();
            arrayList.Add("Kisan Dabhi");
            PrintList();
            arrayList.Remove("Kisan Dabhi");
            PrintList();
            arrayList.RemoveRange(0,1);
            PrintList();
            arrayList.Clear();
            PrintList();
        }

        public void PrintList()
        {
            foreach(object item in arrayList)
            {
                Console.Write("{0}, ", item);
            }
            Console.Write("\n");
        }
    }
}
