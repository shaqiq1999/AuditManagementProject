using AuditChecklistWebAPI.Models;
using AuditChecklistWebAPI.Repositories;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;


namespace AuditChecklistTestProject
{
    public class Tests
    {
        List<AuditTypesAndQuestions> questions = new List<AuditTypesAndQuestions>();
        IQueryable<AuditTypesAndQuestions> questionsdata;


        [SetUp]
        public void Setup()
        {
            questions = new List<AuditTypesAndQuestions>()
            {
                new AuditTypesAndQuestions{Questions="Have all Change requests followed SDLC before PROD move?", AuditType="Internal"},
                new AuditTypesAndQuestions() { Questions = "2. Have all Change requests been approved by the application owner?", AuditType = "Internal" },
                new AuditTypesAndQuestions() { Questions = "3. Are all artifacts like CR document, Unit test cases available?", AuditType = "Internal" },
                new AuditTypesAndQuestions() { Questions = "1. Have all Change requests followed SDLC before PROD move?", AuditType = "SOX" },
                new AuditTypesAndQuestions() { Questions = "2. Have all Change requests been approved by the application owner?", AuditType = "SOX" }


            };
            questionsdata = questions.AsQueryable();


        }




        [Test]
        public void GetAllChecklistQuestionsListInternalTest()
        {

            var compRepo = new AuditChecklistRepo(questions);
            var compList = compRepo.AuditChecklistQuestions("Internal");
            Assert.AreEqual(3, compList.Count());
        }

        [Test]
        public void GetAllChecklistQuestionsListInternalTestFail()
        {

            var compRepo = new AuditChecklistRepo(questions);
            var compList = compRepo.AuditChecklistQuestions("Internal");
            Assert.AreEqual(5, compList.Count());
        }



        [Test]
        public void GetAllChecklistQuestionsListSOXTest()
        {

            var compRepo = new AuditChecklistRepo(questions);
            var compList = compRepo.AuditChecklistQuestions("SOX");
            Assert.AreEqual(2, compList.Count());
        }


        [Test]
        public void GetAllChecklistQuestionsListSOXTestFail()
        {

            var compRepo = new AuditChecklistRepo(questions);
            var compList = compRepo.AuditChecklistQuestions("SOX");
            Assert.AreEqual(5, compList.Count());
        }
    }
}