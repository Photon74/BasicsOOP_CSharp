using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coder
{
    public class BCoder : ICoder
    {
        const int k = 2111;
        public string Decode(string str)
        {
            throw new NotImplementedException();
        }

        public string Encode(string str)
        {
            //var koof = ;
            StringBuilder sb = new();
            char[] s = str.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = (char)(s[i] + (k - (s[i] * 2)));
                sb.Append(s[i]);
            }
            return sb.ToString()!;
        }
    }
}
