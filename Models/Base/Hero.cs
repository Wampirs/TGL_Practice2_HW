using TGL_Practice2_HW.Models.Base.Spells;

namespace TGL_Practice2_HW.Models.Base
{
    internal abstract class Hero
    {
        private int baseStrenght;
        private int baseAgility;
        private int baseIntelect;
        private int baseDamage = 30;
        private int baseHealth = 100;
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

        public int Health => baseHealth + Strength * 10;
        public double Armor => Agility * 0.1428571428571429;
        public int Mana => Intelect * 10;
        public int HitDamage 
        {
            get
            {
                switch (MainAtribute)
                {
                    case Atribute.Strenght:
                        return baseDamage + Strength;
                    case Atribute.Agility:
                        return baseDamage + Agility;
                    case Atribute.Intelect:
                        return baseDamage + Intelect;
                    default: return 0;
                }
            }
        }

        private Spell[] Spells { get; } = new Spell[4];
        public Bag Bag { get; } = new Bag();
    }

    internal enum Atribute
    { 
        Strenght,
        Agility,
        Intelect
    } 
}
