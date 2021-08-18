/*Find centered average
 https://codingbat.com/prob/p126968
 
Return the "centered" average of an array of ints, which we'll say is the mean average of the values, except ignoring the largest and smallest values in the array. If there are multiple copies of the smallest value, ignore just one copy, and likewise for the largest value. Use int division to produce the final average. You may assume that the array is length 3 or more.


centered_average([1, 2, 3, 4, 100]) → 3
centered_average([1, 1, 5, 5, 10, 8, 7]) → 5
centered_average([-10, -4, -2, -4, -2, 0]) → -3
 
 */
using System;
class Q013
{
    static void Main013()
    {
        Console.WriteLine(centered_average(new int[] { 1, 2, 3, 4, 100 })); //3
        Console.WriteLine(centered_average(new int[] { 1, 1, 5, 5, 10, 8, 7 })); //5
        Console.WriteLine(centered_average(new int[] { -10, -4, -2, -4, -2, 0 })); //-3
    }
    static int centered_average(int[] nums)
    {
        if(nums.Length % 2 == 0)
        {
            return (nums[nums.Length / 2] + nums[nums.Length / 2 + 1]) / 2;
        }
        return nums[nums.Length / 2];
    }
}