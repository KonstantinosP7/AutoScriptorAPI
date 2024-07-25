namespace AutoPrescriptor.Domain.Models;

public class BreathDevices
{
    public int Id { get; set; }
    public string eDapiCode { get; set; }
    public string ekapty { get; set; }
    public string description { get; set; }
    public decimal? Price { get; set; }
}