using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
    class AString07_ImmutableStringSolution
    {
        // "static void main" must be defined in a public class.
        public static void Main07()
        {
            string s = "Hello World";
            char[] str = s.ToCharArray();
            str[5] = ',';
            Console.WriteLine(str);

            int n = 10000;
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                strBuilder.Append("hello");
            }
            string s1 = strBuilder.ToString();
            Console.WriteLine(s1);
        }


    }
}
