using TGL_Practice2_HW.Models.Base;
using TGL_Practice2_HW.Services.Interfaces;

namespace TGL_Practice2_HW.Services
{
    internal class FightEngine : IFightEngine
    {
        private readonly IUserDialog dialog;
        public Hero StartDuel(Hero _first, Hero _second)
        {
            Hero winner;

            

            return winner;
        }

        public FightEngine(IUserDialog _dialog)
        {
            dialog = _dialog;
        }
    }
}
