using TGL_Practice2_HW.Models.Base;

namespace TGL_Practice2_HW.Services.Interfaces
{
    internal interface IFightEngine
    {
        public Hero StartDuel(Hero _first, Hero _second);
    }
}
