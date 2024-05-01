namespace AutoPrescriptor.Domain.Models.executeElectronicPrescription
{
    public class ExecuteElectronicPrescriptionResponse
    {
        public submissionOut submissionOut { get; set; }
        public prescriptionExceptions prescriptionExceptions { get; set; }
    }

    public record submissionOut
    {
        public string? invSeqNum { get; set; }
        public string? codeSeq { get; set; }
        public string? status { get; set; }
    }
    public record prescriptionExceptions
    {
        public string? errorCode { get; set; }
        public string? descr { get; set; }
        public string? insertDate { get; set; }
    }
}
