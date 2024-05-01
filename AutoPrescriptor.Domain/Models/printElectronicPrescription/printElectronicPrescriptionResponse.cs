using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPrescriptor.Domain.Models.printElectronicPrescription
{
    internal class printElectronicPrescriptionResponse
    {
        public string? errNo { get; set; }
        public string? errtxt { get; set; }
        public string? fileData { get; set; }
        public string? fileName { get; set; }

    }
}
