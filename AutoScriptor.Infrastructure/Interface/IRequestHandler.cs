using AutoPrescriptor.Domain.Models;
using static AutoScriptorForm.XMLObjects;

namespace AutoScriptor.Infrastructure.Interface;

public interface IRequestHandler
{
    public Task<EPrescription> HandleRequestPrescriptionRetrieve(string prescriptionNumber);
    public Task<SubmissionPrintOut> HandleRequestPrescriptionExecutionRetrieve(string invSeqNo, string codeSeq);
    public Task<SubmissionCancelOut> HandleRequestPrescriptionCancel(string prescriptionNumber);
    public Task<ReturnBarcode> HandleRequestRetrieveBreathCodes(string serialNumber, string ekapty, int days);
    public Task<ResultBeanEPrescription> HandleRequestPrescriptionExecution(string prescriptionNumber);
    public Task<string> HandleRequestPrescriptionInsert(string prescriptionNumber);
    public Task<IEnumerable<NewPrescription>> HandleRequestExecuteDailyPrescriptions(DateTime date);
}
