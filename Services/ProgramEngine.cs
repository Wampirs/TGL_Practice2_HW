using TGL_Practice2_HW.Models.Base;
using TGL_Practice2_HW.Providers.Interfaces;
using TGL_Practice2_HW.Services.Interfaces;

namespace TGL_Practice2_HW.Services
{
    internal class ProgramEngine : IProgramEngine
    {
        private readonly IUserDialog dialog;
        private readonly IFightEngine fight;
        private readonly IHeroProvider tavern;

        private Hero firstHero;
        private Hero secondHero;

        public void StartGame()
        {
            dialog.StartUpInfo();
            if(dialog.AskBool("Start the game?")==false)return;
            dialog.Clear();
            firstHero = tavern.GetRandomHero();
            secondHero = tavern.GetRandomHero();
            dialog.Inform($"Chosen 2 heroes: {firstHero.Name} and {secondHero.Name}");
            if (dialog.AskBool("Do you want to see heroes info?") == true)
            {
                dialog.Clear();
                dialog.Inform(firstHero.ToString());
                dialog.WaitAnyKey("Press any key to close hero overview");
                dialog.Clear();
                dialog.Inform(secondHero.ToString());
                dialog.WaitAnyKey("Press any key to close hero overview");
            }
            Hero winner = fight.StartDuel(firstHero,secondHero);
            dialog.WaitAnyKey($"Winner: {winner.Name}");
            
        }

        public ProgramEngine(IUserDialog _dialog, IFightEngine _fight, IHeroProvider _tavern)
        {
            dialog = _dialog;
            fight = _fight;
            tavern = _tavern;
        }
    }
}
