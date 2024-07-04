using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class StackClass
    {
        Stack stack = new Stack();
        public StackClass() 
        {
            stack.Push(18);
            PrintList();
            stack.Push(12);
            PrintList();
            stack.Push(78);
            PrintList();
            stack.Push(46);
            PrintList();
            stack.Pop();
            PrintList();
            Console.WriteLine("Peek(2): {0}", stack.Peek());
            Console.WriteLine("Contains(12): {0}", stack.Contains(12));
            Console.WriteLine("Contains(105): {0}", stack.Contains(105));
            stack.Clear();
            PrintList();
        }

        public void PrintList()
        {
            foreach (object item in stack)
            {
                Console.Write("{0}, ", item);
            }
            Console.Write("\n");
        }
    }
}
