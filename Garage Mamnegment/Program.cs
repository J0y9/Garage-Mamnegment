namespace Garage_Mamnegment;
class Program
{
    //static List<string> parkedCars = new List<string>();
    //static List<decimal> ticketPrices = new List<decimal>();

    static void Main(string[] args)
    {
        Garage.Start();
        //while (true)
        //{
        //    Console.WriteLine("Car Garage Management System");
        //    Console.WriteLine("1. Park a car");
        //    Console.WriteLine("2. Check out a car");
        //    Console.WriteLine("3. Display parked cars");
        //    Console.WriteLine("4. Display total earnings");
        //    Console.WriteLine("5. Exit");

        //    Console.Write("Enter your choice: ");
        //    string choice = Console.ReadLine();

        //    switch (choice)
        //    {
        //        case "1":
        //            ParkCar();
        //            break;
        //        case "2":
        //            CheckOutCar();
        //            break;
        //        case "3":
        //            DisplayParkedCars();
        //            break;
        //        case "4":
        //            DisplayTotalEarnings();
        //            break;
        //        case "5":
        //            Environment.Exit(0);
        //            break;
        //        default:
        //            Console.WriteLine("Invalid choice. Please try again.");
        //            break;
        //    }
        //}
    }

    //static void ParkCar()
    //{
    //    Console.Write("Enter the car's registration number: ");
    //    string carNumber = Console.ReadLine();

    //    Console.Write("Enter the ticket price: ");
    //    if (decimal.TryParse(Console.ReadLine(), out decimal ticketPrice))
    //    {
    //        parkedCars.Add(carNumber);
    //        ticketPrices.Add(ticketPrice);
    //        Console.WriteLine($"Car {carNumber} parked successfully.");
    //    }
    //    else
    //    {
    //        Console.WriteLine("Invalid ticket price. Please enter a valid number.");
    //    }
    //}

    //static void CheckOutCar()
    //{
    //    Console.Write("Enter the car's registration number to check out: ");
    //    string carNumber = Console.ReadLine();

    //    int carIndex = parkedCars.IndexOf(carNumber);

    //    if (carIndex >= 0)
    //    {
    //        decimal price = ticketPrices[carIndex];
    //        parkedCars.RemoveAt(carIndex);
    //        ticketPrices.RemoveAt(carIndex);

    //        Console.WriteLine($"Car {carNumber} checked out. Payment: {price:C}");
    //    }
    //    else
    //    {
    //        Console.WriteLine($"Car {carNumber} not found in the garage.");
    //    }
    //}

    //static void DisplayParkedCars()
    //{
    //    Console.WriteLine("Parked Cars:");
    //    foreach (var car in parkedCars)
    //    {
    //        Console.WriteLine(car);
    //    }
    //}

    //static void DisplayTotalEarnings()
    //{
    //    decimal totalEarnings = ticketPrices.Sum();
    //    Console.WriteLine($"Total earnings: {totalEarnings:C}");
    //}
}
