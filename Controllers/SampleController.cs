using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PengWinBodyDapperAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SampleController : ControllerBase
    {
        public SampleController()
        {
            
        }

        [HttpGet("WhoAmI")]
        public IActionResult WhoAmI(){
            return Ok("I am a miner.");
        }
        
        [HttpPost("NiceToMeetYou")]
        public IActionResult NiceToMeetYou(string yourName)
        {
            if (string.IsNullOrEmpty(yourName))
            {
                return BadRequest("Ambot");
            }
            return Ok($"Nice to meet you, {yourName}");
        }
    }
}