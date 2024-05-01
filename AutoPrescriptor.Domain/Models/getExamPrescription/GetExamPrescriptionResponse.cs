namespace AutoPrescriptor.Domain.Models.getExamPrescription;

internal class GetExamPrescriptionResponse
{
    public string? examinedAmka { get; set; }
    public string? examinedLastname { get; set; }
    public string? examinedFirstname { get; set; }
    public string? issueDateStr { get; set; }
    public string? prescrDocCode { get; set; }
    public string? prescrDocFirstname { get; set; }
    public string? prescrDocLastname { get; set; }
    public string? covid19 { get; set; }
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
    public string? eu_examined_amka_surname { get; set; }
    public examinationFirstList examinationFirstList { get; set; }
    public prescriptionPrintOut prescriptionPrintOut { get; set; }
}

internal class examinationFirstList
{
    public string? aa { get; set; }
    public string? eDapiCode { get; set; }
    public string? description { get; set; }
    public string? quantity { get; set; }
}

internal class prescriptionPrintOut
{
    public string? fileData { get; set; }
    public string? fileName { get; set; }
}
