using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleInheritance
{
    public class Honda : Car
    {
        public Honda()
        {
            Console.WriteLine(" I am a Honda");
        }

        public Honda(string model, double mrsp, long vin, DateTime deliveryDate, Boolean soldStatus)
            : base(model, mrsp, vin, deliveryDate, soldStatus)
        {
            Console.WriteLine("I am a Honda {Model}\n MRSP:${Mrsp}\n Vin:{Vin}\n Delivered:{DeliveryDate}\n Sold: {soldStatus}\n");
        }
        public override void Noise()
        {
            //Console.WriteLine("Honda");
        }
    }
}
