﻿using System;

namespace Coding_AString09
{
    class AString09_TwoPointerRemove
    {
        static void Main09()
        {
            RemoveElement(new int[] { 1, 2, 3, 4, 5, 6 }, 3);
        }
        public static int RemoveElement(int[] nums, int val)
        {
            int k = 0;
            for (int i = 0; i < nums.Length; ++i)
            {
                if (nums[i] != val)
                {
                    nums[k] = nums[i];
                    k++;
                }
            }
            return k;
        }
    }
}
