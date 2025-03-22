using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{

    public interface Ivehicle
    {
        void Drive();
    }

    public class Car: Ivehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving car.....");
            
        }
    }

    public class Bike : Ivehicle
    { 
        public void Drive()
        {
            Console.WriteLine("Ridding bike....");
        }
    }

    public class vehicleFactory
    {
        public static Ivehicle GetIvehicle(string vehiclename)
        {
                Ivehicle obj = null;
            
                if (vehiclename.ToLower().Equals("car"))
                {
                    obj = new Car();

                }

                else if (vehiclename.ToLower().Equals("bike"))
                {
                    obj = new Bike();
                }
                
                 return obj ;
               
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Ivehicle vehicle1 = vehicleFactory.GetIvehicle("Car");
            vehicle1.Drive();

            Ivehicle vehicle2 = vehicleFactory.GetIvehicle("Bike");
            vehicle2.Drive();

            Console.ReadLine();


        }
    }
}
