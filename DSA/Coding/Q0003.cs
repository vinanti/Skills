using System;

namespace Coding
{
    class Q0003
    {
        static void Main3()
        {
            LengthOfLongestSubstring("au"); //3
        }

        public static int LengthOfLongestSubstring(string s)
        {
            int[] chars = new int[128];

            int left = 0;
            int right = 0;

            int res = 0;
            while (right < s.Length)
            {
                char r = s[right];
                chars[r]++;

                while (chars[r] > 1)
                {
                    char l = s[left];
                    chars[l]--;
                    left++;
                }

                res = Math.Max(res, right - left + 1);

                right++;
            }
            return res;
        }
        public static int LengthOfLongestSubstring02(string s)
        {
            int n = s.Length;

            int res = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    if (CheckRepetition(s, i, j))
                    {
                        res = Math.Max(res, j - i + 1);
                    }
                }
            }

            return res;
        }

        private static bool CheckRepetition(String s, int start, int end)
        {
            int[] chars = new int[128];

            for (int i = start; i <= end; i++)
            {
                char c = s[i];
                chars[c]++;
                if (chars[c] > 1)
                {
                    return false;
                }
            }

            return true;
        }

        /*Few scenarios broked*/
        public static int LengthOfLongestSubstring01(string s)
        {
            if (s.Length < 2) return s.Length;
            if (s.Length == 2)
                if (s[0] != s[1]) return 2;
                else return 1;

            int[] chars = new int[128];

            int left = 0;
            int right = 0;

            int res = 0;
            while (right < s.Length)
            {
                char r = s[right];

                int index = chars[r];
                if (index >= left && index < right)
                {
                    left = index + 1;
                }

                res = Math.Max(res, (right == 1) ? right + 1 : right - left + 1);

                chars[r] = right;
                right++;
            }

            return res;
        }
    }
}
