using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using api.Models;
using api.Data;
using Microsoft.AspNetCore.Http.HttpResults;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StatusController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public StatusController(ApplicationDbContext context)
        {
            _context = context;
        }

        
        [HttpPost]
        public IActionResult GetAlert(Status message) 
        {
            return _statusService.Create(message);
        }

        [HttpGet]
        public IActionResult SendResponse() {
            
            return NotFound();
        }
    }
}