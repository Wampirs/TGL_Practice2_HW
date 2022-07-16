namespace TGL_Practice2_HW.Models.Base.Spells
{
    internal abstract class Spell
    {
        public string Name { get; private set; } = "NotInitSpellName";
        public int ManaCost { get; private set; }

        public abstract int? SpellAction();

        public Spell(string _name,int _manaCost)
        {
            Name = _name;
            ManaCost = _manaCost;
        }
    }
}
