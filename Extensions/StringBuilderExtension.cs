using System.Text;

namespace System.Text
{
    internal class StringBuilderExtension
    {
        public static string StringInBox (string _st, char _border)
        {
            StringBuilder builder = new StringBuilder ();
            builder.Append (new string(_border,MaxWidth(_st)+4)+"\n");
            builder.Append(AddSides(_st, _border));
            builder.Append(new string(_border, MaxWidth(_st)+4)+"\n");
            return builder.ToString ();
        }

        public static string StringInBox(string _st, char _sideBorder,char _topBotBorder)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(new string(_topBotBorder, MaxWidth(_st) + 4) + "\n");
            builder.Append(AddSides(_st, _sideBorder));
            builder.Append(new string(_topBotBorder, MaxWidth(_st) + 4) + "\n");
            return builder.ToString();
        }

        private static string AddSides (string _st, char sideChar)
        {
            StringBuilder builder = new StringBuilder ();
            string[] subs = _st.Split("\n");
            int width = MaxWidth(subs);
            for(int i = 0; i < subs.Length; i++)
            {
                if (i == subs.Length)
                {
                    builder.Append($"{sideChar} {subs[i]}{new string(' ', width - subs[i].Length)} {sideChar}");
                    break;
                }
                builder.Append($"{sideChar} {subs[i]}{new string(' ',width - subs[i].Length)} {sideChar}\n");

            }
            
            return builder.ToString ();
        }

        private static int MaxWidth(string[] _strings)
        {
            int res = 0;
            foreach(string s in _strings)
            {
                if (s.Length > res) res = s.Length;
            }
            return res;
        }
        private static int MaxWidth(string _st)
        {
            string[] subs = _st.Split("\n");
            return MaxWidth(subs);
        }

    }
}
