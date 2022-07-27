using System.Collections;

namespace TGL_Practice2_HW.Models.Base
{
    internal interface IBag : IEnumerable
    {
        List<Item> Items { get; }
        int ItemsCount { get; }
        new IEnumerator GetEnumerator();
        Item this[int index] { get; }

        void DropItem(Item _item);
        void TakeItem(Item _item);
        string ToString();

        delegate void OnBagChange();
        event OnBagChange? BagChanged;
    }
}