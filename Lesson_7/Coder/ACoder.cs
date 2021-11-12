using System.Text;

namespace Coder
{
    public class ACoder : ICoder
    {
        private readonly StringBuilder sb = new();
        private char[] s;

        public string Decode(string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                sb.Clear();
                s = str.ToCharArray();
                for (int i = 0; i < s.Length; i++)
                {
                    s[i] = (int)s[i] switch
                    {
                        < 1040 or > 1103 => s[i],
                        1040 => (char)1071,
                        1072 => (char)1103,
                        _ => --s[i],
                    };

                    sb.Append(s[i]);
                }
                return sb.ToString();
            }
            throw new ArgumentException($"\"{nameof(str)}\" не может быть неопределенным или пустым.");
        }

        public string Encode(string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                sb.Clear();
                s = str.ToCharArray();
                for (int i = 0; i < s.Length; i++)
                {
                    s[i] = (int)s[i] switch
                    {
                        < 1040 or > 1103 => s[i],
                        1071 => (char)1040,
                        1103 => (char)1072,
                        _ => ++s[i],
                    };

                    sb.Append(s[i]);
                }
                return sb.ToString();
            }
            throw new ArgumentException($"\"{nameof(str)}\" не может быть неопределенным или пустым.");
        }
    }
}
