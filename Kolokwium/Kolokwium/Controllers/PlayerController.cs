using Kolokwium.DTOs.Request;
using Kolokwium.Exceptions;
using Kolokwium.Services;
using Microsoft.AspNetCore.Mvc;

namespace Kolokwium.Controllers
{
    [Route("api")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly IDbService _service;
        public PlayerController(IDbService service)
        {
            _service = service;
        }

        [HttpPost("teams/{id}/players")]
        public IActionResult AddPlayerToTeam(int id, AddPlayerToTeamRequest req)
        {
            try { 
                _service.AddPlayerToTeam(req, id);
                return Ok();
            }catch(PlayerNotFoundException ex)
            {
                return NotFound(ex.Message);
            }catch(TeamsNotFoundException ex)
            {
                return NotFound(ex.Message);
            }catch(TooOldPlayerForThisTeamException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}