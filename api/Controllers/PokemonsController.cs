using Microsoft.AspNetCore.Mvc;
using PokeApiConnector.Interfaces;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonsController : ControllerBase
    {
        private readonly IPokeApiService _service;
        public PokemonsController(IPokeApiService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult> Get(int number)
        {
            var result = await _service.Get(number);
            return Ok(result);
        }
    }
}
