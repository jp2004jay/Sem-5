using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    abstract class RBI
    {
        abstract public double calculateIntrest(double principle, double year); 
    }

    class HDFC : RBI
    {
        public override double calculateIntrest(double principle, double year)
        {
            return (principle * 7.5 * year) / 100;
        }
    }
    class SBI : RBI
    {
        public override double calculateIntrest(double principle, double year)
        {
            return (principle * 6.5 * year) / 100;
        }
    }
    class ICICI : RBI
    {
        public override double calculateIntrest(double principle, double year)
        {
            return (principle * 8.5 * year) / 100;
        }
    }
}
