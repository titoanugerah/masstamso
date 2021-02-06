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
    public class CountryController : ControllerBase
    {
        private readonly ILogger<CountryController> _logger;
        private readonly Database _Db;

        public CountryController(ILogger<CountryController> logger, Database db)
        {
            _logger = logger;
            _Db = db;
        }


        // GET: api/<CountryController>
        [HttpGet]
        public IEnumerable<Models.Country> Get()
        {
            var country = _Db.Country.ToList();
            return country;
        }

        // GET api/<CountryController>/GetCurrency/5
        [HttpGet("GetCurrency/{id}")]
//        [Route("api/Country/GetCurrency")]
        public string GetCurrency(int id)
        {
            var currency = _Db.Country.Where(x => x.Id == id).Select(x => x.Currency).FirstOrDefault();
            return currency;
        }

        // POST api/<CountryController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CountryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CountryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
