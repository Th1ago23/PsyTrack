namespace Domain.Entity;

public class Patient
{
    public int Id { get; set; }
    public string PatientName { get; set; } = string.Empty;
    public ICollection<Emotional> Emotional { get; set; } = new List<Emotional>();

    public Patient(string patientName, ICollection<Emotional> emotional)
    {
        PatientName = patientName;
        Emotional = emotional;
    }

    public Patient()
    {
    }
}
