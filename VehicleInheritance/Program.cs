using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Ford myFord = new Ford("fusion", 28678.99, 22222222222222222, new DateTime(2016, 2, 24), false);
            Console.WriteLine(myFord.ToString());
            Honda myHonda = new Honda("Civic EX", 18713.27, 33333333333333333, new DateTime(2016, 2, 24), false);
            Console.WriteLine(myHonda.ToString());
            Toyota myToyota = new Toyota("Tacoma", 25221.11, 44444444444444444, new DateTime(2016, 3, 11), false);
            Console.WriteLine(myToyota.ToString());
            Dodge myDodge = new Dodge("Durango", 29500.98, 55555555555555555, new DateTime(2016, 2, 24), false);
            Console.WriteLine(myDodge.ToString());
            Console.WriteLine("TOTAL INVENTORY:" + Vehicle.vehicleCount);
        }
    }
}
