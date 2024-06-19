using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab1
{
    internal class Bank_Account
    {
        String Account_No;
        String Email;
        String User_Name;
        String Account_Type;
        double Account_Balance;

        public Bank_Account()
        {
            Account_No = "";
            Email = "";
            User_Name = "";
            Account_Type = "";
            Account_Balance = 0;
        }

        public void GetAccountDetails()
        {
            Console.WriteLine("Enter Account_No: ");
            Account_No = Console.ReadLine();

            Console.WriteLine("Enter Email: ");
            Email = Console.ReadLine();

            Console.WriteLine("Enter User_Name: ");
            User_Name = Console.ReadLine();

            Console.WriteLine("Enter Account_Type (C or S): ");
            Account_Type = Console.ReadLine();
            while (Account_Type != "C" && Account_Type != "S" && Account_Type != "c" && Account_Type != "s")
            {
                Console.WriteLine("Account_Type must me Saving (Type S) of Current (Type C)");
                Account_Type = Console.ReadLine();
            }
            switch (Account_Type){
                case "c":
                case "C":
                    Account_Type = "Current";
                    break;
                case "s":
                case "S":
                    Account_Type = "Saving";
                    break;
            }

            Console.WriteLine("Enter Account_Balance (Minimum 1000): ");
            Account_Balance = Convert.ToDouble(Console.ReadLine());
            while(Account_Balance < 1000)
            {
                Console.WriteLine("Minimum 1000 balance is required!: ");
                Account_Balance = Convert.ToDouble(Console.ReadLine());
            }
        }
        public void DisplayAccountDetails()
        {
            Console.WriteLine("Account_No: {0} \nEmail: {1} \nUser_Name: {2} \nAccount_Type: {3} \nAccount_Balance: {4}", Account_No, Email, User_Name, Account_Type, Account_Balance);
        }
    }
}
