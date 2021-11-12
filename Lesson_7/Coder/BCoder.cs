using System.Text;

namespace Coder
{
    public class BCoder : ICoder
    {
        private const int k1 = 2111; // коэффициент для ПРОПИСНЫХ букв кириллицы
        private const int k2 = 2175; // коэффициент для строчных букв кириллицы
        private readonly StringBuilder sb = new();
        private int k;
        private char[] s;

        public string Decode(string str) => Encode(str);

        public string Encode(string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                sb.Clear();
                s = str.ToCharArray();
                for (int i = 0; i < s.Length; i++)
                {
                    k = (int)s[i] switch
                    {
                        >= 1040 and <= 1071 => k1,
                        >= 1072 and <= 1103 => k2,
                        _ => s[i] * 2,
                    };

                    s[i] = (char)(s[i] + (k - (s[i] * 2)));
                    sb.Append(s[i]);
                }
                return sb.ToString();
            }
            throw new ArgumentException($"\"{nameof(str)}\" не может быть неопределенным или пустым.");
        }
    }
}
