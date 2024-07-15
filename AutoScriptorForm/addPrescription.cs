using Patagames.Pdf.Net;
using System.Xml.Linq;
using System.Xml.Serialization;
using static AutoScriptorForm.XMLObjects;

namespace AutoScriptorForm
{
    public partial class addPrescription : UserControl
    {
        private EPrescription _prescription;
        public addPrescription()
        {
            InitializeComponent();
            //PdfCommon.Initialize();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            pdfVr.CloseDocument();

            var xmlResponse = Prescription_Retrieve().Result;

            xmlResponse = xmlResponse.Replace("<S:Envelope xmlns:S=\"http://schemas.xmlsoap.org/soap/envelope/\"><S:Body><ns2:getExamPrescriptionResponse xmlns:ns2=\"http://eopyy.ws.intracom.com/\">", string.Empty);
            xmlResponse = xmlResponse.Replace("</ns2:getExamPrescriptionResponse></S:Body></S:Envelope>", string.Empty);

            EPrescription envelop;
            XmlSerializer serializer = new(typeof(EPrescription));
            using (StringReader reader = new(xmlResponse))
            {
                _prescription = (EPrescription)serializer.Deserialize(reader);
            }

            byte[] fileBytes = Convert.FromBase64String(_prescription.PrescriptionPrintOut.FileData);

            RemovePrescriptionFileIfExists();

            File.WriteAllBytes(_prescription.PrescriptionPrintOut.FileName, fileBytes);

            //pdfVr.LoadDocument(_prescription.PrescriptionPrintOut.FileName);
            FillPrescriptionDate();
        }

        private void FillPrescriptionDate()
        {
            txtAMKA.Text = _prescription.ExaminedAmka.ToString();
            txtSurname.Text = _prescription.ExaminedLastname;
            txtName.Text = _prescription.ExaminedFirstname;
            txtAMKADoc.Text = _prescription.PrescrDocCode.ToString();
            txtNameDoc.Text = _prescription.PrescrDocFirstname;
            txtSurnameDoc.Text = _prescription.PrescrDocLastname;
            txtIssueDate.Text = _prescription.IssueDateStr;
            txtEndDate.Text = _prescription.DurationEnd.ToString("dd/MM/yyyy");
            txtExecutionDate.Text = _prescription.DurationEnd.ToString("dd/MM/yyyy");

        }

        private void RemovePrescriptionFileIfExists()
        {
            if (File.Exists(_prescription.PrescriptionPrintOut.FileName))
            {
                File.Delete(_prescription.PrescriptionPrintOut.FileName);
            }
        }

        private async Task<string> Prescription_Retrieve(string prescriptionNumber = "022022044515845", string supplBranchCode = "64355", string eMessageNumber = "SUNMED_MEDICAL_SA123")
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

        private static StringContent CreateSoapEnvelopeContent(string username, string password, string prescriptionNumber, string eMessageNumber, string supplBranchCode)
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

        private void addPrescription_Leave(object sender, EventArgs e)
        {
            pdfVr.CloseDocument();
        }
    }
}
