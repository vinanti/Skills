using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
    class Q0027
    {
        static void Main0027()
        {
            int i = RemoveElement(new int[] { 3, 2, 2, 3 }, 3);
        }
        static int RemoveElement(int[] nums, int val)
        {
            int j = 0;
            for (int i = 0; i < nums.Length-1; i++)
            {
                if (nums[i] != val) {
                    nums[j] = nums[i];
                    j++;
                } 
            }
            return j;
        }
    }
}
