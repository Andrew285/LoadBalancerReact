using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace LoadBalancerReact.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatrixController : ControllerBase
    {
        static Matrix data;

        [HttpGet]
        public IActionResult GetAsync()
        {
            return Ok(data);
        }

        [HttpPost]
        public IActionResult PostAsync([FromBody] dynamic MatrixData)
        {
            var result = JsonConvert.DeserializeObject(MatrixData.ToString());
            Matrix matrix = new Matrix(result.rowsAmount.ToString(), result.columnsAmount.ToString());
            Console.WriteLine("OK");
            return Ok(JsonConvert.SerializeObject(matrix));
        }

    }
}
