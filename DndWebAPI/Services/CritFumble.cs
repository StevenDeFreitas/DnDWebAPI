using DnDWebAPI.Interfaces;

namespace DnDWebAPI.Services
{
    public class CritFumbleService : ICritFumbleService
    {
        public string GetCritFumble()
        {
            var rnd = new Random();
            int result = rnd.Next(1, 5);
            switch (result)
            {
                default:
                    return "Die";
                case 1:
                    return "You drop your weapon";

                case 2:
                    return "Take 5 damage";

                case 3:
                    return "Do 1D4 damage to your closest ally";

                case 4:
                    return "Take 1D6 damage";

                case 5:
                    return "Make a death save";

            }
        }
    }
}
