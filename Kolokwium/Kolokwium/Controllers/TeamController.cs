using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kolokwium.Exceptions;
using Kolokwium.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kolokwium.Controllers
{
    [Route("api")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly IDbService _service;
        public TeamController(IDbService service)
        {
            _service = service;
        }

        [HttpGet("{id:int}")]
        public IActionResult GetTeamsAndScores(int id)
        {
            try {
            var result = _service.GetTeamsWithScoresOnChampionship(id);
                return Ok(result);
            }catch(TeamsNotFoundException exc)
            {
                return BadRequest(exc.Message);
            }

        }
    }
}