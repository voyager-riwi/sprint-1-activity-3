namespace sprint_1_activity_3.Clases;

public class Reservation
{
    public int RoomNumber { get; set; }
    public string GuestName { get; set; }
    public int Nights { get; set; }
    public double PricePerNight { get; set; }

    public Reservation(int roomNumber, string guestName, int nights, double pricePerNight)
    {
        RoomNumber = roomNumber;
        GuestName = guestName;
        Nights = nights;
        PricePerNight = pricePerNight;
    }

    public string GetInfo()
    {
        return $"Habitación: {RoomNumber}, Huésped: {GuestName}, Noches: {Nights}, Precio/Noche: {PricePerNight}";
    }

    public double CalculateCost()
    {
        return Nights * PricePerNight;
    }
}

public class Hotel
{
    private List<Reservation> reservations = new List<Reservation>();

    public void RegisterReservation(int roomNumber, string guestName, int nights, double pricePerNight)
    {
        reservations.Add(new Reservation(roomNumber, guestName, nights, pricePerNight));
    }

    public Reservation GetReservation(int roomNumber)
    {
        return reservations.FirstOrDefault(r => r.RoomNumber == roomNumber);
    }

    public double CalculateTotalCost(int roomNumber)
    {
        Reservation reservation = GetReservation(roomNumber);
        if (reservation != null)
        {
            return reservation.CalculateCost();
        }
        return 0;
    }
}