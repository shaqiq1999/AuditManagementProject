using AuditBenchmarkWebAPI.Repository;
using NUnit.Framework;
using System.Collections.Generic;

namespace AuditBenchmarkTestProject
{
    public class Tests
    {
        Dictionary<string, int> internalandsoxtestdict = new Dictionary<string, int>();
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void GetInternalCount()
        {

            var compRepo = new BenchmarkRepo(internalandsoxtestdict);
            var compDict = compRepo.GetInternaAndSOXNoCount("Internal");
            int internalnocount = compDict["Internal"];
            Assert.AreEqual(3, internalnocount);
        }

        [Test]
        public void GetInternalCountFail()
        {

            var compRepo = new BenchmarkRepo(internalandsoxtestdict);
            var compDict = compRepo.GetInternaAndSOXNoCount("Internal");
            int internalnocount = compDict["Internal"];
            Assert.AreEqual(5, internalnocount);
        }

        [Test]
        public void GetSOXCount()
        {

            var compRepo = new BenchmarkRepo(internalandsoxtestdict);
            var compDict = compRepo.GetInternaAndSOXNoCount("SOX");
            int soxnocount = compDict["SOX"];
            Assert.AreEqual(1, soxnocount);
        }

        [Test]
        public void GetSOXCountFail()
        {

            var compRepo = new BenchmarkRepo(internalandsoxtestdict);
            var compDict = compRepo.GetInternaAndSOXNoCount("SOX");
            int soxnocount = compDict["SOX"];
            Assert.AreEqual(3, soxnocount);
        }





    }
}