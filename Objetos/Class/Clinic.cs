namespace Objetos.Class;

public class Clinic
{
    public string namePatient;
    public string specialty;
    public DateTime dateAppointment;
    private List<Clinic> clinics = new List<Clinic>();
    
    public void menu()
    {
        Console.WriteLine("======MENU======\n" +
                          "1 - Registrar cita\n" +
                          "2 - Consultar citas\n" +
                          "3 - Dias para la cita\n" +
                          "4 - Sair\n");
    }
    
    public void add(string namePatient, string specialty, DateTime dateAppointment)
    {
        clinics.Add(new Clinic { namePatient = namePatient, specialty = specialty, dateAppointment = dateAppointment });
    }
    
    public Clinic consultClinic(string namePatient)
    {
        var clinic = clinics.Find(c => c.namePatient == namePatient);
        
        if (clinic != null)
        {
            return clinic;
        }
        else
        {
            return null;
        }
    }

    public int missingDays(string namePatient)
    {
        var clinic = consultClinic(namePatient);

        if (clinic != null)
        {
            int days = (clinic.dateAppointment.Date - DateTime.Now).Days;
            return days >= 0 ? days : 0;
        }
        else
        {
            return 0;
        }
    }
}