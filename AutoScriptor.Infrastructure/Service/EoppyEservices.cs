using AutoPrescriptor.Domain.Helpers;
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

        EPrescription envelop;
        XmlSerializer serializer = new(typeof(EPrescription));
        using (StringReader reader = new(xmlResponse))
        {
            prescription = (EPrescription)serializer.Deserialize(reader);
        }


        return JsonConvert.SerializeObject(prescription);
    }
}
