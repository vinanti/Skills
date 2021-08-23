using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingQuestion
{
    class BinarySearch02_TemplateII
    {
        static void Main01()
        {
            int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(binarySearch(nums, 6));
        }
        static int binarySearch(int[] nums, int target)
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
