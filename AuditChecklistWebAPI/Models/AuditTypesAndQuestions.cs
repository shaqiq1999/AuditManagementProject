using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuditChecklistWebAPI.Models
{
    public class AuditTypesAndQuestions
    {
        public AuditTypesAndQuestions()
        {

        }
        public AuditTypesAndQuestions(string questions, string auditType)
        {
            Questions = questions;
            AuditType = auditType;
        }
        public string Questions { get; set; }
        public string AuditType { get; set; }
    }
}
