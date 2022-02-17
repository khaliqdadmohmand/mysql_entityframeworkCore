using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using mysqldemo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mysqldemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DemoController : ControllerBase
    {

        private readonly IConfiguration configuration;
        private readonly ApplicationDbContext context;

        public DemoController(IConfiguration configuration, ApplicationDbContext context)
        {
            this.configuration = configuration;
            this.context = context;
        }

        [HttpGet]
        public async Task<IActionResult> getItems()
        {
            var data = context.table1.Where(x => x.id == 1).FirstOrDefault();

            return Ok(data);
        }
    }
}
