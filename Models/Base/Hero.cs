using TGL_Practice2_HW.Models.Base.Spells;

namespace TGL_Practice2_HW.Models.Base
{
    internal class Hero
    {
        private int baseStrenght;
        private int baseAgility;
        private int baseIntelect;
        private int health;
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
        public int Agility {
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
            private set=> baseIntelect = value;
        }
        public Atribute MainAtribute { get; private set; }
        public int Health
        {
            get => health;
            set => health = value;
        }
        public double Armor => Agility * 0.1428571428571429;
        public int Mana => Intelect * 10;
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
        public Bag Bag { get; } = new Bag();
        public void Atack(out int _hitdamage, out string _castedSpellName, out int _spellDamage)
        {
            int castChance = Random.Shared.Next(100);
            string castedSpellName = string.Empty;
            int castedSpellDamage = 0;
            if (castChance < 25) CastSpell(out castedSpellName,out castedSpellDamage);
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
            if (spellToCast.ManaCost > Mana) return;
            _spellName = spellToCast.Name;
            _spellDamage = spellToCast.Damage;
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
            Health = 100 + Strength;
        }
    }


    internal enum Atribute
    { 
        Strenght,
        Agility,
        Intelect
    } 
}
