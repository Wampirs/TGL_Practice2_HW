using TGL_Practice2_HW.Models.Base;
using TGL_Practice2_HW.Models.Base.Spells;
using TGL_Practice2_HW.Providers.Interfaces;

namespace TGL_Practice2_HW.Providers
{
    internal class HeroProvider : IHeroProvider
    {
        private readonly IItemProvider shop;
        private List<Hero> heroes;
        public List<Hero> Heroes => heroes??= new List<Hero>(); 

        public Hero GetRandomHero()
        {
            Hero randomHero = heroes[Random.Shared.Next(heroes.Count)];
            heroes.Remove(randomHero);
            return randomHero;
        }

        public HeroProvider(IItemProvider _shop)
        {
            shop = _shop;
            Fill();
        }

        private void Fill()
        {
            Heroes.Add(CreateSniper());
            Heroes.Add(CreateMars());
        }

        private Hero CreateSniper()
        {
            Spell[] sniperSpels = new Spell[] {
            new DamageSpell("Headshot",0,60),
            new DamageSpell("Shrapnell",50,100)};
            Bag sniperItems = new Bag();
            for(int i=0;i<3;i++) sniperItems.TakeItem(shop.GetRandomItem());
            Hero sniper = new Hero("Sniper",15, 20, 10, Atribute.Agility, sniperSpels, sniperItems);
            return sniper;
        }
        private Hero CreateMars()
        {
            Spell[] marsSpels = new Spell[] {
            new DamageSpell("Spear",100,90),
            new DamageSpell("Shield",50,60)};
            Bag marsItems = new Bag();
            for (int i = 0; i < 3; i++) marsItems.TakeItem(shop.GetRandomItem());
            Hero sniper = new Hero("Mars", 25, 10, 10, Atribute.Agility, marsSpels, marsItems);
            return sniper;
        }
    }
}
