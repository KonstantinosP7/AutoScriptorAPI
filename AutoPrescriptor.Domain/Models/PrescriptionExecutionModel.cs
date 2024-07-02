namespace AutoPrescriptor.Domain.Models;

public record PrescriptionExecutionModel(
    string EMessageNumber,
    string duration_end,
    string examinedAmka,
    string examinedFirstname,
    string examinedLastname,
    string execDateStr,
    string issueDateStr,
    string prescrDocCode,
    string prescrDocFirstname,
    string prescrDocLastname,
    string prescriptionNumber,
    string supplBranchCode,
    string userId,
    IEnumerable<PrescriptionDetail> prescriptionDetailsList
    );

public record PrescriptionDetail(
    string aa,
    string medicalProcedureId,
    string vat,
    string quantity,
    string saveQuantity,
    IEnumerable<BarcodeMap> barcodeMap
    );

public record BarcodeMap(
    string proc_aa,
    string barcode,
    string ekapty,
    string qty,
    string unit_price
    );

