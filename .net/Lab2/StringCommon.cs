using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class StringCommon
    {
        String name;
        Hashtable output = new Hashtable();
        public StringCommon() 
        {
            Console.WriteLine("Please enter your full name: ");
            name = Console.ReadLine();
        }
        public void Run()
        { 
            Console.WriteLine("Original: {0}\n", name);
            output.Add("Length", name.Length);
            output.Add("Replace()", name.Replace('a', '*'));
            output.Add("IndexOf('a')", name.IndexOf('a'));
            output.Add("Uppercase()", name.ToUpper());
            output.Add("Lowercase()", name.ToLower());
            output.Add("LastIndexOf('a')", name.LastIndexOf('a'));
            output.Add("name[2]", name[2]);
            output.Add("Substring(5)", name.Substring(5));
            output.Add("Concat(name.Split(' '))", string.Concat(name.Split(' ')));

            String[] arr = name.Split(' ');
            output.Add("Split(' ')", $"[\"{arr[0]}\"," + $"\"{arr[1]}\"]");

            foreach (String s in output.Keys)
            {
                Console.WriteLine("{0}: {1}", s, output[s]);
            }
        }
    }
}
