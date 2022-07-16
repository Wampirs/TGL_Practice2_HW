using TGL_Practice2_HW.Models.Base;
using TGL_Practice2_HW.Providers.Interfaces;

namespace TGL_Practice2_HW.Providers
{
    internal class ItemProvider : IItemProvider
    {
        private List<Item> items;
        public List<Item> Items => items??=new List<Item>();

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
            Items.Add(new Item("Iron Branch",1,1,1));
            Items.Add(new Item("Ultimate orb",10,10,10));
            Items.Add(new Item("Chainmail", 0, 0, 0, 0, 0, 0, 5));
            Items.Add(new Item("Broadsword", 0, 0, 0, 0, 0, 15));
            Items.Add(new Item("Vitality booster",0,0,0,250));
            Items.Add(new Item("Mana booster", 0, 0, 0, 0, 250));
            Items.Add(new Item("Point booster", 0, 0, 0, 150, 150));
        }
    }
}
