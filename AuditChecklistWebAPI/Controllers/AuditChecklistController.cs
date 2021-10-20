using AuditChecklistWebAPI.Repositeries;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AuditChecklistWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuditChecklistController : ControllerBase
    {
        // GET: api/<AuditChecklistController>
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(AuditChecklistController));
        private readonly IAuditChecklistRepo _context;

        public AuditChecklistController(IAuditChecklistRepo context)
        {
            _context = context;
        }
        [HttpGet("{auditType}")]
        public IActionResult AuditChecklistQuestions(string auditType)
        {
            _log4net.Info("Get Questions By AuditType Was Called !!");
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var questions = _context.AuditChecklistQuestions(auditType);
                _log4net.Info("Questions for Audit Type " + auditType + " Was Called");
                if (questions == null)
                {
                    return NotFound();
                }
                return Ok(questions);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
