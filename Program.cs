using System;
using System.Collections.Generic;
using System.Linq;

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
                        myGarage.CarList();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Type the Nickname of car you wnat to update: ");
                        myGarage.CarList();
                        string nickname = Console.ReadLine();
                        myCar = myGarage.ListOfCars.FirstOrDefault(car => car.Nickname == nickname);
                        if(myCar == null)
                        {
                            Console.WriteLine("Try again");
                            break;
                        }
                        Console.WriteLine("What is the current mileage?");
                        int mileageUpdate = Convert.ToInt32(Console.ReadLine()); 
                        myCar.UpdateMileage(mileageUpdate);
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Choose a car to check on next service : ");
                        myGarage.CarList();                       
                        int carIndex = Convert.ToInt32(Console.ReadLine());
                        if (carIndex > myGarage.ListOfCars.Count || carIndex <= 0)
                        {
                            Console.WriteLine("Invalid Input");
                            break;
                        }
                        Console.WriteLine("What is the current mileage?");
                        int mileageCheck = Convert.ToInt32(Console.ReadLine()); 
                        myGarage.ListOfCars[carIndex - 1].MilesUntilService(mileageCheck);
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Choose a car to remove: ");
                        myGarage.CarList();
                        int userChoice = Convert.ToInt32(Console.ReadLine());
                        if (userChoice > myGarage.ListOfCars.Count || userChoice <= 0)
                        {
                            Console.WriteLine("Invalid Input");
                            break;
                        }
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

    }
}
