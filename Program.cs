using System;
using System.Collections.Generic;

namespace Choose_Your_Class
{
    class Program
    {
         public static Garage myGarage = new Garage();
        
        static void Main(string[] args)
        {
            

            Console.WriteLine("Welcome to Car Service Tracker");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

            DisplayMenu();

        }
        public static void DisplayMenu()
        {
            bool carMenu = true;
            while (carMenu)
            {
                Car myCar = new Car();
                Console.Clear();
                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("1. Add Car");
                Console.WriteLine("2. Car Information");
                Console.WriteLine("3. Update Mileage");
                Console.WriteLine("4. Next Service");
                Console.WriteLine("5. Remove Existing Car");
                Console.WriteLine("6. Exit");

                string menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        Console.WriteLine("Enter a make for this car: ");
                        string carMake = Console.ReadLine();
                        Console.WriteLine("Enter a model for this car: ");
                        string carModel = Console.ReadLine();
                        Console.WriteLine("Enter a name for this car: ");
                        string carName = Console.ReadLine();
                        Console.WriteLine("Enter the mileage for this car: ");
                        int carMileage = Convert.ToInt32(Console.ReadLine());
                        
                        myCar = new Car(carMake, carModel, carName, carMileage);
                        myGarage.AddCar(myCar);
                        break;
                    case "2":
                        CarList();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Choose a car to update: ");
                        CarList();
                        string userInput = Console.ReadLine();
                        myCar = myGarage.ListOfCars.Find(C => C.Nickname == userInput);
                        Console.WriteLine("What is the current mileage?");
                        int mileageUpdate = Convert.ToInt32(Console.ReadLine()); 
                        myCar.UpdateMileage(mileageUpdate);
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Choose a car to check on next service : ");
                        CarList();                       
                        int userCheck = Convert.ToInt32(Console.ReadLine());
                        myCar = myGarage.ListOfCars[userCheck - 1];
                        Console.WriteLine("What is the current mileage?");
                        int mileageCheck = Convert.ToInt32(Console.ReadLine());
                        myCar.MilesUntilService(mileageCheck);
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Choose a car to remove: ");
                        CarList();
                        //int index = 1;
                        //foreach (var car in myGarage.ListOfCars)
                        //{
                        //    Console.WriteLine($"{index}. {car.Nickname}");
                        //    index++;
                        //}
                        int userChoice = Convert.ToInt32(Console.ReadLine());
                        myGarage.RemoveCar(userChoice - 1);
                        break;
                    case "6":
                        Console.WriteLine("Thank you");
                        carMenu = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }

                Console.WriteLine("Press any key to continue");
                Console.ReadKey();

            }
        }

        public static void CarList()
        {
            int index = 1;
            foreach (var car in myGarage.ListOfCars)
            {
                Console.WriteLine($"{index}. {car.Nickname}: {car.Make} {car.Model},{car.Mileage}mi");
                index++;
            }
        }
        //public void MilesUntilService(int mileageUpdate)
        //{
        //    if ((mileageUpdate - myCar.Mileage) >= 5000)
        //    {
        //        Console.WriteLine("Time for Service! Please Schedule a visit to your mechanic");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{mileageUpdate - myCar.Mileage} miles until next service");
        //    }
        //}

    }
}
