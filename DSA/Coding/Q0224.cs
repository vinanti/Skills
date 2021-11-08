using System;
using System.Collections.Generic;

namespace Coding
{
    class Q0224
    {
        static void Main12()
        {
            Calculate("(1+(4+5+2)-3)+(6+8)");
        }
        public static int Calculate(string s)
        {
            Stack<int> stack = new Stack<int>();
            int operand = 0;
            int result = 0;
            int sign = 1;
            for (int i = 0; i < s.Length; i++)
            {
                char ch = s[i];
                if (char.IsDigit(ch))
                {
                    operand = 10 * operand + (int)(ch - '0');
                }
                else if (ch == '+')
                {
                    result += sign * operand;
                    sign = 1;
                    operand = 0;
                }
                else if (ch == '-')
                {
                    result += sign * operand;
                    sign = -1;
                    operand = 0;
                }
                else if (ch == '(')
                {
                    stack.Push(result);
                    stack.Push(sign);
                    sign = 1;
                    result = 0;
                }
                else if (ch == ')')
                {
                    result += sign * operand;
                    result *= stack.Pop();
                    result += stack.Pop();
                    operand = 0;
                }
            }
            return result + (sign * operand);
        }
    }
}
