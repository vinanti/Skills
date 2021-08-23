/*String - Compare strings
 https://leetcode.com/explore/learn/card/array-and-string/203/introduction-to-string/1158/
 */
using System;
namespace Q110ns
{
    class String04_Comapre
    {
        static void Main04()
        {
            // initialize
            string s1 = "Hello World";
            Console.WriteLine("s1 is \"" + s1 + "\"");
            string s2 = s1;
            Console.WriteLine("s2 is another reference to s1.");
            string s3 = new string(s1);
            Console.WriteLine("s3 is a copy of s1.");
            // compare using '=='
            Console.WriteLine("Compared by '==':");
            // true since string is immutable and s1 is binded to "Hello World"
            Console.WriteLine("s1 and \"Hello World\": " + (s1 == "Hello World"));
            // true since s1 and s2 is the reference of the same object
            Console.WriteLine("s1 and s2: " + (s1 == s2));
            // true even s3 is refered to another new object C# supports operator overloading
            Console.WriteLine("s1 and s3: " + (s1 == s3));
            // compare using 'equals'
            Console.WriteLine("Compared by 'equals':");
            Console.WriteLine("s1 and \"Hello World\": " + s1.Equals("Hello World"));
            Console.WriteLine("s1 and s2: " + s1.Equals(s2));
            Console.WriteLine("s1 and s3: " + s1.Equals(s3));
            // compare using 'compareTo'
            Console.WriteLine("Compared by 'compareTo':");
            Console.WriteLine("s1 and \"Hello World\": " + (s1.CompareTo("Hello World") == 0));
            Console.WriteLine("s1 and s2: " + (s1.CompareTo(s2) == 0));
            Console.WriteLine("s1 and s3: " + (s1.CompareTo(s3) == 0));
        }
    }
}