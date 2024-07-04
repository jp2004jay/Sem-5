namespace Lab3
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter 1 to Run Program 1 \nEnter 2 to Run Program 2 \nand so on...\nteel Program 8 \nEnter 0 for exit");

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
                        RunOverLoading();
                        break;
                    case "2":
                        RunArea();
                        break;
                    case "3":
                        RunRBI();
                        break;
                    case "4":
                        RunFactorial();
                        break;
                    case "5":
                        RunHospital();
                        break;
                    case "6":
                        RunShape();
                        break;
                    case "7":
                        RunDelegate();
                        break;
                    case "8":
                        RunGenericDelegate();
                        break;
                }
            }
        }
        static void RunOverLoading()
        {
            Overloading overloading = new Overloading();
            overloading.Sum(5, 8);
            overloading.Sum(5.5f, 9.1f);
        }
        static void RunArea()
        {
            Area area = new Area();
            Console.WriteLine("Square Area: {0}", area.FindArea(2.3));
            Console.WriteLine("Rectangle Area: {0}", area.FindArea(1.2, 3.1));
        }
        static void RunRBI()
        {
            RBI sbi = new SBI();
            RBI hdfc = new HDFC();
            RBI icici = new ICICI();

            Console.WriteLine("SBI: {0}", sbi.calculateIntrest(1000, 2));
            Console.WriteLine("HDFC: {0}", hdfc.calculateIntrest(1000, 2));
            Console.WriteLine("ICICI: {0}", icici.calculateIntrest(1000, 2));
        }
        static void RunFactorial()
        {
            Factorial factorial = new Factorial();
            factorial.runmain();
        }

        static void RunHospital()
        {
            Hospital apollo = new Apollo();
            Hospital wh = new Wockhardt();
            Hospital gs = new Gokul_Superspeciality();

            apollo.HospitalDetails();
            wh.HospitalDetails();
            gs.HospitalDetails();
        }

        static void RunShape()
        {
            Shape shape = new Shape();
            Console.WriteLine("Square: {0}", shape.FindArea(2, "S"));
            Console.WriteLine("Ractangle: {0}", shape.FindArea(2, 4));
            Console.WriteLine("Circle: {0}", shape.FindArea(2, "C"));
        }

        static void RunDelegate()
        {
            TrafficDel tdf = new TrafficDel();
            tdf.runMain();
        }
        static void RunGenericDelegate()
        {
            GenericDelegate gd = new GenericDelegate();
            gd.runmain();
        }
    }
}