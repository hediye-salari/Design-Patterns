using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.FactoryMethodPattern.Vehicle
{
    public class CarFactory : VehicleFactory
    {
        public override IVehicle CreateVehicle()
        {
            return new Car();
        }
    }

    public class MotorcycleFactory : VehicleFactory
    {
        public override IVehicle CreateVehicle()
        {
            return new Motorcycle();
        }
    }
    public class TruckFactory : VehicleFactory
    {
        public override IVehicle CreateVehicle()
        {
            return new Truck();
        }
    }
}
