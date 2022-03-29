using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DnDWebAPI.Models;
using Microsoft.Extensions.Caching.Memory;

namespace DnDWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly ILogger<DiceController> _logger;
        private readonly IMemoryCache _memoryCache;

        public CharacterController(
             ILogger<DiceController> logger,
             IMemoryCache memoryCache
             )
        {
            _logger = logger;
            _memoryCache = memoryCache;
        }

        [HttpPost]
        [Route("create")]
        public IActionResult PostCharCreate([FromBody] Character character)
        {
            Guid id = Guid.NewGuid();

            _memoryCache.Set(id, character);

            var result = new KeyValuePair<string, Guid>("Key", id);
            return Ok(result);
        }

        [HttpGet]
        [Route("getcharacter")]
        public IActionResult GetCharacter([FromQuery] Guid id) {
            return Ok(_memoryCache.Get(id));
        }
    }
}
