namespace AutoScriptor.Infrastructure.Interface;

public interface IEoppyEservices
{
    public Task<string> PrescriptionRetrieve(string prescriptionNumber, string supplBranchCode, string eMessageNumber);
}
