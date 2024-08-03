namespace AutoPrescriptor.Domain.Models;

public class BreathDevice
{
    public int Id { get; set; }
    public string eDapiCode { get; set; }
    public string ekapty { get; set; }
    public string description { get; set; }
    public decimal? Price { get; set; }
    public string SerialNumber { get; set; }
    public bool? IsActive { get; set; }
}