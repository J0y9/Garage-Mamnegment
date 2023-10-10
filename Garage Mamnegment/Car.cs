using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Mamnegment
{
    public class Car
    {
        private string RegistrationNumber { get; set; }
        private decimal TicketPrice { get; set; }
        public bool IsParked { get; set; } 

        public Car(string rn,decimal ticketPrice, bool isParked)
        {
            RegistrationNumber = rn;
            TicketPrice = ticketPrice;
            IsParked = isParked;
        }

        public static void ParkCar()
        {
            Console.Write("Enter the car's registration number: ");
            string carNumber = Console.ReadLine();

            Console.Write("Enter the ticket price: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal ticketPrice))
            {
                Garage.ParkedCars.Add(new Car(carNumber,ticketPrice,true));
                Garage.GarageEarnings.Add(ticketPrice);
                Console.WriteLine($"Car {carNumber} parked successfully.");
            }
            else
            {
                Console.WriteLine("Invalid ticket price. Please enter a valid number.");
            }
        }
        public static void CheckOutCar()
        {
            Console.Write("Enter the car's registration number to check out: ");
            string carNumber = Console.ReadLine();

            var carToFind = Garage.ParkedCars.FirstOrDefault(c=>c.RegistrationNumber == carNumber && c.IsParked);

            if (carToFind != null)
            {

                carToFind.IsParked = false;
                Console.WriteLine($"Car {carNumber} checked out. Payment: {carToFind.TicketPrice:C}");
            }
            else
            {
                Console.WriteLine($"Car {carNumber} not found in the garage.");
            }
        }

        public static List<Car> FactoryCarList()
        {
            return new List<Car>();
        }

        public static string GetCarNumber(Car car)
        {
            return car.RegistrationNumber;
        }

    }
}
