using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
    class _0152
    {
        static void Main1()
        {
            MaxProduct(new int[] { 0, 2 });
        }
        public static int MaxProduct(int[] nums)
        {
            int maxProduct = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                int currentProduct = 1;
                for (int j = 0; j < nums.Length - i; j++)
                {
                    currentProduct *= nums[j];
                }
                maxProduct = Math.Max(maxProduct, currentProduct);
                currentProduct = 1;
                for (int j = i; j < nums.Length ; j++)
                {
                    currentProduct *= nums[j];
                }
                maxProduct = Math.Max(maxProduct, currentProduct);
            }
            return maxProduct;
        }
    }
}
