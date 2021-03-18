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
        // GET: api/rolls/randomRoll
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

        // POST api/rolls/rollValues
        [HttpPost("rollValues")]
        public IActionResult Post([FromBody] RollTemplate rollTemplate)
        {
            Roll roll = new Roll();

            roll.setDiceNumbers(rollTemplate.diceNumbers);
            roll.calculateScore();

            JArray diceNumsJson = new JArray(roll.getDiceNumbers());

            var jsonRollObj = new JObject();
            jsonRollObj.Add("Score", roll.getScore());
            jsonRollObj.Add("DiceNumbers", diceNumsJson);

            return Content(jsonRollObj.ToString(), "application/json");
        }
    }
}
