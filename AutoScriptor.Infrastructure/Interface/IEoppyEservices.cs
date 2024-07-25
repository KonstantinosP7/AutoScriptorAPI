using AutoPrescriptor.Domain.Models;
using static AutoScriptorForm.XMLObjects;

namespace AutoScriptor.Infrastructure.Interface;

public interface IEoppyEservices
{
    public Task<EPrescription> PrescriptionRetrieve(string prescriptionNumber);
    public Task<SubmissionPrintOut> PrescriptionExecutionRetrieve(string invSeqNum, string codeSeq);
    public Task<SubmissionCancelOut> PrescriptionCancel(string examinedAmka, string issueDate, string prescriptionNumber);
    public Task<ReturnBarcode> RetrieveBreathBarcodes(string serialNumber, string ekapty, int days);
    public Task<ResultBeanEPrescription> PrescriptionExecution(PrescriptionExecutionModel prescriptionToExecute);    
}
