using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
    class Q0008
    {
        static void Main08()
        {
            MyAtoi("-91283472332");
        }
        public static int MyAtoi(string s)
        {
            if (s.Trim().Length == 0) return 0;
            char[] charS = s.Trim().ToCharArray();
            int isNegative = charS[0] == '-' ? -1 : 1;
            long number = 0;
            int start = charS[0] == '+' || charS[0] == '-' ? 1 : 0;
            for (int i = start; i < charS.Length; i++)
            {
                int num = charS[i] - '0';
                if (num >= 0 && num <= 9) number = (number * 10) + num;
                else break;
                if (isNegative * number < int.MinValue) number = int.MinValue;
                if (isNegative * number > int.MaxValue) number = int.MaxValue;
            }
            return isNegative * (int)number;
        }
    }
}
