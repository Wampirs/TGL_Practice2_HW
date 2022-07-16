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
            items.Add(new Item())
        }
    }
}
