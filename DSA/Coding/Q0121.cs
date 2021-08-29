using System;
class Q0121
{
    static int MaxProfit(int[] prices)
    {
        int maxProfit = int.MinValue, minPrice = int.MaxValue;
        foreach(int p in prices)
        {
            if (p < minPrice) minPrice = p;
            maxProfit = Math.Max(maxProfit, p - minPrice);
        }
        return maxProfit;
    }
    static void Main121()
    {
        int m = MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 });
    }
}
