using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuditBenchmarkWebAPI.Repository
{
    public interface IBenchmarkRepo
    {

        Dictionary<string, int> GetInternaAndSOXNoCount(string auditType);
    }
}
