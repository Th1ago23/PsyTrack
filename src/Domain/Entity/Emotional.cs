using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity;

public class Emotional
{
    [Key]
    public int Id { get; set; }
    public int PatientId { get; set; }
    [ForeignKey("PatientId")]
    public Patient Patient { get; set; }
    public DateTime GeneratedDate { get; set; }
    public DateTime BeginPeriodDate { get; set; }
    public DateTime EndPeriodDate { get; set; }
    [Column(TypeName = "text")]
    public string ResumeText { get; set; } = string.Empty;
    [Column(TypeName = "text")]
    public string Prompt { get; set; } = string.Empty;
    public string ModelIa { get; set; } = string.Empty;

    public Emotional(Patient patient, DateTime generatedDate, DateTime beginPeriodDate, DateTime endPeriodDate, string resumeText, string prompt, string modelIa)
    {
        Patient = patient;
        GeneratedDate = generatedDate;
        BeginPeriodDate = beginPeriodDate;
        EndPeriodDate = endPeriodDate;
        ResumeText = resumeText;
        Prompt = prompt;
        ModelIa = modelIa;
    }

    public Emotional () { }
}
