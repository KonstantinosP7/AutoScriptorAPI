using AutoPrescriptor.Domain.Models;
using AutoScriptor.Infrastructure.Interface;

namespace AutoScriptor.Infrastructure.Service;

public class RequestHandler(IEoppyEservices eoppyEservices) : IRequestHandler
{
    private readonly IEoppyEservices _eoppyServices = eoppyEservices;

    public async Task<string> HandleRequestPrescriptionRetrieve(string prescriptionNumber)
    {
        try
        {
            return await _eoppyServices.PrescriptionRetrieve(null).ConfigureAwait(false);
        }
        catch (Exception ex)
        {
            return null;
        }
    }

    public async Task<string> HandleRequestPrescriptionExecutionRetrieve(string prescriptionNumber)
    {
        try
        {
            return await _eoppyServices.PrescriptionExecutionRetrieve(null, null, null, null).ConfigureAwait(false);
        }
        catch (Exception ex)
        {
            return null;
        }
    }

    public async Task<string> HandleRequestPrescriptionCancel()
    {
        try
        {
            return await _eoppyServices.PrescriptionCancel(null, null, null, null, null).ConfigureAwait(false);
        }
        catch (Exception ex)
        {
            return null;
        }
    }

    public async Task<string> HandleRequestPrescriptionExecution(string prescriptionNumber)
    {
        try
        {
            return await _eoppyServices.PrescriptionExecution(prescriptionExecutionSample()).ConfigureAwait(false);
        }
        catch (Exception ex)
        {
            return null;
        }
    }

    internal PrescriptionExecutionModel prescriptionExecutionSample()
    {
        // Create sample BarcodeMap instances
        var barcodeMaps1 = new List<BarcodeMap>
        {
            new BarcodeMap("1", "1234567890123", "E1", "10", "1.23"),
            new BarcodeMap("2", "2345678901234", "E2", "20", "2.34")
        };

        var barcodeMaps2 = new List<BarcodeMap>
        {
            new BarcodeMap("3", "3456789012345", "E3", "30", "3.45"),
            new BarcodeMap("4", "4567890123456", "E4", "40", "4.56")
        };

        // Create sample PrescriptionDetail instances
        var prescriptionDetails = new List<PrescriptionDetail>
        {
            new PrescriptionDetail("1", "MP1", "23%", "2", "2", barcodeMaps1),
            new PrescriptionDetail("2", "MP2", "18%", "3", "3", barcodeMaps2)
        };

        // Create a sample PrescriptionExecutionModel instance
        var prescriptionExecution = new PrescriptionExecutionModel(
            "EM001",
            "2023-07-01",
            "12345678901",
            "John",
            "Doe",
            "2023-07-01",
            "2023-06-30",
            "D001",
            "Jane",
            "Smith",
            "PN12345",
            "B001",
            "U001",
            prescriptionDetails
        );

        return prescriptionExecution;
    }
    public Task<string> HandleRequestPrescriptionInsert(string prescriptionNumber)
    {
        //retrieve prescription from eoppy
        var pr = _eoppyServices.PrescriptionRetrieve( prescriptionNumber );

    }

}
