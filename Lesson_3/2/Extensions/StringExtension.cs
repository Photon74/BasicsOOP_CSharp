using System;
using System.Linq;

namespace Extensions
{
    public static class StringExtension
    {
        public static string ReverseString(this string str)
        {
            return new string(str.Reverse().ToArray());
        }
    }
}
