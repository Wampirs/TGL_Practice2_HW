using System.Collections;
using System.Text;

namespace TGL_Practice2_HW.Models.Base
{
    internal class Bag : IBag
    {
        private int maxItemsCount = 6;
        private List<Item> items = new List<Item>();

        public List<Item> Items => items;
        public int ItemsCount => items.Count();

        public Item this[int index] => items[index];

        public void TakeItem(Item _item)
        {
            if (ItemsCount == maxItemsCount) throw new Exception("Bag is full");
            items.Add(_item);
            if (BagChanged is not null)
            {
                BagChanged();
            }
        }
        public void DropItem(Item _item)
        {
            Item removeCandidate = items.First(x => x.Name == _item.Name);
            if (removeCandidate == null) throw new Exception("Bag doesn`t exist such item");
            items.Remove(items.First(x => x.Name == _item.Name));
            if (BagChanged is not null)
            {
                BagChanged();
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("BAG:\n");
            foreach (Item item in items)
            {
                sb.Append(item.ToString());
            }
            return StringBuilderExtension.StringInBox(sb.ToString(), 'X');
        }

        public IEnumerator GetEnumerator()
        {
            foreach (Item item in items)
            {
                yield return item;
            }
        }

        public event IBag.OnBagChange? BagChanged;
    }
}
