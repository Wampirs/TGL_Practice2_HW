using System.Text;
using TGL_Practice2_HW.Models.Base.Spells;

namespace TGL_Practice2_HW.Models.Base
{
    internal class Hero
    {
        private int baseStrenght;
        private int baseAgility;
        private int baseIntelect;
        private int currentHealth;
        private int currentMana;
        public string Name { get; set; }
        public int Strength
        {
            get
            {
                int result = 0;
                foreach (Item item in Bag.Items)
                {
                    result += item.AddStrenght;
                }
                return result + baseStrenght;
            }
            private set => baseStrenght = value;
        }
        public int Agility
        {
            get
            {
                int result = 0;
                foreach (Item item in Bag.Items)
                {
                    result += item.AddAgility;
                }
                return result + baseAgility;
            }
            private set => baseAgility = value;
        }
        public int Intelect
        {
            get
            {
                int result = 0;
                foreach (Item item in Bag.Items)
                {
                    result += item.AddIntelect;
                }
                return result + baseIntelect;
            }
            private set => baseIntelect = value;
        }
        public Atribute MainAtribute { get; private set; }
        public int MaxHealth
        {
            get
            {
                int baseHealth = Strength * 10;
                int bonusHealth = 0;
                foreach (Item item in Bag.Items)
                {
                    bonusHealth += item.AddHealth;
                }
                return baseHealth + bonusHealth;
            }
        }
        public int CurrentHealth
        {
            get => currentHealth;
            set => currentHealth = value;
        }
        public double Armor => Agility * 0.1428571428571429;
        public int MaxMana
        {
            get
            {
                int baseMana = Intelect * 10;
                int bonusMana = 0;
                foreach (Item item in Bag.Items)
                {
                    bonusMana += item.AddMana;
                }
                return baseMana + bonusMana;
            }
        }
        public int CurrentMana
        {
            get => currentMana;
            set => currentMana = value;
        }
        public int HitDamage
        {
            get
            {
                switch (MainAtribute)
                {
                    case Atribute.Strenght:
                        return 30 + Strength;
                    case Atribute.Agility:
                        return 30 + Agility;
                    case Atribute.Intelect:
                        return 30 + Intelect;
                    default: return 0;
                }
            }
        }
        private Spell[] Spells { get; } = new Spell[4];
        public IBag Bag { get; } = new Bag();
        public void Atack(out int _hitdamage, out string _castedSpellName, out int _spellDamage)
        {
            int castChance = Random.Shared.Next(100);
            string castedSpellName = string.Empty;
            int castedSpellDamage = 0;
            if (castChance < 25) CastSpell(out castedSpellName, out castedSpellDamage);
            _hitdamage = HitDamage;
            if (castedSpellName != string.Empty && castedSpellDamage != 0)
            {
                _castedSpellName = castedSpellName;
                _spellDamage = castedSpellDamage;
            }
            else
            {
                _castedSpellName = string.Empty;
                _spellDamage = 0;
            }
            return;
        }
        //TODO: Change method for heal spell. Now only for DamageSpell
        public void CastSpell(out string _spellName, out int _spellDamage)
        {
            _spellDamage = 0;
            _spellName = string.Empty;
            DamageSpell spellToCast = Spells[Random.Shared.Next(Spells.Length)] as DamageSpell;
            if (spellToCast.ManaCost > CurrentMana) return;
            _spellName = spellToCast.Name;
            _spellDamage = spellToCast.Damage;
            CurrentMana -= spellToCast.ManaCost;
        }
        public Hero(string _name, int _strength, int _agility, int _intelect, Atribute _mainAtribute, Spell[] _spells, Bag bag)
        {
            Name = _name;
            Strength = _strength;
            Agility = _agility;
            Intelect = _intelect;
            MainAtribute = _mainAtribute;
            Spells = _spells;
            Bag = bag;
            CurrentHealth = MaxHealth;
            CurrentMana = MaxMana;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Hero name: {Name}\n");
            sb.Append($"Health: {CurrentHealth}\\{MaxHealth}\n" +
                $"Mana: {CurrentMana}\\{MaxMana}\n\n");
            sb.Append("Atributes:\n" +
                $"Strenght: {Strength}\n" +
                $"Agility: {Agility}\n" +
                $"Intelect: {Intelect}\n" +
                $"Main atribute: {MainAtribute.ToString()}\n\n");
            sb.Append($"Hit damage: {HitDamage}\n" +
                $"Armor: {Armor}\n\n");
            sb.Append("SPELS:\n" +
                "Spell name         Mana cost       Damage\n");
            foreach (var spell in Spells) { sb.Append(spell.ToString()); }
            sb.Append("\n");
            sb.Append(Bag.ToString());
            return StringBuilderExtension.StringInBox(sb.ToString(), '#');
        }
    }


    internal enum Atribute
    {
        Strenght,
        Agility,
        Intelect
    }
}
