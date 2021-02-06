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
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly Database _Db;

        public ProductController(ILogger<ProductController> logger, Database db)
        {
            _logger = logger;
            _Db = db;
        }

        // GET: api/<ProductController>
        [HttpGet]
        public async Task<object> Get()
        {
            return _Db.Product.ToArray();
        }


    }
}
