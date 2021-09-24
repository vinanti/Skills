using System;

namespace Coding
{
    class ABinarySearch02_TemplateII
    {
        static void Main02()
        {
            BinarySearch(new int[] { 1, 2, 3, 4, 5, 6 }, 3);
        }
        static int BinarySearch(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
                return -1;

            int left = 0, right = nums.Length;
            while (left < right)
            {
                // Prevent (left + right) overflow
                int mid = left + (right - left) / 2;
                if (nums[mid] == target) { return mid; }
                else if (nums[mid] < target) { left = mid + 1; }
                else { right = mid; }
            }

            // Post-processing:
            // End Condition: left == right
            if (left != nums.Length && nums[left] == target) return left;
            return -1;
        }
    }
}
