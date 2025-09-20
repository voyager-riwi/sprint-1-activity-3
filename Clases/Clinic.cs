namespace sprint_1_activity_3.Clases;

public class Appointment
{
    public string PatientName { get; private set; }
    public string Specialty { get; private set; }
    public DateTime AppointmentDate { get; private set; }

    public Appointment(string patientName, string specialty, DateTime appointmentDate)
    {
        PatientName = patientName;
        Specialty = specialty;
        AppointmentDate = appointmentDate;
    }

    public string GetInfo()
    {
        return $"Paciente: {PatientName}, Especialidad: {Specialty}, Fecha: {AppointmentDate.ToShortDateString()}";
    }

    public int DaysUntilAppointment()
    {
        TimeSpan difference = AppointmentDate - DateTime.Now;
        return (int)difference.TotalDays;
    }
}

public class Clinic
{
    private List<Appointment> appointments = new List<Appointment>();

    public void RegisterAppointment(string patientName, string specialty, DateTime appointmentDate)
    {
        appointments.Add(new Appointment(patientName, specialty, appointmentDate));
    }

    public Appointment GetAppointment(string patientName)
    {
        return appointments.FirstOrDefault(a => a.PatientName == patientName);
    }
}