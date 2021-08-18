/*String Operations
Concatenate
Find
Get Substring
 */
using System;

namespace Q111ns
{
    class Q111
    {
        static void Main111()
        {
            String s1 = "Hello World";
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
