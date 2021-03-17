using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreedKata.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RollsController : ControllerBase
    {
        // GET: api/<RollsController>
        [HttpGet("randomRoll")]
        public IEnumerable<int> Get()
        {
            return new int[] { 4, 3, 6, 1, 1 };
        }

        // GET api/<RollsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RollsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<RollsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RollsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
