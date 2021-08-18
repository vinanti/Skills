/*Q112 Immutable String - Problems & Solutions
Immutable String
Convert To char array
Use String Builder
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q112ns
{
    class Q112
    {
        static void Main112()
        {
            //Immutable String
            string s = "";
            int n = 10;
            for (int i = 0; i < n; i++)
            {
                s += "hello";
            }
            Console.WriteLine(s);

            //Conver to Char Array
            string s_charArray = "Hello World";
            char[] str = s_charArray.ToCharArray();
            str[5] = ',';
            Console.WriteLine(str);

            //StringBuilder
            int num = 10;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < num; i++)
            {
                sb.Append("hello");
            }
            string s_sb = sb.ToString();
            Console.WriteLine(s_sb);

            
        }
    }
}
