using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoScriptor.Infrastructure.Interface
{
    public interface IEoppyEservices
    {
        public Task<string> Prescription_Retrieve(string prescriptionNumbe, string supplBranchCode, string eMessageNumber);
    }
}
