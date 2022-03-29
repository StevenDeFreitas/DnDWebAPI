using DnDWebAPI.Interfaces;

namespace DnDWebAPI.Services
{
    public class DiceRollService : IDiceRollService
    {
        public int RollDice(int numSides)
        {
            if (numSides == 0) {
                return -1;
            }
           var rnd = new Random();
            int result = rnd.Next(1,numSides+1);
            return result;
        }
    }
}
