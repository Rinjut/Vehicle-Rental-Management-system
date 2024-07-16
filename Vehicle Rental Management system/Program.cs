class Program
{
    static void Main(string[] args)
    {
        RentalAgency agency = new RentalAgency();

        Car car = new Car
        {
            Model = "Accord sedan",
            Manufacturer = "Honda",
            Year = 2024,
            RentalPrice = 1000,
            Seats = 5,
            EngineType = "V6",
            Transmission = "Automatic",
            Convertible = false
        };

        Truck truck = new Truck
        {
            Model = "BelAZ 75710",
            Manufacturer = "BelAZ",
            Year = 2013,
            RentalPrice = 1500,
            Capacity = 3,
            TruckType = "Pickup",
            FourWheelDrive = false
        };

        Motorcycle motorcycle = new Motorcycle
        {
            Model = "DAX125",
            Manufacturer = "Honda",
            Year = 2022,
            RentalPrice = 800,
            EngineCapacity = 650,
            FuelType = "Petrol",
            HasFairing = true
        };

        agency.AddVehicle(car);
        agency.AddVehicle(truck);
        agency.AddVehicle(motorcycle);

        Console.WriteLine("Rental vehicle Fleet information:");
        agency.DisplayFleet();

        Console.WriteLine("List of renting vehicles:");
        agency.RentVehicle(car, 3);
        agency.RentVehicle(truck, 5);

        Console.WriteLine($"Total Revenue: {agency.TotalRevenue:C}");
    }
}
