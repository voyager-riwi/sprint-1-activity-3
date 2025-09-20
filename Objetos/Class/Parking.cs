namespace Objetos.Class;

public class Parking
{
    public string plate;
    public string brand;
    public DateTime hourIn;
    public DateTime? hourOut;

    private List<Parking> parking = new List<Parking>();
    private const decimal TarifaHora = 2000m;

    public void menu()
    {
        Console.WriteLine("======MENU======\n" +
                          "1 - Registrar entrada\n" +
                          "2 - Registrar salida\n" +
                          "3 - Valor parking\n" +
                          "4 - Sair\n");
    }

    public void add(string plate, string brand)
    {
        parking.Add(new Parking { plate = plate, brand = brand, hourIn = DateTime.Now, hourOut = null});
    }
    public void registerExit(string plate)
    {
        Parking v = parking.Find(p => p.plate == plate);
        v.hourOut = DateTime.Now;
    }
    public decimal valueParking(string plate)
    {
        Parking v = parking.Find(p => p.plate == plate);
        DateTime salid = v.hourOut ?? DateTime.Now;
        if (salid <= v.hourIn) return 0m;

        TimeSpan during = salid - v.hourIn;

        int hours = (int)Math.Ceiling(during.TotalHours);

        decimal totalPay = hours * TarifaHora;
        return totalPay;

    }
}