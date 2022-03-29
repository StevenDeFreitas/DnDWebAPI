using DnDWebapp2.Interfaces;
using DnDWebapp2.Models;
using Microsoft.AspNetCore.Mvc;


namespace DnDWebapp2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiceController : Controller
    {
        private readonly IDiceRollService _diceRollService;
        private readonly ILogger<DiceController> _logger;

        public DiceController(ILogger<DiceController> logger,
            IDiceRollService diceRollService
            ) {
            _diceRollService = diceRollService;
            _logger = logger;
        }
        [HttpGet]
        [Route("roll")]
        public async Task<DiceResponse> Get([FromQuery]int numDice, int numSides)
        {
            return _diceRollService.RollDice(numDice, numSides);
        }
    }
}
