using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public delegate void Color();
    internal class TrafficDel
    { 
        public void runMain()
        {
            Color yellow = new Color(TrafficDel.Yellow);
            Color green = new Color(TrafficDel.Green);
            Color red = new Color(TrafficDel.Red);

            yellow();
            green();
            red();
        }
        public static void Yellow()
        {
            Console.WriteLine("Yellow Light Signal To Get Ready");
        }
        public static void Green()
        {
            Console.WriteLine("Green Light Signal To Go");
        }
        public static void Red()
        {
            Console.WriteLine("Red Light Signal To Stop");
        }

    }
}
