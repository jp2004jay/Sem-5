using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    abstract class Hospital
    {
        abstract public void HospitalDetails();
    }
    class Apollo : Hospital
    {
        override public void HospitalDetails()
        {
            Console.WriteLine("Name: Apollo \nHowmany Doctors: 800");
        }
    }

    class Wockhardt : Hospital
    {
        override public void HospitalDetails()
        {
            Console.WriteLine("Name: Wockhardt \nHowmany Doctors: 300");
        }
    }

    class Gokul_Superspeciality : Hospital
    {
        override public void HospitalDetails()
        {
            Console.WriteLine("Name: Gokul Superspeciality \nHowmany Doctors: 900");
        }
    }
}
