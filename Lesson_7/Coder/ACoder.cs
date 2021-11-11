using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coder
{
    public class ACoder : ICoder
    {
        public string Decode(string str)
        {
            byte[] byteArray = Encoding.Default.GetBytes(str);
            for (int i = 0; i < byteArray.Length; i++)
            {
                byteArray[i] = (byte)(byteArray[i] - 1);
            }
            return Encoding.UTF8.GetString(byteArray);
        }

        public string Encode(string str)
        {
            byte[] byteArray = Encoding.Unicode.GetBytes(str);
            for (int i = 0; i < byteArray.Length; i++)
            {
                byteArray[i] = (byte)(byteArray[i] + 1);
            }
            return Encoding.Unicode.GetString(byteArray);
        }
    }
}
