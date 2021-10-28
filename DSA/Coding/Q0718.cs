using System;
using System.Collections.Generic;

namespace Coding
{
    class Q0718
    {
        static void Main718()
        {
            FindLength(new int[] { 0, 1, 1, 1, 1 }, new int[] { 1, 0, 1, 0, 1 });
        }
        public static int FindLength(int[] nums1, int[] nums2)
        {
            int maxLength = 0;
            for (int i = 0; i < nums1.Length; i++)
                for (int j = 0; j < nums2.Length; j++)
                {
                    if (nums1[i] == nums2[j])
                    {
                        bool isEqual = true;
                        int length = 0;
                        while (isEqual)
                        {
                            if (i + length < nums1.Length && j + length < nums2.Length && nums1[i + length] == nums2[j + length]) length++;
                            else
                            {
                                isEqual = false;
                                maxLength = Math.Max(maxLength, length);
                            }
                        }
                    }
                }
            return maxLength;
        }
    }
}
