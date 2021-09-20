using System;
using System.Text;

namespace Coding
{
    class Q0402
    {
        static void Main402()
        {
            RemoveKdigits("1432219",3);
        }
        public static string RemoveKdigits(string num, int k)
        {
            if (k >= num.Length) return "0";
            char[] numChar = num.ToCharArray();
            int small = int.MaxValue;
            for (int i = 0; i < numChar.Length; i++)
            {
                int s1 = i, s2 = i + k - 1;
                StringBuilder currentNum = new StringBuilder();
                for (int j = 0; j < numChar.Length; j++)
                {
                    if (j < s1 || j > s2) currentNum.Append(numChar[j]);
                }
                if (small > int.Parse(currentNum.ToString())) small = int.Parse(currentNum.ToString());
            }
            return small.ToString();
        }
    }
}
