using System;
using System.Collections.Generic;
using System.Linq;

namespace CCIH.Utilities.ObfuscateID
{
    public static class Obfuscate
    {
        private const string CharList = "abcdefghijklmnopqrstuvwxyz0123456789";
        public const int Base = 36;

        public static string Encode(long input)
        {
            if (input < 0)
            {
                return string.Empty;
            }

            char[] clistarr = CharList.ToCharArray();
            Stack<char> result = new Stack<char>();
            while (input != 0)
            {
                result.Push(clistarr[input % Base]);
                input /= Base;
            }
            return new string(result.ToArray());
        }


        public static long Decode(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }

            IEnumerable<char> reversed = input.ToLower().Reverse();
            long result = 0;
            long pos = 0;
            foreach (char c in reversed)
            {
                result += (CharList.IndexOf(c) * (long)Math.Pow(Base, pos));
                pos++;
            }
            return result;
        }
    }
}
