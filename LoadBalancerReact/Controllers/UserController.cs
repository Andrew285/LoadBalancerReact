using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoadBalancerReact.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private static int counter = 0;
        [HttpGet]
        public IActionResult GetUsers()
        {
            var remotePort = HttpContext.Connection.RemotePort;
            var localPort = HttpContext.Connection.LocalPort;
            var users = new[]
            {
                new { Name = "Oleg" },
                new { Name = "Ivan" },
                new { Name = localPort.ToString()},
                new { Name = remotePort.ToString()},
                new { Name = Environment.GetEnvironmentVariable("HOSTNAME")},
                new { Name = (counter+1).ToString()}
            };
            return Ok(users);
        }


    }
}
