using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using GreedKata.Models;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Cors;

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

            // create json array so that it can be returned in json format
            JArray diceNumsJson = new JArray(roll.getDiceNumbers());

            // create json object to return roll values in json format to user
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
            // set the dice roll values to the values passed in through the body
            roll.setDiceNumbers(rollTemplate.diceNumbers);
            roll.calculateScore();

            // create json array to return json format to user
            JArray diceNumsJson = new JArray(roll.getDiceNumbers());

            // create json object to return json format to user
            var jsonRollObj = new JObject();
            jsonRollObj.Add("Score", roll.getScore());
            jsonRollObj.Add("DiceNumbers", diceNumsJson);

            return Content(jsonRollObj.ToString(), "application/json");
        }
    }
}
