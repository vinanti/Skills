using System;
class Q1295
{
    static int NumbersWithEvenNumberOfDigits(int[] nums)
    {
        int count = 0;
        foreach (int n in nums)
            if (n.ToString().Length % 2 == 0) count++;
        return count;
    }
    static void Main1295()
    {
        int m = NumbersWithEvenNumberOfDigits(new int[] { 12, 345, 2, 6, 7896 }); //3
    }
}
