namespace Domain.Entity;

public class Emotional
{
    public int Id { get; private set; }
    public int PatientId { get; set; }
    public required Patient Patient { get; set; }
    public string Resume { get; set; } = string.Empty;

    
}
