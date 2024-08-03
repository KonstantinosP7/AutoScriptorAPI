using AutoPrescriptor.Domain.Models;

namespace AutoScriptor.Infrastructure.Interface;

public interface IDBHandler
{
    public Task<IEnumerable<BreathDevice>> RetrieveBreathDevices();
    public Task InsertNewPrescription(NewPrescription newPrescription);
    public Task<IEnumerable<NewPrescription>> RetrieveDailyPrescriptions(DateTime date);
}
