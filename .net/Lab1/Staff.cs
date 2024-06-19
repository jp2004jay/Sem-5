using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Staff
    {
        String Name;
        String Department; 
        String Designation;
        double Experience;
        double Salary;

        public Staff()
        {
            Console.WriteLine("Enter Name: ");
            Name = Console.ReadLine();

            Console.WriteLine("Enter Department: ");
            Department = Console.ReadLine();

            Console.WriteLine("Enter Designation: ");
            Designation = Console.ReadLine();

            Console.WriteLine("Enter Experience: ");
            Experience = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Salary: ");
            Salary = Convert.ToDouble(Console.ReadLine());
        }

        public void displayStaff()
        {
            Console.WriteLine("Name: {0} \nSalary: {1}", Name, Salary);
        }

        public String getDesignation()
        {
            return Designation;
        }
    }
}
