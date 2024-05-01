namespace AutoPrescriptor.Domain.Models.getExamPrescription;

public class GetExamPrescriptionRequest
{
    public string? prescriptionNumber { get; set; }
    public string? EMessageNumber { get; set; }
    public string? supplBranchCode { get; set; }
}
