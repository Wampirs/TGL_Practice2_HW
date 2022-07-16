using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TGL_Practice2_HW.Models.Base.Spells;

namespace TGL_Practice2_HW.Models.Base
{
    internal abstract class Hero
    {
        private int baseStrenght;
        private int baseAgility;
        private int baseIntelect;
        private int baseDamage;
        private int baseHealth
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

        public int Health => Strength * 10;
        public double Armor => Agility * 0.1428571428571429;
        public int Mana => Intelect * 10;
        public int HitDamage 
        {
            get
            {
                switch (MainAtribute)
                {
                    case Atribute.Strenght:
                        return BaseDamage + Strength;
                    case Atribute.Agility:
                        return BaseDamage + Agility;
                    case Atribute.Intelect:
                        return BaseDamage + Intelect;
                    default: return 0;
                }
            }
        }

        private Spell[] Spells;
        public Bag Bag { get; } = new Bag();
    }

    internal enum Atribute
    { 
        Strenght,
        Agility,
        Intelect
    } 
}
