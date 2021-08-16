/*Design Anagrams
 Given two strings (lowercase a->z), how many characters do we need to remove (from either)
to make them anagram?
Example
hellow, billion --> 6 (he from hello and biin from billion)

Q.
empty -> 0
case sensitive? all lower case
max limit

T.
"", "" --> 0
abc, "" --> 3
aaa, a --> 2
hello, billion --> 6
glue, legs --> 2
candy, day --> 2

A.
empty -> 0
either input empty -> length of other input
string -> 'a-z'
compare occurance
count = diffrence

E.
hello, billion --> 6
//b=1, e=1, h=1, i=2, n=1 = 6

C.
O(n)

Error:
1. string passed without double quotes
2. argument data type string not defined
3. string should be in double quote
4. count spell error
*/
using System;
using System.Linq;
namespace Q0101ns
{
    class String001
    {
        static void Main101(string[] args)
        {
            Console.WriteLine("Case1: , ");
            Console.WriteLine(RemoveCharToMakeAnagram("", ""));
            Console.WriteLine("Case 2: abc, ");
            Console.WriteLine(RemoveCharToMakeAnagram("abc", ""));
            Console.WriteLine("Case 3: aaa, a");
            Console.WriteLine(RemoveCharToMakeAnagram("aaa", "a"));
            Console.WriteLine("Case 4: hello, billion");
            Console.WriteLine(RemoveCharToMakeAnagram("hello", "billion"));
            Console.WriteLine("Case 5: glue, legs");
            Console.WriteLine(RemoveCharToMakeAnagram("glue", "legs"));
            Console.WriteLine("Case 6: candy, day");
            Console.WriteLine(RemoveCharToMakeAnagram("candy", "day"));

        }
        static int RemoveCharToMakeAnagram(string str1, string str2)
        {
            if(str1.Length == 0 && str2.Length == 0) return 0;
            if(str1.Length == 0) return str2.Length;
            if(str2.Length == 0) return str1.Length;
            string letters = "abcdefghijklmnopqrstuvwxyz";
            int count = 0;
            foreach(char c in letters)
                count += Math.Abs(str1.Count(s => s == c) - str2.Count(s => s == c));
            return count;
        }
    }
}