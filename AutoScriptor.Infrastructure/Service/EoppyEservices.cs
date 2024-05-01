namespace AutoScriptor.Infrastructure.Service;

public class EoppyEservices
{
    public async Task Prescription_Retrieve(string prescriptionNumber= "022023056350421", string supplBranchCode= "64355" ,string eMessageNumber = "SUNMED_MEDICAL_SA123")
    {
        var client = new HttpClient();
        var request = new HttpRequestMessage(
            HttpMethod.Post,
            "https://eservices.eopyy.gov.gr/dapyPrescriptionWS-dapyPrescriptionWS-context-root/ServicePort?wsdl"
            //"https://eservices.eopyy.gov.gr:443/dapyPrescriptionWS-Test-dapyPrescriptionWS-Test-context-root/ServicePort"
        );
        request.Headers.Add("Authorization", "Basic c3VubWVkd2Vic2VyOlN1bjIwMThtZWQ=");
        var content = new StringContent(
            "<soapenv:Envelope xmlns:eop=\"http://eopyy.ws.intracom.com/\" " +
            "xmlns:soapenv=\"http://schemas.xmlsoap.org/soap/envelope/\">\r\n    " +
            "<soapenv:Header>\r\n        " +
            "<wsse:Security soapenv:mustUnderstand=\"1\" " +
            "xmlns:wsse=\"http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd\" " +
            "xmlns:wsu=\"http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd\">\r\n            " +
            "<wsse:UsernameToken wsu:Id=\"UsernameToken-B32BFDE586617399FF17115676929155\">\r\n                " +
            "<wsse:Username>sunmedwebser</wsse:Username>\r\n                " +
            "<wsse:Password Type=\"http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-username-token-profile-1.0#PasswordText\">Sun2018med</wsse:Password>\r\n " +
            "           </wsse:UsernameToken>\r\n        " +
            "</wsse:Security>\r\n    </soapenv:Header>\r\n    " +
            "<soapenv:Body>\r\n        <eop:getExamPrescription>\r\n            " +
            $"<prescriptionNumber>{prescriptionNumber}</prescriptionNumber>\r\n            " +
            $"<eMessageNumber>{eMessageNumber}</eMessageNumber>\r\n            " +
            $"<supplBranchCode>{supplBranchCode}</supplBranchCode>\r\n        " +
            "</eop:getExamPrescription>\r\n    " +
            "</soapenv:Body>\r\n</soapenv:Envelope>",
            null,
            "text/xml");
        request.Content = content;
        var response = await client.SendAsync(request).ConfigureAwait(false);
        response.EnsureSuccessStatusCode();
        Console.WriteLine(await response.Content.ReadAsStringAsync());
    }
}
