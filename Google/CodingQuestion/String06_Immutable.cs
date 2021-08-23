/*Immutable or Mutable
 https://leetcode.com/explore/learn/card/array-and-string/203/introduction-to-string/1184/
 */
using System;
using System.Text;

namespace CodingQuestion
{
    class String06_Immutable
    {
        static void Main06()
        {
            string s1 = "Hello World";
            //s1[5] = ',';  //Can't perform this because string object is Immutable in C#

            //*Solution1: convert it to a char array
            char[] c1 = s1.ToCharArray();
            c1[5] = ',';
            s1 = new string(c1);
            Console.WriteLine(s1);

            //*Solution2: use data struture like StringBuilder
            int n = 10000;
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                str.Append("hello");
            }
            string s = str.ToString();
            Console.WriteLine(s);

        }
    }
}
