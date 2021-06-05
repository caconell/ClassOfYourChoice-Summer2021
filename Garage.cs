using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_Your_Class
{
    public class Garage
    {
       public List<Car> ListOfCars { get; set; }

        public Garage()
        {
            ListOfCars = new List<Car>();
        }

        public void AddCar(Car car)
        {
            ListOfCars.Add(car);
        }

        public void RemoveCar(int i)
        {
            ListOfCars.RemoveAt(i);
        }

        public void CarInList(int i)
        {
            ListOfCars.ElementAt<Car>(i);
        }

    }
}
