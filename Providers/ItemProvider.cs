using TGL_Practice2_HW.Models.Base;
using TGL_Practice2_HW.Providers.Interfaces;

namespace TGL_Practice2_HW.Providers
{
    internal class ItemProvider : IItemProvider
    {
        private readonly List<Item> items;
        public List<Item> Items => items;

        public Item GetRandomItem()
        {
            return items[Random.Shared.Next(items.Count+1)];
        }
        public ItemProvider()
        {
            Fill();
        }
        private void Fill()
        {
            items.Add(new Item("Iron Branch",1,1,1));
            items.Add(new Item("Ultimate orb",10,10,10));
            items.Add(new Item("Chainmail", 0, 0, 0, 0, 0, 0, 5));
            items.Add(new Item("Broadsword", 0, 0, 0, 0, 0, 15));
            items.Add(new Item("Vitality booster",0,0,0,250));
            items.Add(new Item("Mana booster", 0, 0, 0, 0, 250));
            items.Add(new Item("Point booster", 0, 0, 0, 150, 150));
        }
    }
}
