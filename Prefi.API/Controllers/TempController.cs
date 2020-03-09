using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Prefi.API.Common;

namespace Prefi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TempController : BaseApiController
    {
        // GET: api/Temp
        [HttpGet("test/aa")]
        public IActionResult Get()
        {
            return new BaseResponseResult(new string[] { "value1", "value2" });
        }

        // GET: api/Temp/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Temp
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Temp/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
