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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(new string('X', 15));
            sb.AppendLine("X" + Name + "X");
            if (AddStrenght > 0) sb.AppendLine("X" + $"Bonus strenght: {AddStrenght}" + "X");
            if (AddAgility > 0) sb.AppendLine("X" + $"Bonus agility: {AddAgility}" + "X");
            if (AddIntelect > 0) sb.AppendLine("X" + $"Bonus intelect: {AddIntelect}" + "X");
            if (AddHealth > 0) sb.AppendLine("X" + $"Bunus health: {AddHealth}" + "X");
            if (AddMana > 0) sb.AppendLine("X" + $"Bonus Mana: {AddMana}" + "X");
            if (AddDamage > 0) sb.AppendLine("X" + $"Donus damage: {AddDamage}" + "X");
            if (AddArmor > 0) sb.AppendLine("X" + $"Bonus armor: {AddArmor}" + "X");
            sb.AppendLine(new string('X', 15));
            return sb.ToString();

        }
    }
}
