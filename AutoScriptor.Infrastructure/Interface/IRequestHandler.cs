namespace AutoScriptor.Infrastructure.Interface;

public interface IRequestHandler
{
    public Task<string> HandleRequestPrescriptionRetrieve(string prescriptionNumber);
    public Task<string> HandleRequestPrescriptionExecutionRetrieve(string prescriptionNumber);
    public Task<string> HandleRequestPrescriptionCancel();
    public Task<string> HandleRequestPrescriptionExecution(string prescriptionNumber);
    public Task<string> HandleRequestPrescriptionInsert(string prescriptionNumber);
}
