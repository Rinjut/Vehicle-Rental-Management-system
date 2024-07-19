public class RentalAgency
{
    private List<Vehicle> fleet;
    private decimal totalRevenue;

    public RentalAgency()
    {
        fleet = new List<Vehicle>();
        totalRevenue = 0;
    }

    public decimal TotalRevenue
    {
        get { return totalRevenue; }
        private set { totalRevenue = value; }
    }

    public void AddVehicle(Vehicle vehicle)
    {
        fleet.Add(vehicle);
    }

    public void RemoveVehicle(Vehicle vehicle)
    {
        fleet.Remove(vehicle);
    }

    public void RentVehicle(Vehicle vehicle, int days)
    {
        if (fleet.Contains(vehicle))
        {
            TotalRevenue += vehicle.RentalPrice * days;
            Console.WriteLine(vehicle.Model+" rented for"+" "+ days+" "+"days" + ". Total charge: "+vehicle.RentalPrice * days+ ":C");
        }
        else
        {
            Console.WriteLine("Vehicle is not available.");
        }
    }

    public void DisplayFleet()
    {
        foreach (var vehicle in fleet)
        {
            vehicle.DisplayDetails();
            Console.WriteLine();
        }
    }
}
