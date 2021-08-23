﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingQuestion
{
    class String08_SpaceLimitation
    {
        static void Main08()
        {
            int[] nums = new int[] { 3, 2, 2, 3 };
            Console.WriteLine(RemoveElement(nums, 3));
        }
        public static int RemoveElement(int[] nums, int val)
        {
            int i = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] != val)
                {
                    nums[i] = nums[j];
                    i++;
                }
            }
            return i;
        }
    }
}
