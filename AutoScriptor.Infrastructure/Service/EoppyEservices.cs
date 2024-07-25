using AutoPrescriptor.Domain.Helpers;
using AutoPrescriptor.Domain.Models;
using AutoScriptor.Infrastructure.Interface;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Xml.Serialization;
using static AutoScriptorForm.XMLObjects;

namespace AutoScriptor.Infrastructure.Service;

public class EoppyEservices : IEoppyEservices
{
    private readonly CommunicationSettings _settings;
    public EoppyEservices(IOptions<CommunicationSettings> settings)
    {
        _settings = settings.Value;
    }
    
    public async Task<EPrescription> PrescriptionRetrieve(string prescriptionNumber = "022023056350421")
    {
        EPrescription prescription;
        var base64credentials = Helpers.ConvertToBase64Credentials(_settings.username, _settings.password);
        var client = new HttpClient();
        var request = new HttpRequestMessage(
            HttpMethod.Post,
            _settings.gate
        );
        request.Headers.Add("Authorization", $"Basic {base64credentials}");
        var content = Helpers.CreateSoapEnvelopeContentPrescriptionRetrieve(_settings.username, _settings.password, prescriptionNumber, _settings.eMessageNumber, _settings.supplBranchCode);

        request.Content = content;
        var response = await client.SendAsync(request).ConfigureAwait(false);
        response.EnsureSuccessStatusCode();
        var xmlResponse = await response.Content.ReadAsStringAsync();
        xmlResponse = xmlResponse.Replace("<S:Envelope xmlns:S=\"http://schemas.xmlsoap.org/soap/envelope/\"><S:Body><ns2:getExamPrescriptionResponse xmlns:ns2=\"http://eopyy.ws.intracom.com/\">", string.Empty);
        xmlResponse = xmlResponse.Replace("</ns2:getExamPrescriptionResponse></S:Body></S:Envelope>", string.Empty);

        XmlSerializer serializer = new(typeof(EPrescription));
        using (StringReader reader = new(xmlResponse))
        {
            prescription = (EPrescription)serializer.Deserialize(reader);
        }


        return prescription;
    }

    /// <summary>
    /// Print Electronic prescription
    /// </summary>
    /// <param name="prescriptionNumber"></param>
    /// <param name="supplBranchCode"></param>
    /// <param name="eMessageNumber"></param>
    /// <returns></returns>
    public async Task<SubmissionPrintOut> PrescriptionExecutionRetrieve(string invSeqNum = "022023056350421", string codeSeq = "022023056350421")
    {
        try
        {
            SubmissionPrintOut prescription;
            var base64credentials = Helpers.ConvertToBase64Credentials(_settings.username, _settings.password);
            var client = new HttpClient();
            var request = new HttpRequestMessage(
                HttpMethod.Post,
                _settings.gate
            );
            request.Headers.Add("Authorization", $"Basic {base64credentials}");
            var content = Helpers.CreateSoapEnvelopeContentPrescriptionExecutionRetrieve(_settings.username, _settings.password, codeSeq, invSeqNum, _settings.eMessageNumber, _settings.supplBranchCode);

            request.Content = content;
            var response = await client.SendAsync(request).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
            var xmlResponse = await response.Content.ReadAsStringAsync();
            xmlResponse = xmlResponse.Replace("<S:Envelope xmlns:S=\"http://schemas.xmlsoap.org/soap/envelope/\"><S:Body><ns2:printElectronicPrescriptionResponse xmlns:ns2=\"http://eopyy.ws.intracom.com/\">", string.Empty);
            xmlResponse = xmlResponse.Replace("</ns2:printElectronicPrescriptionResponse></S:Body></S:Envelope>", string.Empty);

            XmlSerializer serializer = new(typeof(SubmissionPrintOut));
            using (StringReader reader = new(xmlResponse))
            {
                prescription = (SubmissionPrintOut)serializer.Deserialize(reader);
            }


            return prescription;
        }
        catch(Exception ex)
        {
            return null;
        }
    }

    /// <summary>
    /// Print Electronic prescription
    /// </summary>
    /// <param name="prescriptionNumber"></param>
    /// <param name="supplBranchCode"></param>
    /// <param name="eMessageNumber"></param>
    /// <returns></returns>
    public async Task<SubmissionCancelOut> PrescriptionCancel(string examinedAmka, string issueDate, string prescriptionNumber)
    {
        try
        {
            SubmissionCancelOut prescription;
            var base64credentials = Helpers.ConvertToBase64Credentials(_settings.username, _settings.password);
            var client = new HttpClient();
            var request = new HttpRequestMessage(
                HttpMethod.Post,
                _settings.gate
            );
            request.Headers.Add("Authorization", $"Basic {base64credentials}");
            var content = Helpers.CreateSoapEnvelopeContentPrescriptionCancel(_settings.username, _settings.password, examinedAmka, issueDate, prescriptionNumber, _settings.eDapy,_settings.eMessageNumber, _settings.supplBranchCode);

            request.Content = content;
            var response = await client.SendAsync(request).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
            var xmlResponse = await response.Content.ReadAsStringAsync();
            xmlResponse = xmlResponse.Replace("<S:Envelope xmlns:S=\"http://schemas.xmlsoap.org/soap/envelope/\"><S:Body><ns2:cancelElectronicPrescriptionResponse xmlns:ns2=\"http://eopyy.ws.intracom.com/\">", string.Empty);
            xmlResponse = xmlResponse.Replace("</ns2:cancelElectronicPrescriptionResponse></S:Body></S:Envelope>", string.Empty);

            XmlSerializer serializer = new(typeof(SubmissionCancelOut));
            using (StringReader reader = new(xmlResponse))
            {
                prescription = (SubmissionCancelOut)serializer.Deserialize(reader);
            }


            return prescription;
        }
        catch (Exception ex)
        {
            return null;
        }
    }

    /// <summary>
    /// Retrieve Breath Barcodes
    /// </summary>
    /// <param name="serialNumber"></param>
    /// <param name="days"></param>
    /// <returns></returns>
    public async Task<ReturnBarcode> RetrieveBreathBarcodes(string serialNumber, string ekapty, int days)
    {
        try
        {
            ReturnBarcode prescription;
            var base64credentials = Helpers.ConvertToBase64Credentials(_settings.username, _settings.password);
            var client = new HttpClient();
            var request = new HttpRequestMessage(
                HttpMethod.Post,
                _settings.gate
            );
            request.Headers.Add("Authorization", $"Basic {base64credentials}");
            var content = Helpers.CreateSoapEnvelopeContentRetrieveBreathBarcodes(_settings.username, _settings.password, ekapty, serialNumber, days, _settings.supplBranchCode);

            request.Content = content;
            var response = await client.SendAsync(request).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
            var xmlResponse = await response.Content.ReadAsStringAsync();
            xmlResponse = xmlResponse.Replace("<S:Envelope xmlns:S=\"http://schemas.xmlsoap.org/soap/envelope/\"><S:Body><ns2:retrieveBreathBarcodesResponse xmlns:ns2=\"http://eopyy.ws.intracom.com/\">", string.Empty);
            xmlResponse = xmlResponse.Replace("</ns2:retrieveBreathBarcodesResponse></S:Body></S:Envelope>", string.Empty);

            XmlSerializer serializer = new(typeof(ReturnBarcode));
            using (StringReader reader = new(xmlResponse))
            {
                prescription = (ReturnBarcode)serializer.Deserialize(reader);
            }


            return prescription;
        }
        catch (Exception ex)
        {
            return null;
        }
    }

    /// <summary>
    /// Print Electronic prescription
    /// </summary>
    /// <param name="prescriptionNumber"></param>
    /// <param name="supplBranchCode"></param>
    /// <param name="eMessageNumber"></param>
    /// <returns></returns>
    public async Task<ResultBeanEPrescription> PrescriptionExecution(PrescriptionExecutionModel prescriptionToExecute)
    {
        try
        {
            ResultBeanEPrescription prescription;
            var base64credentials = Helpers.ConvertToBase64Credentials(_settings.username, _settings.password);
            var client = new HttpClient();
            var request = new HttpRequestMessage(
                HttpMethod.Post,
                _settings.gate
            );
            request.Headers.Add("Authorization", $"Basic {base64credentials}");
            var content = Helpers.CreateSoapEnvelopeContentPrescriptionExecution(_settings.username, _settings.password,_settings.eMessageNumber, _settings.supplBranchCode, _settings.eDapy, prescriptionToExecute);

            request.Content = content;
            var response = await client.SendAsync(request).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
            var xmlResponse = await response.Content.ReadAsStringAsync();
            xmlResponse = xmlResponse.Replace("<S:Envelope xmlns:S=\"http://schemas.xmlsoap.org/soap/envelope/\"><S:Body><ns2:executeElectronicPrescriptionResponse xmlns:ns2=\"http://eopyy.ws.intracom.com/\">", string.Empty);
            xmlResponse = xmlResponse.Replace("</ns2:executeElectronicPrescriptionResponse></S:Body></S:Envelope>", string.Empty);

            XmlSerializer serializer = new(typeof(ResultBeanEPrescription));
            using (StringReader reader = new(xmlResponse))
            {
                prescription = (ResultBeanEPrescription)serializer.Deserialize(reader);
            }


            return prescription;
        }
        catch (Exception ex)
        {
            return null;
        }
    }


}
