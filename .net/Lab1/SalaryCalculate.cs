using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class SalaryCalculate
    {
        double da = 0.1;
        double hra = 0.04;
        double basicSalary;

        public SalaryCalculate()
        {
            Console.WriteLine("Enter your basic salary: ");
            basicSalary = Convert.ToDouble(Console.ReadLine());
        }

        public double getSalary()
        {
            return basicSalary - ((basicSalary * da) + (basicSalary * hra));
        }
    }
}