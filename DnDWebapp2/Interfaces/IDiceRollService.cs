using DnDWebapp2.Models;

namespace DnDWebapp2.Interfaces
{
    public interface IDiceRollService
    {
        public DiceResponse RollDice(int numDice, int numSides);
    }
}
