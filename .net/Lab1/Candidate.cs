using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Candidate
    {
        int ID;
        String Name;
        int Age;
        double Weight;
        double Height;

        public Candidate()
        {
            ID = -1;
            Name = "";
            Age = -1;
            Weight = -1.0;
            Height = -1.0;
        }

        public void GetCandidateDetails()
        {
            Console.WriteLine("Enter ID: ");
            ID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name: ");
            Name = Console.ReadLine();

            Console.WriteLine("Enter Age: ");
            Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Weight: ");
            Weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Height: ");
            Height = Convert.ToDouble(Console.ReadLine());
        }
        public void DisplayCandidateDetails()
        {
            Console.WriteLine("ID: {0} \nName: {1} \nAge: {2} \nWeight: {3} \nHeight: {4}", ID, Name, Age, Weight, Height);
        }
    }
}
