using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_Your_Class
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Nickname { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }

        public Car()
        {
        }

        public Car(string make, string model, string nickname, int mileage)
        {
            Make = make;
            Model = model;
            Nickname = nickname;
            Mileage = mileage;
        }

        public void UpdateMileage(int updatedMileage)
        {
            if ((updatedMileage - Mileage) >= 5000)
            {
                Console.WriteLine("Time for Service! Please Schedule a visit to your mechanic");
                Mileage = updatedMileage;
            }
            else
            {
                Mileage = updatedMileage;
            }
        }

        public int GetMileage()
        {
            return Mileage;
        }

        public void MilesUntilService(int updatedMileage)
        {
            if ((updatedMileage - Mileage) >= 5000)
            {
                Console.WriteLine("Time for Service! Please Schedule a visit to your mechanic");
                Mileage = updatedMileage;
            }
            else if ((updatedMileage - Mileage) <= 5000)
            {
                Console.WriteLine($"{(5000 - (updatedMileage - Mileage))} miles until next service");
                Mileage = updatedMileage;
            }
        }
    }
}