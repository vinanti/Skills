using System;

namespace Coding
{
    class ABinarySearch01_TemplateI
    {
        static void Main01()
        {
            BinarySearch(new int[] { 1, 2, 3, 4, 5, 6 }, 4);
        }
        static int BinarySearch(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
                return -1;

            int left = 0, right = nums.Length - 1;
            while (left <= right)
            {
                // Prevent (left + right) overflow
                int mid = left + (right - left) / 2;
                if (nums[mid] == target) { return mid; }
                else if (nums[mid] < target) { left = mid + 1; }
                else { right = mid - 1; }
            }

            // End Condition: left > right
            return -1;
        }
    }
}
