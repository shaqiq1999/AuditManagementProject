using AuditBenchmarkWebAPI.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AuditBenchmarkWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuditBenchmarkController : ControllerBase
    {
        private readonly IBenchmarkRepo _context;

        public AuditBenchmarkController(IBenchmarkRepo context)
        {
            _context = context;
        }

        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(AuditBenchmarkController));

        [HttpGet("{auditType}")]
        public IActionResult GetInternalAndSOXCount(string auditType)
        {
            _log4net.Info("Get Internal And Sox Count Method Called !!");
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var count = _context.GetInternaAndSOXNoCount(auditType);
                if (count == null)
                {
                    return NotFound();
                }
                return Ok(count);
            }
            catch (Exception)
            {

                return BadRequest();
            }

        }
    }
}
