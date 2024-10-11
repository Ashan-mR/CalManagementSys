using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagementSystem
{
    public class CarManager
    {
        private List<Car> cars=new List<Car>();
        private int carID = 1;

        public void CreateCar(string Carname,string Model,decimal RentPrice)
        {
            var car = new Car(carID++, Carname, Model, RentPrice);
            cars.Add(car);
            Console.WriteLine("Car Added Successfully");
        }
        public void ReadCars()
        {
            if (cars.Count == 0)
            {
                Console.WriteLine("No Cars Adeed");
            }
            foreach (var car in cars)
            {
                Console.WriteLine("List of Cars");
                Console.WriteLine(car);
            }
        }
        public void UpdateCars(int carId, string Carname, string Model, decimal RentPrice)
        {
            var car =cars.Find(c => c.carId == carId);

            if (car == null)
            {
                Console.WriteLine("Car Not found");
                return;
            }
            cars.Remove(car);
            CreateCar(Carname, Model, RentPrice);
            Console.WriteLine("Car updated succesfully");

        }
        public void DeleteCars(int carId)
        {
            var car = cars.Find(c => c.carId == carId);
            if(car == null)
            {
                Console.WriteLine("Car Not found");
                return;
            }
            cars.Remove(car);
            Console.WriteLine("Car deletedd succesfully");
        }

    }
}
