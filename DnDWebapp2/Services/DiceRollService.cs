using DnDWebapp2.Interfaces;
using DnDWebapp2.Models;

namespace DnDWebapp2.Services
{
    public class DiceRollService : IDiceRollService
    {
        public DiceResponse RollDice(int numDice, int numSides)
        {
            List<int> results = new List<int>();
            if (numSides == 0)
            {
                return new DiceResponse();
            }
            for (int i = 0; i < numDice; i++)
            {

                var rnd = new Random();
                int result = rnd.Next(1, numSides + 1);
                results.Add(result);

            }
            return new DiceResponse { DiceRolls = results};

        }
    }
}

