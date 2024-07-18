using AutoPrescriptor.Domain.Models;
using static AutoScriptorForm.XMLObjects;

namespace AutoScriptor.Infrastructure.Interface;

public interface IEoppyEservices
{
    public Task<EPrescription> PrescriptionRetrieve(string prescriptionNumber);
    public Task<string> PrescriptionExecutionRetrieve(string invSeqNum, string codeSeq, string supplBranchCode, string eMessageNumber);
    public Task<string> PrescriptionCancel(string issueDate, string prescriptReferNumber, string userId, string supplBranchCode, string eMessageNumber);
    public Task<string> PrescriptionExecution(PrescriptionExecutionModel prescriptionToExecute);
    public Task<string> RetrieveBreathBarcodes(string serialNumber, int days);
}
