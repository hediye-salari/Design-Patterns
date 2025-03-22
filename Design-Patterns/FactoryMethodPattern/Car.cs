using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.FactoryMethodPattern
{
    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a car!");
        }
    }

}
