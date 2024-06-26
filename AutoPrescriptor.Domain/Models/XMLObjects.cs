﻿using System.Xml.Serialization;

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
        public int EDapiCode { get; set; }
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

        [XmlElement(ElementName = "prescriptionPrintOut")]
        public PrescriptionPrintOut PrescriptionPrintOut { get; set; }
    }

}
