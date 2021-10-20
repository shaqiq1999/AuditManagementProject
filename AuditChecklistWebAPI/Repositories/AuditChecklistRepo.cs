using AuditChecklistWebAPI.Models;
using AuditChecklistWebAPI.Repositeries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuditChecklistWebAPI.Repositories
{
    public class AuditChecklistRepo: IAuditChecklistRepo
    {
        static List<AuditTypesAndQuestions> questionsAndTypes = new List<AuditTypesAndQuestions>()
        {
            new AuditTypesAndQuestions(){ Questions = "1. Have all Change requests followed SDLC before PROD move?" , AuditType = "Internal"},
            new AuditTypesAndQuestions() { Questions = "2. Have all Change requests been approved by the application owner?", AuditType = "Internal" },
            new AuditTypesAndQuestions() { Questions = "3. Are all artifacts like CR document, Unit test cases available?", AuditType = "Internal" },
            new AuditTypesAndQuestions() { Questions = "4. Is the SIT and UAT sign-off available?", AuditType = "Internal" },
            new AuditTypesAndQuestions() { Questions = "5. Is data deletion from the system done with application owner approval?", AuditType = "Internal" },
            new AuditTypesAndQuestions() { Questions = "1. Have all Change requests followed SDLC before PROD move?", AuditType = "SOX" },
            new AuditTypesAndQuestions() { Questions = "2. Have all Change requests been approved by the application owner?", AuditType = "SOX" },
            new AuditTypesAndQuestions() { Questions = "3. For a major change, was there a database backup taken before and after PROD move?", AuditType = "SOX" },
            new AuditTypesAndQuestions() { Questions = "4. Has the application owner approval obtained while adding a user to the system?", AuditType = "SOX" },
            new AuditTypesAndQuestions() { Questions = "5. Is data deletion from the system done with application owner approval?", AuditType = "SOX" }
        };


        public AuditChecklistRepo(List<AuditTypesAndQuestions> questionsAndTypeslist)
        {
            questionsAndTypes = questionsAndTypeslist;
        }

        public AuditChecklistRepo()
        {

        }
        public List<AuditTypesAndQuestions> AuditChecklistQuestions(string auditType)
        {
            return questionsAndTypes.Where(questions => questions.AuditType == auditType).ToList();
        }



    
}
}
