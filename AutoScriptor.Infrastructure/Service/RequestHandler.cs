using AutoPrescriptor.Domain.Models;
using AutoScriptor.Infrastructure.Interface;
using eoppyEservices;
using System.Globalization;
using System.Text.Json;
using static AutoScriptorForm.XMLObjects;

namespace AutoScriptor.Infrastructure.Service;

public class RequestHandler(IEoppyEservices eoppyEservices, IDBHandler dBHandler) : IRequestHandler
{
    private readonly IEoppyEservices _eoppyServices = eoppyEservices;
    private readonly IDBHandler _dBHandler = dBHandler;

    public async Task<EPrescription> HandleRequestPrescriptionRetrieve(string prescriptionNumber)
    {
        try
        {
            return await _eoppyServices.PrescriptionRetrieve(prescriptionNumber).ConfigureAwait(false);
        }
        catch (Exception ex)
        {
            return null;
        }
    }

    public async Task<SubmissionPrintOut> HandleRequestPrescriptionExecutionRetrieve(string invSeqNo, string codeSeq)
    {
        try
        {
            return await _eoppyServices.PrescriptionExecutionRetrieve(invSeqNo, codeSeq).ConfigureAwait(false);
        }
        catch (Exception ex)
        {
            return null;
        }
    }

    public async Task<SubmissionCancelOut> HandleRequestPrescriptionCancel(string prescriptionNumber)
    {
        try
        {
            var retreivedPrescription = await _eoppyServices.PrescriptionRetrieve(prescriptionNumber).ConfigureAwait(false);
            return await _eoppyServices.PrescriptionCancel(retreivedPrescription.ExaminedAmka.ToString(), retreivedPrescription.IssueDateStr, prescriptionNumber).ConfigureAwait(false);
        }
        catch (Exception ex)
        {
            return null;
        }
    }

    public async Task<ReturnBarcode> HandleRequestRetrieveBreathCodes(string serialNumber, string ekapty, int days)
    {
        try
        {
            return await _eoppyServices.RetrieveBreathBarcodes(serialNumber, ekapty, days).ConfigureAwait(false);
        }
        catch (Exception ex)
        {
            return null;
        }
    }

    public async Task<ResultBeanEPrescription> HandleRequestPrescriptionExecution(string prescriptionNumber)
    {
        try
        {
            return await _eoppyServices.PrescriptionExecution(null).ConfigureAwait(false);
        }
        catch (Exception ex)
        {
            return null;
        }
    }

    public async Task<string> HandleRequestPrescriptionInsert(string prescriptionNumber)
    {
        var res = await _dBHandler.RetrieveBreathDevices().ConfigureAwait(false);

        //retrieve prescription from eoppy
        var prescriptionRetrieved = await _eoppyServices.PrescriptionRetrieve(prescriptionNumber).ConfigureAwait(false);
        
        //retrieve days of execution
        var days = ResolveDaysOfExecution(prescriptionRetrieved);

        //retrieve device barcodes
        var barcodeRequest = await _eoppyServices.RetrieveBreathBarcodes("serialNumber", prescriptionRetrieved.ExaminationFirst.EDapiCode, days).ConfigureAwait(false);
        var barcodes = barcodeRequest.BarcodeMap;

        var unitPrice = ResolveUnitPrice(days, prescriptionRetrieved.ExaminationFirst.EDapiCode, res);

        //create execution model
        var barcodeMap = new BarcodeMapInput()
        {
            proc_aa = barcodes?.proc_aa ?? "0",
            barcode = barcodes?.barcode ?? Guid.NewGuid().ToString(),
            ekapty = prescriptionRetrieved.ExaminationFirst.EDapiCode,
            qty = "1",
            unit_price = unitPrice
        };
        var newPrescriptionList = new PrescriptionDetail
        {
            aa = "1",
            medicalProcedureId = prescriptionRetrieved.ExaminationFirst.EDapiCode,
            vat = "24",
            quantity = "1",
            saveQuantity = "1",
            barcodeMap = new List<BarcodeMapInput> { barcodeMap }
        };
        var newPrescriptionModel = new PrescriptionExecutionModel
        {
            duration_end = prescriptionRetrieved.DurationEnd.ToString("dd/MM/yyyy"),
            examinedAmka = prescriptionRetrieved.ExaminedAmka.ToString(),
            examinedFirstname = prescriptionRetrieved.ExaminedFirstname,
            examinedLastname = prescriptionRetrieved.ExaminedLastname,
            execDateStr = prescriptionRetrieved.DurationEnd.ToString("dd/MM/yyyy"),
            issueDateStr = prescriptionRetrieved.IssueDateStr,
            prescrDocCode = prescriptionRetrieved.PrescrDocCode.ToString(),
            prescrDocFirstname = prescriptionRetrieved.PrescrDocFirstname,
            prescrDocLastname = prescriptionRetrieved.PrescrDocLastname,
            prescriptionNumber = prescriptionNumber,
            prescriptionDetailsList = new List<PrescriptionDetail> { newPrescriptionList }
        };
        var options = new JsonSerializerOptions
        {
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
            WriteIndented = true // Optional, for pretty printing
        };

        var newPrescription = new NewPrescription
        {
            ExecutionDate = prescriptionRetrieved.DurationEnd,
            PrescriptionData = JsonSerializer.Serialize(newPrescriptionModel, options)
        };

        await _dBHandler.InsertNewPrescription(newPrescription);

        return null;
    }

    public async Task<IEnumerable<NewPrescription>> HandleRequestExecuteDailyPrescriptions(DateTime date)
    {
        var dailyPrescriptions = await _dBHandler.RetrieveDailyPrescriptions(date).ConfigureAwait(false);

        return dailyPrescriptions;
    }

    public async Task<IEnumerable<BreathDevice>> HandleRequestRetrieveDevices()
    {
        var devices = await _dBHandler.RetrieveBreathDevices().ConfigureAwait(false);

        return devices;
    }

    private static int ResolveDaysOfExecution(EPrescription ePrescription)
    {
        var issueDate = DateTime.ParseExact(ePrescription.IssueDateStr, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        var executionDate = ePrescription.DurationEnd;

        var difference = executionDate - issueDate;

        return difference.Days;
    }

    private static string ResolveUnitPrice(int days, string ekapty, IEnumerable<BreathDevice> devices)
    {
        var totalPrice = devices.Where(d => d.ekapty == ekapty).Select(i => i.Price).FirstOrDefault() ?? 0;

        return Math.Round(totalPrice / days, 2).ToString("F4");
    }
}
