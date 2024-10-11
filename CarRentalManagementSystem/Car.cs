using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagementSystem
{
    public class Car
    {
  

        public int carId { get; set; }
        public string Carname { get; set; }
        public string Model { get; set; }
        public decimal RentPrice { get; set; }

        public Car(int carId, string carname, string model, decimal rentPrice)
        {
            this.carId = carId;
            Carname = carname;
            Model = model;
            RentPrice = rentPrice;
        }

    }
}
