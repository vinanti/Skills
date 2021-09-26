using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_AString06
{
    class AString06_Operations
    {
        // "static void main" must be defined in a public class
        public static void Main06()
        {
            string s1 = "Hello World";

            // 1. concatenate
            s1 += "!";
            Console.WriteLine(s1);

            // 2. find
            Console.WriteLine("The position of first 'o' is: " + s1.IndexOf('o'));
            Console.WriteLine("The position of last 'o' is: " + s1.LastIndexOf('o'));
            
            // 3. get substring
            Console.WriteLine(s1.Substring(6, 6));
        }
    }
}
