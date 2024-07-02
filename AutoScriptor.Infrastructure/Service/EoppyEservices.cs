﻿using AutoPrescriptor.Domain.Helpers;
using AutoPrescriptor.Domain.Models;
using AutoScriptor.Infrastructure.Interface;
using Newtonsoft.Json;
using System.Xml.Serialization;
using static AutoScriptorForm.XMLObjects;

namespace AutoScriptor.Infrastructure.Service;

public class EoppyEservices : IEoppyEservices
{
    private static readonly string _username = "sunmedwebser";
    private static readonly string _password = "Sun2018med";
    private static readonly string _gate = "https://eservices.eopyy.gov.gr:443/dapyPrescriptionWS-Test-dapyPrescriptionWS-Test-context-root/ServicePort";//"https://eservices.eopyy.gov.gr/dapyPrescriptionWS-dapyPrescriptionWS-context-root/ServicePort?wsdl"
    public async Task<string> PrescriptionRetrieve(string prescriptionNumber = "022023056350421", string supplBranchCode= "64355" ,string eMessageNumber = "SUNMED_MEDICAL_SA123")
    {
        EPrescription prescription;
        var base64credentials = Helpers.ConvertToBase64Credentials(_username, _password);
        var client = new HttpClient();
        var request = new HttpRequestMessage(
            HttpMethod.Post,
            _gate
        );
        request.Headers.Add("Authorization", $"Basic {base64credentials}");
        var content = Helpers.CreateSoapEnvelopeContent(_username, _password, prescriptionNumber, eMessageNumber, supplBranchCode);

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


        return JsonConvert.SerializeObject(prescription);
    }

    /// <summary>
    /// Print Electronic prescription
    /// </summary>
    /// <param name="prescriptionNumber"></param>
    /// <param name="supplBranchCode"></param>
    /// <param name="eMessageNumber"></param>
    /// <returns></returns>
    public async Task<string> PrescriptionExecutionRetrieve(string invSeqNum = "022023056350421", string codeSeq = "022023056350421", string supplBranchCode = "64355", string eMessageNumber = "SUNMED_MEDICAL_SA123")
    {
        try
        {
            SubmissionPrintOut prescription;
            var base64credentials = Helpers.ConvertToBase64Credentials(_username, _password);
            var client = new HttpClient();
            var request = new HttpRequestMessage(
                HttpMethod.Post,
                _gate
            );
            request.Headers.Add("Authorization", $"Basic {base64credentials}");
            var content = Helpers.CreateSoapEnvelopeContentPrescriptionRetrieve(_username, _password, codeSeq, invSeqNum, eMessageNumber, supplBranchCode);

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


            return JsonConvert.SerializeObject(prescription);
        }
        catch(Exception ex)
        {
            return ex.Message;
        }
    }

    /// <summary>
    /// Print Electronic prescription
    /// </summary>
    /// <param name="prescriptionNumber"></param>
    /// <param name="supplBranchCode"></param>
    /// <param name="eMessageNumber"></param>
    /// <returns></returns>
    public async Task<string> PrescriptionCancel(string issueDate = "10/01/2000", string prescriptReferNumber = "022023056350421", string userId = "022023056350421", string supplBranchCode = "64355", string eMessageNumber = "SUNMED_MEDICAL_SA123")
    {
        return null;
        //try
        //{
        //    EPrescriptionExecution prescription;
        //    var base64credentials = Helpers.ConvertToBase64Credentials(_username, _password);
        //    var client = new HttpClient();
        //    var request = new HttpRequestMessage(
        //        HttpMethod.Post,
        //        _gate
        //    );
        //    request.Headers.Add("Authorization", $"Basic {base64credentials}");
        //    var content = Helpers.CreateSoapEnvelopeContentPrescriptionCancel(_username, _password, issueDate, prescriptReferNumber, userId, eMessageNumber, supplBranchCode);

        //    request.Content = content;
        //    var response = await client.SendAsync(request).ConfigureAwait(false);
        //    response.EnsureSuccessStatusCode();
        //    var xmlResponse = await response.Content.ReadAsStringAsync();
        //    xmlResponse = xmlResponse.Replace("<S:Envelope xmlns:S=\"http://schemas.xmlsoap.org/soap/envelope/\"><S:Body><ns2:getExamPrescriptionResponse xmlns:ns2=\"http://eopyy.ws.intracom.com/\">", string.Empty);
        //    xmlResponse = xmlResponse.Replace("</ns2:getExamPrescriptionResponse></S:Body></S:Envelope>", string.Empty);

        //    XmlSerializer serializer = new(typeof(EPrescriptionExecution));
        //    using (StringReader reader = new(xmlResponse))
        //    {
        //        prescription = (EPrescriptionExecution)serializer.Deserialize(reader);
        //    }


        //    return JsonConvert.SerializeObject(prescription);
        //}
        //catch (Exception ex)
        //{
        //    return ex.Message;
        //}
    }

    /// <summary>
    /// Print Electronic prescription
    /// </summary>
    /// <param name="prescriptionNumber"></param>
    /// <param name="supplBranchCode"></param>
    /// <param name="eMessageNumber"></param>
    /// <returns></returns>
    public async Task<string> PrescriptionExecution(PrescriptionExecutionModel prescriptionToExecute)
    {
        try
        {
            ResultBeanEPrescription prescription;
            var base64credentials = Helpers.ConvertToBase64Credentials(_username, _password);
            var client = new HttpClient();
            var request = new HttpRequestMessage(
                HttpMethod.Post,
                _gate
            );
            request.Headers.Add("Authorization", $"Basic {base64credentials}");
            var content = Helpers.CreateSoapEnvelopeContentPrescriptionExecution(_username, _password, prescriptionToExecute);

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


            return JsonConvert.SerializeObject(prescription);
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }

}
