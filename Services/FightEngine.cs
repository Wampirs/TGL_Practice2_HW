using System.Text;
using TGL_Practice2_HW.Models.Base;
using TGL_Practice2_HW.Services.Interfaces;

namespace TGL_Practice2_HW.Services
{
    internal class FightEngine : IFightEngine
    {
        private readonly IUserDialog dialog;
        public Hero StartDuel(Hero _first, Hero _second)
        {
            Hero winner;
            int round = 1;
            while (true)
            {
                dialog.Clear();
                dialog.Inform($"ROUND {round}");
                Atack(_first, _second);
                if (_second.CurrentHealth <= 0)
                {
                    dialog.Inform($"{_first.Name} killed {_second.Name}");
                    winner = _first;
                    break;
                }
                Atack(_second, _first);
                if (_first.CurrentHealth <= 0)
                {
                    dialog.Inform($"{_second.Name} killed {_first.Name}");
                    winner = _second;
                    break;
                }
                dialog.WaitAnyKey("Press key to see next round");
                round++;
            }
            return winner;
        }

        private void Atack(Hero _atacker, Hero _target)
        {
            StringBuilder sb = new StringBuilder();
            int hitDamage;
            int spellDamage;
            string spellName = string.Empty;
            _atacker.Atack(out hitDamage,out spellName,out spellDamage);
            _target.CurrentHealth -= hitDamage + spellDamage;
            sb.Append($"{_atacker.Name} dealed {hitDamage} damage. ");
            if (spellName != string.Empty) sb.Append($"And dealed {spellDamage} from {spellName} spell.");
            dialog.Inform( StringBuilderExtension.StringInBox(sb.ToString(),'&','+'));
        }
        public FightEngine(IUserDialog _dialog)
        {
            dialog = _dialog;
        }
    }
}
