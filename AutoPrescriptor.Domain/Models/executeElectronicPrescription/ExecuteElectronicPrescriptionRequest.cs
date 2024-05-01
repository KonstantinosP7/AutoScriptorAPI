namespace AutoPrescriptor.Domain.Models.executeElectronicPrescription;

public class ExecuteElectronicPrescriptionRequest
{
    public string? approvalDateStr { get; set; }
    public string? EMessageNumber { get; set; }
    public string? examinedAmka { get; set; }
    public string? examinedFirstname { get; set; }
    public string? examinedLastname { get; set; }
    public string? execDateStr { get; set; }
    public string? inspectorDocCode { get; set; }
    public string? inspectorDocFirstname { get; set; }
    public string? inspectorDocLastname { get; set; }
    public string? issueDateStr { get; set; }
    public string? prescriptionNumber { get; set; }
    public string? prescrDocCode { get; set; }
    public string? prescrDocFirstname { get; set; }
    public string? prescrDocLastname { get; set; }
    public string? supplBranchCode { get; set; }
    public string? userId { get; set; }
    public string? duration_end { get; set; }
    public string? eu_country_id { get; set; }
    public string? eu_foreign_org_id { get; set; }
    public string? eu_org_insured_id { get; set; }
    public string? eu_examined_surname { get; set; }
    public string? eu_examined_firstname { get; set; }
    public string? eu_org_type { get; set; }
    public string? eu_ekaa_no { get; set; }
    public string? eu_ekaa_expiry_date { get; set; }
    public string? eu_ppa_start_date { get; set; }
    public string? eu_ppa_end_date { get; set; }
    public string? eu_examined_Amka_id { get; set; }
    public string? eu_examined_amka_name { get; set; }
    public string? otp { get; set; }
    public string? eu_examined_amka_surname { get; set; }
    public loadFile loadFile { get; set; }
    public prescriptionDetailsList prescriptionDetailsList { get; set; }
    public barcodeMap barcodeMap { get; set; }
}

public record loadFile
{
    public string? pdf { get; set; }
    public string? theFileName { get; set; }
}

public record prescriptionDetailsList
{
    public string? aa { get; set; }
    public string? medicalProcedureId { get; set; }
    public string? quantity { get; set; }
    public string? saveQuantity { get; set; }
    public string? vat { get; set; }
}

public record barcodeMap
{
    public string? proc_aa { get; set; }
    public string? barcode { get; set; }
    public string? ekapty { get; set; }
    public string? qty { get; set; }
    public string? unit_price { get; set; }
}
