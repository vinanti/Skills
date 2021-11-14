using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
    class Q0698
    {
        static void Main01()
        {
            CanPartitionKSubsets(new int[] { 3522, 181, 521, 515, 304, 123, 2512, 312, 922, 407, 146, 1932, 4037, 2646, 3871, 269 }, 5);
        }
        public static bool CanPartitionKSubsets(int[] nums, int k)
        {
            int totalSum = 0;
            foreach (int n in nums) totalSum += n;
            if (totalSum % k > 0) return false;
            int eachSetSum = totalSum / k;
            Array.Sort(nums);
            if (nums[nums.Length - 1] > eachSetSum) return false;
            List<int> list = new List<int>();
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                bool added = false;
                for (int j = 0; j < list.Count; j++)
                    if (list[j] + nums[i] <= eachSetSum)
                    {
                        list[j] += nums[i];
                        added = true;
                        break;
                    }
                if (!added) list.Add(nums[i]);
            }
            return list.Count == k;
        }
    }
}
