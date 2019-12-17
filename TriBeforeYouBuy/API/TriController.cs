using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TriBeforeYouBuy.BusinessLayer;
using TriBeforeYouBuy.Models;

namespace TriBeforeYouBuy.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class TriController : ControllerBase
    {
        [HttpPost]
        [Route("triangle")]
        public string Triangle([FromBody] Coordinate coordinate)
        {
            Triangle triangle = TriManager.GetTriangleCoords(coordinate.Row, coordinate.Col);

            return JsonConvert.SerializeObject(triangle);
        }

        [HttpPost]
        [Route("coords")]
        public string Coords([FromBody] Triangle triangle)
        {
            Coordinate coordinate = TriManager.GetCoordinateFromTriangle(triangle);            

            return JsonConvert.SerializeObject(coordinate);
        }
    }
}
