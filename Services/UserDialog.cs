using System.Text;
using TGL_Practice2_HW.Services.Interfaces;

namespace TGL_Practice2_HW.Services
{
    internal class UserDialog : IUserDialog
    {
        public bool AskBool(string _question)
        {
            while (true)
            {
                Console.WriteLine(_question);
                Console.WriteLine("Yes\\No   Y\\N   y\\n");
                string? answer = Console.ReadLine();
                if (answer != null)
                {
                    if (answer.Equals("Yes") || answer.Equals("Y") || answer.Equals("y")) return true;
                    if (answer.Equals("No") || answer.Equals("N") || answer.Equals("n")) return false;
                    Console.WriteLine("Incorrect answer");
                }
            }
        }

        public string AskString(string _question, string[] _answers)
        {
            while (true)
            {
                Console.WriteLine(_question);
                Console.WriteLine($"Possible answers: {String.Join(", ",_answers)}");
                string? answer = Console.ReadLine();
                if (answer != null)
                {
                    if (_answers.Contains(answer)) return answer;
                    Console.WriteLine("Incorrect answer");
                }
            }
        }

        public void Inform(string _info)
        {
            Console.WriteLine(_info);
        }

        public void StartUpInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Hello, User!");
            sb.AppendLine("This game about fight of two heroes, who have uniq set of atributes, spels and items in their bag.");
            sb.AppendLine("Now you have possibility only to look on this fight in text mode. (all heroes and items will be selected by random)");
            sb.AppendLine("Maybe in future I will add to this game more interactivity and possibility to control heroes in manual mode.");
            sb.AppendLine("Have fun!");
            Inform(sb.ToString());
        }
    }
}
