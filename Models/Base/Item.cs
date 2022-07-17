using System.Text;

namespace TGL_Practice2_HW.Models.Base
{
    internal class Item
    {
        public string Name { get; set; } = "NotInitItemName";
        public int AddStrenght { get; private set; }
        public int AddAgility { get; private set; }
        public int AddIntelect { get; private set; }
        public int AddHealth { get; private set; }
        public int AddMana { get; private set; }
        public int AddDamage { get; private set; }
        public int AddArmor { get; private set; }

        public Item(string name, int addStrenght = 0, int addAgility = 0, int addIntelect = 0, int addHealth = 0, int addMana = 0, int addDamage = 0, int addArmor = 0)
        {
            Name = name;
            AddStrenght = addStrenght;
            AddAgility = addAgility;
            AddIntelect = addIntelect;
            AddHealth = addHealth;
            AddMana = addMana;
            AddDamage = addDamage;
            AddArmor = addArmor;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Name}\n");
            if (AddStrenght > 0) sb.Append($"Bonus strenght: {AddStrenght}\n");
            if (AddAgility > 0) sb.Append($"Bonus agility: {AddAgility}\n");
            if (AddIntelect > 0) sb.Append($"Bonus intelect: {AddIntelect}\n");
            if (AddHealth > 0) sb.Append($"Bunus health: {AddHealth}\n");
            if (AddMana > 0) sb.Append($"Bonus Mana: {AddMana}\n");
            if (AddDamage > 0) sb.Append($"Bonus damage: {AddDamage}\n");
            if (AddArmor > 0) sb.Append($"Bonus armor: {AddArmor}\n");
            return StringBuilderExtension.StringInBox(sb.ToString(),'|','-');
        }
    }
}
