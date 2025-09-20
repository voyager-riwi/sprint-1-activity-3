namespace Objetos.Class;

public class Hotel
{
    public int numberRooms;
    public string nameGuest;
    public int quantityNights;
    private List<Hotel> hotels = new List<Hotel>();
    private const decimal CostStay = 10000m;
    
    public void menu()
    {
        Console.WriteLine("======MENU======\n" +
                          "1 - Registrar reserva\n" +
                          "2 - Consultar reserva\n" +
                          "3 - Costo estadia reserva\n" +
                          "4 - Sair\n");
    }
    
    public void add(int numberRooms, string nameGuest, int quantityNights)
    {
        hotels.Add(new Hotel { numberRooms = numberRooms, nameGuest = nameGuest, quantityNights = quantityNights });
    }

    public Hotel consultHotel(string nameGuest)
    {
        var hotel = hotels.Find(h => h.nameGuest == nameGuest);

        if (hotel != null)
        {
            return hotel;
        }
        else
        {
            return null;       ;
        }
    }
    
    public Hotel consultHotelByRoom(int numberRoom)
    {
        return hotels.Find(h => h.numberRooms == numberRoom);
    }

    public decimal cost(int numberRoom, decimal ratePerNight)
    {
        var reservation = consultHotelByRoom(numberRoom);
        if (reservation == null)
        {
            return 0m;
        }

        return ratePerNight * reservation.quantityNights;
    }

}