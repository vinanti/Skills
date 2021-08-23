/*String Extra Operations
 https://leetcode.com/explore/learn/card/array-and-string/203/introduction-to-string/1158/
 */
using System;

namespace CodingQuestion
{
    class String05_Operations
    {
        static void Main05()
        {
            String s1 = "Hello World";
            // 1. concatenate
            s1 += "!";
            Console.WriteLine(s1);
            // 2. find
            Console.WriteLine("The position of first 'o' is: " + s1.IndexOf('o'));
            Console.WriteLine("The position of last 'o' is: " + s1.LastIndexOf('o'));
            // 3. get substring
            Console.WriteLine(s1.Substring(6, 5));
        }
    }
}
