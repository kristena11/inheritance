using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleInheritance
{
    public class Toyota : Truck
    {
        public Toyota()
        {
            Console.WriteLine(" I am a Toyota");
        }

        public Toyota(string model, double mrsp, long vin, DateTime deliveryDate, Boolean soldStatus)
            : base(model, mrsp, vin, deliveryDate, soldStatus)
        {
            Console.WriteLine("I am a Toyota {Model}\n MRSP:${Mrsp}\n Vin:{Vin}\n Delivered:{DeliveryDate}\n Sold: {soldStatus}\n");
        }
        public override void Noise()
        {
            //Console.WriteLine("Toyota");
        }
    }
}
