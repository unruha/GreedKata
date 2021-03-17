using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using GreedKata.Models;
using Newtonsoft.Json.Linq;

namespace GreedKata.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RollsController : ControllerBase
    {
        // GET: api/<RollsController>
        [HttpGet("randomRoll")]
        public IActionResult Get()
        {
            Roll roll = new Roll();
            roll.rollDiceRandom();
            roll.calculateScore();

            JArray diceNumsJson = new JArray(roll.getDiceNumbers());

            var jsonRollObj = new JObject();
            jsonRollObj.Add("Score", roll.getScore());
            jsonRollObj.Add("DiceNumbers", diceNumsJson);

            return Content(jsonRollObj.ToString(), "application/json");
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
