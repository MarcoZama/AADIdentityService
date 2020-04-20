using AADIdentityService.Authorization;
using AADIdentityService.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AADIdentityService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JoyController : ControllerBase
    {
        /// <summary>
        /// Gets all things
        /// </summary>
        [Authorize(Actions.ReadJoys)]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<JoyModel>))]
        public IActionResult Get()
        {
            // Fake data
            var joys = new List<JoyModel>()            {
                new JoyModel
                {
                    One = "1",
                    Two = "2"
                },
                new JoyModel
                {
                    One = "one",
                    Two = "two"
                }
            };
            return Ok(joys);
        }

        /// <summary>
        /// Gets all other things
        /// </summary>
        [Authorize(Actions.ReadOtherJoys)]
        [HttpGet("other")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<JoyModel>))]
        public IActionResult GetOthers()
        {
            // Fake data
            var joys = new List<JoyModel>()            {
                new JoyModel
                {
                    One = "3",
                    Two = "4"
                },
                new JoyModel
                {
                    One = "three",
                    Two = "four"
                }
            };
            return Ok(joys);
        }
    }
}
