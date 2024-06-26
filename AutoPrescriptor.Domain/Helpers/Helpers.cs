using System.Text;
using System.Xml.Linq;

namespace AutoPrescriptor.Domain.Helpers;

public class Helpers
{
    private static string _soapenv = "http://schemas.xmlsoap.org/soap/envelope/";
    private static string _eop = "http://eopyy.ws.intracom.com/";
    private static string _wsse = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd";
    private static string _wsu = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd";
    private static string _wsType = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-username-token-profile-1.0#PasswordText";

    public static StringContent CreateSoapEnvelopeContent(string username, string password, string prescriptionNumber, string eMessageNumber, string supplBranchCode)
    {
        XNamespace soapenv = _soapenv;
        XNamespace eop = _eop;
        XNamespace wsse = _wsse;
        XNamespace wsu = _wsu;

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
                                new XAttribute("Type", _wsType),
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

    public static string ConvertToBase64Credentials(string username, string password)
    {
        string combined = $"{username}:{password}";
        byte[] byteArray = Encoding.UTF8.GetBytes(combined);
        return Convert.ToBase64String(byteArray);
    }
}
