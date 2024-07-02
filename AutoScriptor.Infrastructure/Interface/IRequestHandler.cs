using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoScriptor.Infrastructure.Interface;

public interface IRequestHandler
{
    public Task<string> HandleRequestPrescriptionRetrieve(string prescriptionNumber);
    public Task<string> HandleRequestPrescriptionExecutionRetrieve(string prescriptionNumber);
    public Task<string> HandleRequestPrescriptionCancel();
}
