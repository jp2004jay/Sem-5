using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
   internal class Interest
    {
        double intrest = 0.1;

        public double CalculateIntrest(double balance)
        {
            return intrest*balance;
        }
    }
    internal class Account_Details : Interest
    {
        String Account_Number;
        double Balance;
        public Account_Details()
        {
            Console.WriteLine("Enter Account_Number: ");
            Account_Number = Console.ReadLine();

            Console.WriteLine("Enter Balance: ");
            Balance = Convert.ToDouble(Console.ReadLine());
        }
        
        public void DisplayAccountDetails()
        {
            Console.WriteLine("Account_No: {0} \nBalance: {1} \nIntrest: {2}", Account_Number, Balance, CalculateIntrest(Balance));
        }
    }
}
