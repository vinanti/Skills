using System;

namespace Coding
{
    class ABinarySearch03_TemplateIII
    {
        static void Main03()
        {
            BinarySearch(new int[] { 1, 2, 3, 4, 5, 6 }, 4);
        }
        static int BinarySearch(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
                return -1;

            int left = 0, right = nums.Length - 1;
            while (left + 1 < right)
            {
                // Prevent (left + right) overflow
                int mid = left + (right - left) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] < target)
                {
                    left = mid;
                }
                else
                {
                    right = mid;
                }
            }

            // Post-processing:
            // End Condition: left + 1 == right
            if (nums[left] == target) return left;
            if (nums[right] == target) return right;
            return -1;
        }
    }
}
