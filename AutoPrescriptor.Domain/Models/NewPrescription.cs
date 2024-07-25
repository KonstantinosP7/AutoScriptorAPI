namespace AutoPrescriptor.Domain.Models;

public class NewPrescription
{
    public int Id { get; set; }
    public DateTime ExecutionDate { get; set; }
    public required string PrescriptionData { get; set; }
}