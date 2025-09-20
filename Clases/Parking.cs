namespace sprint_1_activity_3.Clases;

public class Vehicle
{
    public string Plate { get; set; }
    public string Brand { get; set; }
    public DateTime EntryTime { get; set; }

    public Vehicle(string plate, string brand)
    {
        Plate = plate;
        Brand = brand;
        EntryTime = DateTime.Now; 
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Placa: {Plate} | Marca: {Brand} | Hora entrada: {EntryTime}");
    }
}

public static class Parking
{
    private static List<Vehicle> vehicles = new List<Vehicle>();
    private static decimal ratePerHour = 2000m; 

    public static void RegisterEntry(string plate, string brand)
    {
        Vehicle newVehicle = new Vehicle(plate, brand);
        vehicles.Add(newVehicle);
    }

    public static decimal RegisterExit(string plate)
    {
        Vehicle vehicle = vehicles.Find(v => v.Plate == plate);

        if (vehicle == null)
        {
            return -1; 
        }

        DateTime exitTime = DateTime.Now;
        TimeSpan duration = exitTime - vehicle.EntryTime;

        // Redondeamos las horas
        int hours = (int)Math.Ceiling(duration.TotalHours);

        decimal amount = hours * ratePerHour;

        vehicles.Remove(vehicle); 

        return amount;
    }

    public static List<Vehicle> GetVehicles()
    {
        return vehicles;
    }
}