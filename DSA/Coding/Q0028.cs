using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
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
