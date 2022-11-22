using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoadBalancerReact.Controllers
{
    [Route("api/create_matrix")]
    [ApiController]
    public class MatrixController : ControllerBase
    {

        [HttpPost]
        public void PostAsync(string rowsAmount, string colsAmount)
        {
            Console.WriteLine(rowsAmount);
            Console.WriteLine(colsAmount);
        }
    }
}
