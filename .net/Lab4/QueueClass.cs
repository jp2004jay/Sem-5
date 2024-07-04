using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class QueueClass
    {
        Queue queue = new Queue();
        public QueueClass() 
        {
            queue.Enqueue(188);
            PrintList();
            queue.Enqueue(124);
            PrintList();
            queue.Enqueue(787);
            PrintList();
            queue.Enqueue(469);
            PrintList();
            queue.Dequeue();
            PrintList();
            Console.WriteLine("Peek(2): {0}", queue.Peek());
            Console.WriteLine("Contains(12): {0}", queue.Contains(124));
            Console.WriteLine("Contains(105): {0}", queue.Contains(105));
            queue.Clear();
            PrintList();
        }
        public void PrintList()
        {
            foreach (object item in queue)
            {
                Console.Write("{0}, ", item);
            }
            Console.Write("\n");
        }
    }
}
