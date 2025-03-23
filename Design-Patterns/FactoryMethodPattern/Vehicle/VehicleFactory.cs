using Design_Patterns.AbstractFactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.FactoryMethodPattern.Vehicle
{
    public abstract class VehicleFactory
    {
        public abstract IVehicle CreateVehicle();
        public void DeliverVehicle()
        {
            var vehicle = CreateVehicle();
            Console.WriteLine("Delivering the vehicle...");
            vehicle.Drive();
        }

        public static implicit operator VehicleFactory(WindowsFactory v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator VehicleFactory(MacOSFactory v)
        {
            throw new NotImplementedException();
        }
    }
}
