using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
    class Q0026
    {
        static void Main26()
        {
            int n = RemoveDuplicates(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 });
        }
        static int RemoveDuplicates(int[] nums)
        {
            int j = 0;
            for (int i = 0; i < nums.Length-1; i++)
            {
                if(nums[i]==nums[i+1]) j++;
                if(i+j<nums.Length) nums[i] = nums[i+j];
            }
            return nums.Length-j;
        }
    }
}
