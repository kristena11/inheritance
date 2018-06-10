using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleInheritance
{
    public class Dodge : Truck
    {
        public Dodge()
        {
            Console.WriteLine(" I am a Dodge");
        }

        public Dodge(string model, double mrsp, long vin, DateTime deliveryDate, Boolean soldStatus)
            : base(model, mrsp, vin, deliveryDate, soldStatus)
        {
            Console.WriteLine("I am a Dodge {Model}\n MRSP:${Mrsp}\n Vin:{Vin}\n Delivered:{DeliveryDate}\n Sold: {soldStatus}\n");
        }
        public override void Noise()
        {
            
            
        }
        
    }
}
