using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    interface Gross
    {
        public void GrossSalary();
    }

    class Employee
    {
        String Name;

        public Employee() 
        {
            Console.WriteLine("Enter Name: ");
            Name = Console.ReadLine();
        }

        public String GetName()
        {
            return Name;
        }

        public double BasicSalary(double salary, double hra, double da, double ta)
        {
            return salary - (salary*hra + salary*da + salary*ta);
        }
    }

    class Salary : Employee, Gross
    {
        double hra = 0.01;
        double da = 0.06;
        double ta = 0.03;
        double grossSalary;

        public void GrossSalary()
        {
            Console.WriteLine("Enter Salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());

            grossSalary = BasicSalary(salary, hra, da, ta);
        }

        public void DisplaySalary()
        {
            Console.WriteLine("Name: {0} \nGross Salary: {1}", GetName(), grossSalary);
        }
    }
}
