using AutoPrescriptor.Domain.Models;
using System.Xml.Serialization;

namespace AutoScriptorForm;

public class XMLObjects
{
    [XmlRoot(ElementName = "examinationFirst")]
    public class ExaminationFirst
    {

        [XmlElement(ElementName = "aa")]
        public int Aa { get; set; }

        [XmlElement(ElementName = "description")]
        public string Description { get; set; }

        [XmlElement(ElementName = "quantity")]
        public int Quantity { get; set; }

        [XmlElement(ElementName = "eDapiCode")]
        public string EDapiCode { get; set; }
    }

    [XmlRoot(ElementName = "prescriptionPrintOut")]
    public class PrescriptionPrintOut
    {

        [XmlElement(ElementName = "fileData")]
        public string FileData { get; set; }

        [XmlElement(ElementName = "fileName")]
        public string FileName { get; set; }
    }

    [XmlRoot(ElementName = "EPrescription")]
    public class EPrescription
    {

        [XmlElement(ElementName = "covid19")]
        public bool Covid19 { get; set; }

        [XmlElement(ElementName = "duration_end")]
        public DateTime DurationEnd { get; set; }

        [XmlElement(ElementName = "examinationFirst")]
        public ExaminationFirst ExaminationFirst { get; set; }

        [XmlElement(ElementName = "examinedAmka")]
        public double ExaminedAmka { get; set; }

        [XmlElement(ElementName = "examinedFirstname")]
        public string ExaminedFirstname { get; set; }

        [XmlElement(ElementName = "examinedLastname")]
        public string ExaminedLastname { get; set; }

        [XmlElement(ElementName = "issueDateStr")]
        public string IssueDateStr { get; set; }

        [XmlElement(ElementName = "prescrDocCode")]
        public double PrescrDocCode { get; set; }

        [XmlElement(ElementName = "prescrDocFirstname")]
        public string PrescrDocFirstname { get; set; }

        [XmlElement(ElementName = "prescrDocLastname")]
        public string PrescrDocLastname { get; set; }

        [XmlElement(ElementName = "error")]
        public string Error { get; set; }

        [XmlElement(ElementName = "errorCode")]
        public string ErrorCode { get; set; }

        [XmlElement(ElementName = "prescriptionPrintOut")]
        public PrescriptionPrintOut PrescriptionPrintOut { get; set; }
    }

    [XmlRoot(ElementName = "SubmissionPrintOut")]
    public class SubmissionPrintOut
    {
        [XmlElement(ElementName = "errNo")]
        public string ErrNo { get; set; }

        [XmlElement(ElementName = "errtxt")]
        public string ErrTxt { get; set; }

        [XmlElement(ElementName = "fileData")]
        public string FileData { get; set; }

        [XmlElement(ElementName = "fileName")]
        public string FileName { get; set; }
    }

    [XmlRoot("ResultBeanEPrescription")]
    public class ResultBeanEPrescription
    {
        [XmlElement("prescriptionExceptions")]
        public PrescriptionExceptions PrescriptionExceptions { get; set; }

        [XmlElement("submissionOut")]
        public SubmissionOut SubmissionOut { get; set; }
    }

    public class PrescriptionExceptions
    {
        [XmlElement("descr")]
        public string Descr { get; set; }

        [XmlElement("errorCode")]
        public string ErrorCode { get; set; }
    }

    public class SubmissionOut
    {
        [XmlElement("codeSeq")]
        public string CodeSeq { get; set; }

        [XmlElement("invSeqNum")]
        public string InvSeqNum { get; set; }

        [XmlElement("status")]
        public string Status { get; set; }
    }

    [XmlRoot(ElementName = "ReturnBarcode")]
    public class ReturnBarcode
    {
        [XmlElement("barcodeMap")]
        public BarcodeMap BarcodeMap { get; set; }

        [XmlElement(ElementName = "error")]
        public string Error { get; set; }

        [XmlElement(ElementName = "errorCode")]
        public string ErrorCode { get; set; }
    }

    [XmlRoot(ElementName = "barcodeMap")]
    public class BarcodeMap
    {
        [XmlElement(ElementName = "barcode")]
        public string barcode { get; set; }

        [XmlElement(ElementName = "proc_aa")]
        public string proc_aa { get; set; }        
    }

    [XmlRoot(ElementName = "SubmissionOut")]
    public class SubmissionCancelOut
    {
        [XmlElement(ElementName = "errNo")]
        public string ErrNo { get; set; }

        [XmlElement(ElementName = "errtxt")]
        public string ErrTxt { get; set; }
    }
}
