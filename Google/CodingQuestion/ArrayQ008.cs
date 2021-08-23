/*Check If N and Its Double Exist
 https://leetcode.com/explore/featured/card/fun-with-arrays/527/searching-for-items-in-an-array/3250/
 */
using System;

namespace CodingQuestion
{
    class ArrayQ008
    {
        static void Main008()
        {
            int[] arr1 = new int[] { -10, 12, -20, -8, 15};
            Console.WriteLine(CheckIfExist(arr1));
        }
        public static bool CheckIfExist(int[] arr)
        {
            if (arr.Length < 2) return false;
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] * 2 == arr[j]) return true;
                        if (arr[i] * 2 < arr[j]) break;
                    }
                }
                else
                {
                    for (int j = i - 1; j >= 0; j--)
                    {
                        if (Math.Abs(arr[i]) * 2 == Math.Abs(arr[j])) return true;
                        if (Math.Abs(arr[i]) * 2 < Math.Abs(arr[j])) break;
                    }
                }
            }
            return false;
        }
    }
}
