using System.Text;

namespace TGL_Practice2_HW.Models.Base
{
    internal class Bag
    {
        private int maxItemsCount = 6;
        private List<Item> items = new List<Item>();
        public List<Item> Items => items;
        public int ItemsCount => items.Count();

        public void TakeItem (Item _item)
        {
            if (ItemsCount == maxItemsCount) throw new Exception("Bag is full");
            items.Add(_item);
        }
        public void DropItem (Item _item)
        {
            Item removeCandidate = items.First(x => x.Name == _item.Name);
            if (removeCandidate == null) throw new Exception("Bag doesn`t exist such item");
            items.Remove(items.First(x => x.Name == _item.Name));
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(new string('-', 20));
            foreach(Item item in items)
            {
                sb.AppendLine("| " + item.ToString() + " |");
            }
            sb.AppendLine(new string('-', 20));
            return sb.ToString();
        }
    }
}
