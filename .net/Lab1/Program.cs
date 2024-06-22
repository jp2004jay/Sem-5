using System;
using System.Collections;
using Lab1;

namespace lab1
{
    public class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Enter 1 to Run Program 1 \nEnter 2 to Run Program 2 \nand so on...\nteel Program 10 \nEnter 0 for exit");
            
            while (true)
            {
                Console.WriteLine("Case: ");
                String Cases = Console.ReadLine();

                switch (Cases)
                {
                    case "0":
                        System.Environment.Exit(0);
                        break;
                    case "1":
                        RunCandidate();
                        break;
                    case "2":
                        RunStaff();
                        break;
                    case "3":
                        RunBank_Account();
                        break;
                    case "4":
                        RunStudent();
                        break;
                    case "5":
                        RunRectangle();
                        break;
                    case "6":
                        RunIntrest();
                        break;
                    case "7":
                        RunSalaryCalculate();
                        break;
                    case "8":
                        RunDistance();
                        break;
                    case "9":
                        RunTable();
                        break;
                    case "10":
                        RunGrossSalary();
                        break;
                }
            }
        }

        static void RunCandidate()
        {
            Candidate c1 = new Candidate();
            c1.GetCandidateDetails();
            c1.DisplayCandidateDetails();
        }
        static void RunStaff()
        {
            Staff[] staffs = new Staff[5];
            for (int i = 0; i < 5; i++)
            {
                staffs[i] = new Staff();
            }

            foreach (Staff staff in staffs)
            {
                if (staff.getDesignation() == "HOD")
                {
                    staff.displayStaff();
                }
            }
        }

        static void RunBank_Account()
        {
            Bank_Account account = new Bank_Account();
            account.GetAccountDetails();
            account.DisplayAccountDetails();
        }

        static void RunStudent()
        {
            Student student = new Student();
            student.DisplayStudentDetails();
        }

        static void RunRectangle()
        {
            Console.WriteLine("Enter a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Rectangle r1 = new Rectangle(a, b);
            r1.DisplayArea();
        }

        static void RunIntrest()
        {
            Account_Details account = new Account_Details();
            account.DisplayAccountDetails();
        }

        static void RunSalaryCalculate()
        {
            SalaryCalculate salary = new SalaryCalculate();
            Console.WriteLine("Actual Salary: {0}", salary.getSalary());
        }

        static void RunDistance()
        {
            Distance dist = new Distance();
            dist.Sum();
            dist.DisplayDistance();
        }

        static void RunTable()
        {
            Table t1 = new Table();
            t1.printDetails();
        }

        static void RunGrossSalary()
        {
            Salary s1 = new Salary();
            s1.GrossSalary();
            s1.DisplaySalary();
        }
    }
}


