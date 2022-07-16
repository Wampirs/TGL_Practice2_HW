using TGL_Practice2_HW.Models.Base;

namespace TGL_Practice2_HW.Providers.Interfaces
{
    internal interface IHeroProvider
    {
        public List<Hero> Heroes { get; }
        public Hero GetRandomHero();
    }
}
