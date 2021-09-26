using System;

namespace Coding_Q0744
{
    class Q0744
    {
        static void Main744()
        {
            NextGreatestLetter(new char[] { 'a', 'b', 'c' }, 'z');
        }
        public static char NextGreatestLetter(char[] letters, char target)
        {
            for (int i = 0; i < letters.Length; i++)
            {
                if ((int)letters[i] > (int)target) return letters[i];
            }
            return letters[0];
        }
    }
}
