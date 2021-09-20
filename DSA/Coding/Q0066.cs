using System;

namespace Coding
{
    class Q0066
    {
        static void Main66()
        {
            PlusOne(new int[] { 1, 2, 3 }); //1,2,4
        }
        public static int[] PlusOne(int[] digits)
        {
            bool tenthPlace = true;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (tenthPlace)
                {
                    if (digits[i] == 9)
                    {
                        tenthPlace = true;
                        digits[i] = 0;
                    }
                    else
                    {
                        tenthPlace = false;
                        digits[i] = digits[i] + 1;
                    }
                }
            }
            if (tenthPlace)
            {
                int[] dig = new int[digits.Length + 1];
                dig[0] = 1;
                for (int i = 0; i < digits.Length; i++)
                {
                    dig[i + 1] = digits[i];
                    i++;
                }
                return dig;
            }
            return digits;
        }
    }
}
