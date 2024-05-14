using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using AutoScriptor.Infrastructure.Interface;
using AutoScriptor.Infrastructure.Service;
using Patagames.Pdf.Net;

namespace AutoScriptorForm
{
    public partial class frmRetrievePrescription : Form
    {
        public frmRetrievePrescription()
        {
            InitializeComponent();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            var xmlResponse = Prescription_Retrieve(txtPrsNo.Text).Result;

            Envelope envelope;
            using (StringReader reader = new StringReader(xmlResponse))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Envelope));
                envelope = (Envelope)serializer.Deserialize(reader);
            }

            // Access the EPrescription object within the envelope
            EPrescription prescription = envelope.Body.GetExamPrescriptionResponse.EPrescription;


            byte[] fileBytes = Convert.FromBase64String(prescription.prescriptionPrintOut.fileData);

            // Save byte array to file
            File.WriteAllBytes(prescription.prescriptionPrintOut.fileName, fileBytes);

            PdfCommon.Initialize();

            pdfVr.LoadDocument(prescription.prescriptionPrintOut.fileName);
        }
        private async Task<string> Prescription_Retrieve(string prescriptionNumber = "022023056350421", string supplBranchCode = "64355", string eMessageNumber = "SUNMED_MEDICAL_SA123")
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

        [XmlRoot(ElementName = "Envelope", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public class Envelope
        {
            [XmlElement(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
            public Body Body { get; set; }
        }

        public class Body
        {
            [XmlElement(ElementName = "getExamPrescriptionResponse", Namespace = "http://eopyy.ws.intracom.com/")]
            public GetExamPrescriptionResponse GetExamPrescriptionResponse { get; set; }
        }

        public class GetExamPrescriptionResponse
        {
            [XmlElement(ElementName = "EPrescription", Namespace = "http://eopyy.ws.intracom.com/")]
            public EPrescription EPrescription { get; set; }
        }

        public class EPrescription
        {
            public bool covid19 { get; set; }
            public DateTime duration_end { get; set; }
            public ExaminationFirst examinationFirst { get; set; }
            public string examinedAmka { get; set; }
            public string examinedFirstname { get; set; }
            public string examinedLastname { get; set; }
            public string issueDateStr { get; set; }
            public string prescrDocCode { get; set; }
            public string prescrDocFirstname { get; set; }
            public string prescrDocLastname { get; set; }
            public PrescriptionPrintOut prescriptionPrintOut { get; set; }
        }

        public class ExaminationFirst
        {
            public string aa { get; set; }
            public string description { get; set; }
            public string quantity { get; set; }
            public string eDapiCode { get; set; }
        }

        public class PrescriptionPrintOut
        {
            public string fileData { get; set; }
            public string fileName { get; set; }
        }
    }
}
