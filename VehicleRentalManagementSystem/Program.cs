using System;

class Program
{
    static void Main(string[] args)
    {
        RentalAgency agency = new RentalAgency();

        Car car = new Car
        {
            Model = "Model S",
            Manufacturer = "Tesla",
            Year = 2022,
            RentalPrice = 200m,
            Seats = 5,
            EngineType = "Electric",
            Transmission = "Automatic",
            Convertible = false
        };

        Truck truck = new Truck
        {
            Model = "F-150",
            Manufacturer = "Ford",
            Year = 2021,
            RentalPrice = 150m,
            Capacity = 1.5,
            TruckType = "Pickup",
            FourWheelDrive = true
        };

        Motorcycle motorcycle = new Motorcycle
        {
            Model = "Ninja ZX-10R",
            Manufacturer = "Kawasaki",
            Year = 2022,
            RentalPrice = 100m,
            EngineCapacity = 998,
            FuelType = "Petrol",
            HasFairing = true
        };

        agency.AddVehicle(car);
        agency.AddVehicle(truck);
        agency.AddVehicle(motorcycle);

        Console.WriteLine("Initial Fleet:");
        agency.DisplayFleet();

        Console.WriteLine("\nRenting the car for 3 days:");
        agency.RentVehicle(car, 3);

        Console.WriteLine("\nFleet after renting the car:");
        agency.DisplayFleet();

        Console.WriteLine($"\nTotal Revenue: {agency.TotalRevenue:C}");
    }
}
