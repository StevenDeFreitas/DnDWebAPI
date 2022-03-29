using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DnDWebAPI.Interfaces;

namespace DnDWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiceController : ControllerBase
    {
        private readonly ICritFumbleService _critFumbleService;
        private readonly IDiceRollService _diceRollService;//I have space for an IDiceRollService
        private readonly ILogger<DiceController> _logger; //I have space for an Ilogger
        public DiceController(
            ILogger<DiceController> logger, 
            IDiceRollService diceRollService,
            ICritFumbleService critFumbleService
            ) //I want to create my dice controller and get any externals I want
        {
            _diceRollService = diceRollService;
            _critFumbleService = critFumbleService;
            _logger = logger; //assigning logger to variable
        }

        [HttpGet] //start get functions
        [Route("roll")]
        public IActionResult Get([FromQuery] int numSides)
        {
            return Ok(_diceRollService.RollDice(numSides));
        }

        [HttpGet]
        [Route("critfumble")]
        public IActionResult GetCritFumble() {
            return Ok(_critFumbleService.GetCritFumble());
        }

    }
}
