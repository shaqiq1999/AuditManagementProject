using AuditChecklistWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace AuditChecklistWebAPI.Repositeries
{
    public interface IAuditChecklistRepo
    {
        List<AuditTypesAndQuestions> AuditChecklistQuestions(string auditType);
    }
}
