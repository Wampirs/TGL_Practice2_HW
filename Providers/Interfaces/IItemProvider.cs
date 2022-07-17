using TGL_Practice2_HW.Models.Base;

namespace TGL_Practice2_HW.Providers.Interfaces
{
    internal interface IItemProvider
    {
        public List<Item> Items { get; }
        public Item GetRandomItem();
    }
}
