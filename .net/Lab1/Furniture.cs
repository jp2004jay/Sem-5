using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Furniture
    {
        String material;
        double price;

        public Furniture()
        {
            Console.WriteLine("Enter Material: ");
            material = Console.ReadLine();

            Console.WriteLine("Enter Price: ");
            price = Convert.ToDouble(Console.ReadLine());
        }

        public String GetMaterial()
        { 
            return material;
        }

        public double GetPrice()
        {
            return price;
        }
    }

    internal class Table : Furniture
    {
        double Height;
        double surface_area;

        public Table()
        {
            Console.WriteLine("Enter Height: ");
            Height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter surface_area: ");
            surface_area = Convert.ToDouble(Console.ReadLine());
        }

        public void printDetails()
        {
            Console.WriteLine("Material: {0} \nPrice: {1} \nHeight: {2} \nSurface Area: {3}", GetMaterial(), GetPrice(), Height, surface_area);
        }
    }
}
