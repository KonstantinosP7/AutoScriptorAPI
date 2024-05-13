using AutoScriptor.Infrastructure.Interface;
using System.Xml.Linq;

namespace AutoScriptor.Infrastructure.Service;

public class EoppyEservices : IEoppyEservices
{
    public async Task<string> Prescription_Retrieve(string prescriptionNumber = "022023056350421", string supplBranchCode= "64355" ,string eMessageNumber = "SUNMED_MEDICAL_SA123")
    {
        var client = new HttpClient();
        var request = new HttpRequestMessage(
            HttpMethod.Post,
            //"https://eservices.eopyy.gov.gr/dapyPrescriptionWS-dapyPrescriptionWS-context-root/ServicePort?wsdl"
            "https://eservices.eopyy.gov.gr:443/dapyPrescriptionWS-Test-dapyPrescriptionWS-Test-context-root/ServicePort"
        );
        request.Headers.Add("Authorization", "Basic c3VubWVkd2Vic2VyOlN1bjIwMThtZWQ=");
        var content = CreateSoapEnvelopeContent("sunmedwebser", "Sun2018med", prescriptionNumber, eMessageNumber, supplBranchCode);

        request.Content = content;
        var response = await client.SendAsync(request).ConfigureAwait(false);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    static StringContent CreateSoapEnvelopeContent(string username, string password, string prescriptionNumber, string eMessageNumber, string supplBranchCode)
    {
        XNamespace soapenv = "http://schemas.xmlsoap.org/soap/envelope/";
        XNamespace eop = "http://eopyy.ws.intracom.com/";
        XNamespace wsse = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd";
        XNamespace wsu = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd";

        XDocument soapEnvelope = new(
            new XElement(soapenv + "Envelope",
                new XAttribute(XNamespace.Xmlns + "eop", eop),
                new XAttribute(XNamespace.Xmlns + "soapenv", soapenv),
                new XElement(soapenv + "Header",
                    new XElement(wsse + "Security",
                        new XAttribute(soapenv + "mustUnderstand", "1"),
                        new XAttribute(XNamespace.Xmlns + "wsse", wsse),
                        new XAttribute(XNamespace.Xmlns + "wsu", wsu),
                        new XElement(wsse + "UsernameToken",
                            new XAttribute(wsu + "Id", "UsernameToken-B32BFDE586617399FF17115676929155"),
                            new XElement(wsse + "Username", username),
                            new XElement(wsse + "Password",
                                new XAttribute("Type", "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-username-token-profile-1.0#PasswordText"),
                                password
                            )
                        )
                    )
                ),
                new XElement(soapenv + "Body",
                    new XElement(eop + "getExamPrescription",
                        new XElement("prescriptionNumber", prescriptionNumber),
                        new XElement("eMessageNumber", eMessageNumber),
                        new XElement("supplBranchCode", supplBranchCode)
                    )
                )
            )
        );

        return new StringContent(soapEnvelope.ToString(), null, "text/xml");
    }
}
