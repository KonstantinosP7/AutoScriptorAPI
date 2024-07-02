namespace AutoScriptor.Infrastructure.Interface;

public interface IEoppyEservices
{
    public Task<string> PrescriptionRetrieve(string prescriptionNumber, string supplBranchCode, string eMessageNumber);
    public Task<string> PrescriptionExecutionRetrieve(string invSeqNum, string codeSeq, string supplBranchCode, string eMessageNumber);
    public Task<string> PrescriptionCancel(string issueDate, string prescriptReferNumber, string userId, string supplBranchCode, string eMessageNumber);
}
