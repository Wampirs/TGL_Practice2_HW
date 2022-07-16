namespace TGL_Practice2_HW.Models.Base.Spells
{
    internal class HealSpell : Spell
    {
        public int Heal { get; private set; }
        public override int? SpellAction()
        {
            return Heal;
        }

        public HealSpell(string _name, int _manacost, int _heal):base(_name,_manacost)
        {
            Heal = _heal;
        }
    }
}
