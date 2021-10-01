using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
    class Q0229
    {
        static void Main29()
        {
            MajorityElement(new int[] { 3, 2, 3 });
        }
        public static IList<int> MajorityElement(int[] nums)
        {
            if (nums.Length == 1) return new List<int> { nums[0] };
            int n = nums.Length / 3;
            List<int> result = new List<int>();
            Array.Sort(nums);
            int current = nums[0], count = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (current == nums[i]) count++;
                else
                {
                    if (count > n) result.Add(current);
                    current = nums[i];
                    count = 1;
                }
            }
            if (count > n) result.Add(current);
            return result;
        }
    }
}
