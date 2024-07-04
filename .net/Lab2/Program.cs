using System.Collections;

namespace Lab2
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
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
                        RunDividedByZero();
                        break;
                    case "2":
                        RunIndexOutOfBound();
                        break;
                    case "3":
                        RunCalculate();
                        break;
                    case "4":
                        RunResult();
                        break;
                    case "5":
                        RunStringCommon();
                        break;
                    case "6":
                        RunLowerToUpperAndViceVersa();
                        break;
                    case "7":
                        RunCalculateArea();
                        break;
                    case "8":
                        RunOddNumber();
                        break;
                    case "9":
                        RunLongestWord();
                        break;
                    case "10":
                        RunChangeTheCase();
                        break;
                }
            }
        }
        static void RunDividedByZero()
        {
            DivideByZero dbz = new DivideByZero();
            dbz.GetDivision();
        }
        static void RunIndexOutOfBound()
        {
            IndexOutOfBound iob = new IndexOutOfBound();
            iob.AddNumbers();
        }
        static void RunCalculate()
        {
            Calculate cal = new Calculate();

            switch (cal.GetChoice())
            {
                case "1":
                    Console.WriteLine("Enter a: ");
                    int a = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter b: ");
                    int b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Sum: {0}", cal.SumOfTwo(a, b));
                    break;
                case "2":
                    Console.WriteLine("Enter a: ");
                    int x = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter b: ");
                    int y = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter c: ");
                    int z = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Sum: {0}", cal.SumOfThree(x, y, z));
                    break;
            }
        }
        static void RunResult()
        {
            Result result = new Result();
            Console.WriteLine("Addition: {0} \nSubstraction: {1}", result.Addition(), result.Substraction());
        }
        static void RunStringCommon()
        {
            StringCommon stringCommon = new StringCommon();
            stringCommon.Run();
        }
        static void RunLowerToUpperAndViceVersa()
        {
            LowerToUpperAndViceVersa luvv = new LowerToUpperAndViceVersa();
            luvv.ConvertString();
        }

        static void RunCalculateArea()
        {
            CalculateArea cal = new CalculateArea();

            switch (cal.GetChoice())
            {
                case "1":
                    Console.WriteLine("Enter radius: ");
                    double r = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Area of Circle: {0}", cal.Circle(r));
                    break;
                case "2":
                    Console.WriteLine("Enter a: ");
                    double a = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter b: ");
                    double b = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Area of Triangle: {0}", cal.Triangle(a, b));
                    break;
                case "3":
                    Console.WriteLine("Enter side: ");
                    double side = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Area of Square: {0}", cal.Square(side));
                    break;
            }
        }
        static void RunOddNumber()
        {
            OddNumberException oe = new OddNumberException();
        }
        static void RunLongestWord()
        {
            LongestWord lw = new LongestWord();
            Console.WriteLine("Longest Word is: {0}", lw.GetLongest());
        }

        static void RunChangeTheCase()
        {
            ChangeCase ch = new ChangeCase();
            Console.WriteLine("Change: {0}", ch.Change());
        }
    }
}