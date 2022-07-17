using System.Text;

namespace TGL_Practice2_HW.Models.Base.Spells
{
    internal class DamageSpell : Spell
    {
        public int Damage { get; private set; }
        public int CritChance { get; private set; }
        public override int? SpellAction()
        {
            if (Random.Shared.Next(100) < CritChance) return Damage * 2;
            return Damage;
        }

        public DamageSpell(string _name, int _manaCost, int _damage,  int _critChance = 0) : base(_name,_manaCost)
        {
            Damage = _damage;
            CritChance = _critChance;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Name}               {ManaCost}             {Damage}\n");
            return sb.ToString();
        }
    }
}
