using AuditBenchmarkWebAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuditBenchmarkWebAPI.Repository
{
    public class BenchmarkRepo : IBenchmarkRepo
    {
        Dictionary<string, int> _internalandsoxdict = new Dictionary<string, int>();

        public BenchmarkRepo()
        {

        }

        public BenchmarkRepo(Dictionary<string, int> internalandsoxDict)
        {
            _internalandsoxdict = internalandsoxDict;
        }

        public Dictionary<string, int> GetInternaAndSOXNoCount(string auditType)
        {

            if (auditType == "Internal")
            {
                _internalandsoxdict.Add("Internal", 3);
            }
            else
            {
                if (auditType == "SOX")
                {
                    _internalandsoxdict.Add("SOX", 1);
                }
            }

            return _internalandsoxdict;
        }
        }
    }
