using System;

namespace Coding_Q0912
{
    public class Q0912
    {
        static void Main912()
        {
            SortArray(new int[] { 5, 2, 3, 1 });
        }
        public static int[] SortArray(int[] nums)
        {
            if (nums.Length <= 1) return nums;
            int split = nums.Length / 2;

            int[] leftNums = new int[split];
            Array.Copy(nums, 0, leftNums, 0, split);
            leftNums = SortArray(leftNums);

            int[] rightNums = new int[nums.Length - split];
            Array.Copy(nums, split, rightNums, 0, nums.Length - split);
            rightNums = SortArray(rightNums);

            return Merge(leftNums, rightNums);
        }
        public static int[] Merge(int[] leftNums, int[] rightNums)
        {
            int[] result = new int[leftNums.Length + rightNums.Length];
            int i = 0, j = 0, k = 0;
            while (i < leftNums.Length || j < rightNums.Length)
            {
                if (i < leftNums.Length && j < rightNums.Length)
                {
                    if (leftNums[i] <= rightNums[j])
                    {
                        result[k] = leftNums[i];
                        i++; k++;
                    }
                    else
                    {
                        result[k] = rightNums[j];
                        j++; k++;
                    }
                }
                else if (i < leftNums.Length)
                {
                    result[k] = leftNums[i];
                    i++; k++;
                }
                else if (j < rightNums.Length)
                {
                    result[k] = rightNums[j];
                    j++; k++;
                }
            }
            return result;
        }
    }
}
