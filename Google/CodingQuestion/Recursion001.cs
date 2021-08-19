/*Print a string in reverse order.
 * https://leetcode.com/explore/learn/card/recursion-i/250/principle-of-recursion/1439/
 
 */
using System;
class Recursion001
{
    static void Main001()
    {
        printReverse("Hello");
    }
    static void printReverse(string str)
    {
        helper(0, str.ToCharArray());
    }

    static void helper(int index, char[] str)
    {
        if (str == null || index >= str.Length)
        {
            return;
        }
        helper(index + 1, str);
        Console.WriteLine(str[index]);
    }
}
