using Lab4;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter 0 for exit \nEnter 1 to 4: ");
                String cases = Console.ReadLine();

                switch (cases)
                {
                    case "0":
                        System.Environment.Exit(0);
                        break;
                    case "1":
                        ArrayListClass alc = new ArrayListClass();
                        break;
                    case "2":
                        ListClass lc = new ListClass();
                        break;
                    case "3":
                        StackClass sc = new StackClass();
                        break;
                    case "4":
                        QueueClass qc = new QueueClass();
                        break;
                    default:
                        Console.WriteLine("Enter 1 to 4: ");
                        break;
                }
            }
        }
    }
}