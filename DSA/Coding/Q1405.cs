using System;
using System.Text;

namespace Coding
{
    class Q1405
    {
        static void Main405()
        {
            string result = LongestDiverseString(0, 8, 11);
        }
        public static string LongestDiverseString(int a, int b, int c)
        {
            StringBuilder sb = new StringBuilder();
            int num1 = 0, num2 = 0, num3 = 0;
            char char1 = ' ', char2 = ' ', char3 = ' ';

            if (a >= b && a >= c && b >= c)
            {
                num1 = a; char1 = 'a';
                num2 = b; char2 = 'b';
                num3 = c; char3 = 'c';
            }
            else if (a >= b && a >= c && b <= c)
            {
                num1 = a; char1 = 'a';
                num2 = c; char2 = 'c';
                num3 = b; char3 = 'b';
            }
            else if (b >= a && b >= c && a >= c)
            {
                num1 = b; char1 = 'b';
                num2 = a; char2 = 'a';
                num3 = c; char3 = 'c';
            }
            else if (b >= a && b >= c && a <= c)
            {
                num1 = b; char1 = 'b';
                num2 = c; char2 = 'c';
                num3 = a; char3 = 'a';
            }
            else if (c >= a && c >= b && a >= b)
            {
                num1 = c; char1 = 'c';
                num2 = a; char2 = 'a';
                num3 = b; char3 = 'b';
            }
            else if (c >= a && c >= b && a <= b)
            {
                num1 = c; char1 = 'c';
                num2 = b; char2 = 'b';
                num3 = a; char3 = 'a';
            }
            int num = 1;
            while (num1 > 0 || num2 > 0 || num3 > 0)
            {
                if (num == 1 && num1 > 1) { sb.Append(char1, 2); num1 -= 2; }
                else if (num == 1 && num1 == 1) { sb.Append(char1); num1--; }
                else if (num == 2 && num2 > 1) { sb.Append(char2, 2); num2 -= 2; }
                else if (num == 2 && num2 == 1) { sb.Append(char2); num2--; }
                else if (num == 3 && num3 > 1) { sb.Append(char3, 2); num3 -= 2; }
                else if (num == 3 && num3 == 1) { sb.Append(char3); num3--; }

                if (num == 1 && num2 == 0 && num3 == 0) { num1 = 0; num = 0; }
                if (num == 2 && num1 == 0 && num3 == 0) { num2 = 0; num = 0; }
                if (num == 3 && num1 == 0 && num2 == 0) { num3 = 0; num = 0; }

                if (num == 1 && num2 >= num3) num = 2;
                else if (num == 1 && num2 <= num3) num = 3;
                else if (num == 2 && num1 >= num3) num = 1;
                else if (num == 2 && num1 <= num3) num = 3;
                else if (num == 3 && num1 >= num2) num = 1;
                else if (num == 3 && num1 <= num2) num = 2;

            }
            return sb.ToString();
        }
    }
}
