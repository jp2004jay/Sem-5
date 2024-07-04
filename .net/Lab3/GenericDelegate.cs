using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public delegate T genericDelegate<T>(T a, T b);
    class GenericDelegate
    {
        public void runmain()
        {
            genericDelegate<String> sumString = new genericDelegate<string>((String a, String b) => a + b);
            genericDelegate<double> sumDouble = new genericDelegate<double>((double a, double b) => a + b);
            genericDelegate<int> sumInt = new genericDelegate<int>((int a, int b) => a + b);

            Console.WriteLine(sumString("Jay ", "Ramani"));
            Console.WriteLine(sumDouble(2.2, 1.3));
            Console.WriteLine(sumInt(2, 1));
        }
    }
}
