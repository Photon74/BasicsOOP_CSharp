using System.Text;

namespace Coder
{
    public class ACoder : ICoder
    {
        public string Decode(string str)
        {
            StringBuilder sb = new();
            char[] s = str.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = (--s[i]);
                sb.Append(s[i]);
            }
            return sb.ToString()!;
        }

        public string Encode(string str)
        {
            StringBuilder sb = new();
            char[] s = str.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = (++s[i]);
                sb.Append(s[i]);
            }
            return sb.ToString()!;
        }
    }
}
