using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleInheritance
{
    public class Car: Vehicle
    {
        public Car()
        {
            Console.WriteLine(" Car:");
        }

        public Car(string model, double mrsp, long vin, DateTime deliveryDate, Boolean soldStatus)
            : base(model, mrsp, vin, deliveryDate, soldStatus)
        {
            Console.WriteLine("Car:");
        }
        public override void Noise()
        {
            Console.WriteLine("car");
        }
    }
}
