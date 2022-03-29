using System.Text.Json.Serialization;

namespace DnDWebapp2.Models
{
    public class DiceResponse
    {
        [JsonPropertyName("diceRolls")]
        public List<int> DiceRolls { get; set; }
    }
}
