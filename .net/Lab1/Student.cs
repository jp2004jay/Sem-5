using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab1
{
    internal class Student
    {
        String Enrollment_No;
        String Student_Name;
        int Semester;
        double CPI;
        double SPI;

        public Student()
        {
            Console.WriteLine("Enter Enrollment_No: ");
            Enrollment_No = Console.ReadLine();

            Console.WriteLine("Enter Student_Name: ");
            Student_Name = Console.ReadLine();

            Console.WriteLine("Enter Semester: ");
            Semester = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter CPI: ");
            CPI = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter SPI: ");
            SPI = Convert.ToDouble(Console.ReadLine());
        }
        public void DisplayStudentDetails()
        {
            Console.WriteLine("Enrollment_No: {0} \nStudent_Name: {1} \nSemester: {2} \nCPI: {3} \nSPI: {4}", Enrollment_No, Student_Name, Semester, CPI, SPI);
        }
    }
}
