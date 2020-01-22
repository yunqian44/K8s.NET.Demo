using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace k8s.net.demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthController : ControllerBase
    {
        [Route(nameof(CheckHealth))]
        public IActionResult CheckHealth()
        {
            if (new Random().Next(100) > 50)
            {
                return Ok("OK");
            }
            else
            {
                return BadRequest();
            }
        }
    }
}