using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleInheritance
{
    public class Truck: Vehicle
    {
        public Truck()
        {
            Console.WriteLine(" Truck:");
        }

        public Truck(string model, double mrsp, long vin, DateTime deliveryDate, Boolean soldStatus)
            : base(model, mrsp, vin, deliveryDate, soldStatus)
        {
            Console.WriteLine("Truck:");
        }
        public override void Noise()
        {
            //Console.WriteLine("Truck");
        }
    }
}
