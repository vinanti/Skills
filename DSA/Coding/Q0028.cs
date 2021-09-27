using System;

namespace Coding_Q0028
{
    class Q0028
    {
        static void Main28()
        {
            StrStr("hello", "ll"); //2
        }
        public static int StrStr(string haystack, string needle)
        {
            if (needle.Length == 0) return 0;
            return haystack.IndexOf(needle);
        }
    }
}
