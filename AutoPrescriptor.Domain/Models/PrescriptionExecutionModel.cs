namespace AutoPrescriptor.Domain.Models;

public class PrescriptionExecutionModel
{
    public string? duration_end { get; set; }
    public string? examinedAmka { get; set; }
    public string? examinedFirstname { get; set; }
    public string? examinedLastname { get; set; }
    public string? execDateStr { get; set; }
    public string? issueDateStr { get; set; }
    public string? prescrDocCode { get; set; }
    public string? prescrDocFirstname { get; set; }
    public string? prescrDocLastname { get; set; }
    public string? prescriptionNumber { get; set; }
    public IEnumerable<PrescriptionDetail>? prescriptionDetailsList { get; set; }
}

public record PrescriptionDetail
{
    public string aa { get; set; }
    public string medicalProcedureId { get; set; }
    public string vat { get; set; }
    public string quantity { get; set; }
    public string saveQuantity { get; set; }
    public IEnumerable<BarcodeMapInput> barcodeMap { get; set; }
}

public class BarcodeMapInput
{
    public string? proc_aa { get; set; }
    public string? barcode { get; set; }
    public string? ekapty { get; set; }
    public string? qty { get; set; }
    public string? unit_price { get; set; }
}