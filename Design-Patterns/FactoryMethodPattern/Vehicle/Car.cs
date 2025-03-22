using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.FactoryMethodPattern.Vehicle
{
    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a car!");
        }
    }
    public class Motorcycle : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Riding a motorcycle!");
        }
    }

    public class Truck : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a truck!");
        }
    }

}
