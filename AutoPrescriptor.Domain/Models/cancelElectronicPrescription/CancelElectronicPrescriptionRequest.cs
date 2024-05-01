namespace AutoPrescriptor.Domain.Models.cancelElectronicPrescription;

public class CancelElectronicPrescriptionRequest
{
    public string? EMessageNumber { get; set; }
    public string? examinedAmka { get; set; }
    public string? issueDate { get; set; }
    public string? prescriptReferNumber { get; set; }
    public string? supplBranchCode { get; set; }
    public string? userId { get; set; }
}
