using TGL_Practice2_HW.Services.Interfaces;

namespace TGL_Practice2_HW.Services
{
    internal class ProgramEngine : IProgramEngine
    {
        IUserDialog dialog;
        IFightEngine fight;
        public void StartGame()
        {
            dialog.StartUpInfo();
            if(dialog.AskBool("Start the game?")==false)return;
            dialog.Inform("Game started");
        }

        public ProgramEngine(IUserDialog _dialog, IFightEngine _fight)
        {
            dialog = _dialog;
            fight = _fight;
        }
    }
}
