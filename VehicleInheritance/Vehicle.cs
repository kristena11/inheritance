using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleInheritance
{
    public abstract class Vehicle
    {

        #region Fields
        protected long vin;
        protected DateTime DeliveryDate;
        protected bool SoldStatus;
        protected double mrsp;
        public static int vehicleCount = 0;


        #endregion End of Fields

        #region Constructors 
        public Vehicle()
        {
            
            Model = "unknown";
            mrsp = 0;
            vin = 0;

            SoldStatus = false;
            vehicleCount++;
        }
        public Vehicle(string model, double mrsp, long vin, DateTime deliveryDate, Boolean soldStatus)
        {
            
            Model = model;
            this.mrsp = mrsp;
            this.vin = vin;
            DeliveryDate = deliveryDate;
            SoldStatus = soldStatus;
            vehicleCount++;
        }
        #endregion End of Constructors

        #region Properties

        public string Model { get; set; }
       
        public int VehicleCount
        {
            get
            {
                return vehicleCount;
            }
        }
        public long Vin
        {
            get
            {
                return vin;
            }
            set
            {
                if (value > 0)
                    vin = value;
                else
                    vin = 0;
            }
        }
        public double Mrsp
        {
            get
            {
                return mrsp;
            }
            set
            {
                if (value > 0)
                    mrsp = value;
                else
                    mrsp = 0;
            }
        }
        public DateTime deliveryDate { get; set; }

        public Boolean soldStatus { get; set; }



        #endregion End Properties

        #region Methods

        public bool UpdateStatus() => soldStatus = true;
        public int UpdateInventory() => vehicleCount = vehicleCount - 1;
        public abstract void Noise();
        
       // public override string ToString()
       // {
       //     return $"{Model}\n MRSP:${Mrsp}\n Vin:{Vin}\n Delivered:{DeliveryDate}\n Sold: {soldStatus}\n";
      //  }
        #endregion End of Methods
    }
}
