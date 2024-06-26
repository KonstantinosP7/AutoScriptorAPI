using AutoScriptor.Infrastructure.Interface;

namespace AutoScriptor.Infrastructure.Service;

public class RequestHandler(IEoppyEservices eoppyEservices) : IRequestHandler
{
    private readonly IEoppyEservices _eoppyServices = eoppyEservices;

    public async Task<string> HandleRequestPrescriptionRetrieve(string prescriptionNumber)
    {
        try
        {
            return await _eoppyServices.PrescriptionRetrieve(null, null, null).ConfigureAwait(false);
        }
        catch (Exception ex)
        {
            return null;
        }
    }
}
