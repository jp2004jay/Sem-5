using System;
using Lab1;

namespace lab1
{
    public class Program
    {
        static void Main(string[] args) 
        {
            RunIntrest();
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
            Rectangle r1 = new Rectangle(3, 5);
            Console.WriteLine("Area: {0}", r1.area);
        }

        static void RunIntrest()
        {
            Account_Details account = new Account_Details();
            account.DisplayAccountDetails();
        }
    }
}


