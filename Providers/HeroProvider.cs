using TGL_Practice2_HW.Models.Base;
using TGL_Practice2_HW.Providers.Interfaces;

namespace TGL_Practice2_HW.Providers
{
    internal class HeroProvider : IHeroProvider
    {
        private List<Hero> heroes;
        public List<Hero> Heroes => heroes; 

        public Hero GetRandomHero()
        {
            return heroes[Random.Shared.Next(heroes.Count+1)];
        }

        public HeroProvider()
        {
            Fill();
        }

        private void Fill()
        {

        }
    }
}
