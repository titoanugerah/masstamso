using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ILogger<CustomerController> _logger;
        private readonly Database _Db;

        public CustomerController(ILogger<CustomerController> logger, Database db)
        {
            _logger = logger;
            _Db = db;
        }

        // GET: api/<CustomerController>
        [HttpGet]
        public async Task<object> Get()
        {
            return _Db.Customer.ToArray();
        }

        // POST api/<CustomerController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

    }
}
