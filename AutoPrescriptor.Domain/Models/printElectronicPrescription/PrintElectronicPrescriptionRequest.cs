using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPrescriptor.Domain.Models.printElectronicPrescription
{
    internal class PrintElectronicPrescriptionRequest
    {
        public string? EMessageNumber { get; set; }
        public string? invSeqNum { get; set; }
        public int codeSeq { get; set; }
        public string? supplBranchCode { get; set; }
    }
}
