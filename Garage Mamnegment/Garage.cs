using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Garage_Mamnegment
{
    public class Garage
    {
        public static List<Car> ParkedCars = Car.FactoryCarList();
        public static List<decimal> GarageEarnings = new();

        public static void Start()
        {
            while (true)
            {
                Console.WriteLine("Car Garage Management System");
                Console.WriteLine("1. Park a car");
                Console.WriteLine("2. Check out a car");
                Console.WriteLine("3. Display parked cars");
                Console.WriteLine("4. Display total earnings");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Car.ParkCar();
                        break;
                    case "2":
                        Car.CheckOutCar();
                        break;
                    case "3":
                        DisplayParkedCars();
                        break;
                    case "4":
                        DisplayTotalEarnings();
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
        static void DisplayParkedCars()
        {
            Console.WriteLine("Parked Cars:");
            foreach (var car in ParkedCars)
            {
                if (car.IsParked)
                {
                    
                Console.WriteLine(Car.GetCarNumber(car));
                }
            }
        }

        static void DisplayTotalEarnings()
        {
            decimal totalEarnings = GarageEarnings.Sum();
            Console.WriteLine($"Total earnings: {totalEarnings:C}");
        }

    }

}
