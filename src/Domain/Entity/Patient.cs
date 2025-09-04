namespace Domain.Entity;

public class Patient
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public ICollection<Emotional> Emotional { get; set; } = new List<Emotional>();
}
