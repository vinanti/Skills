using System;
class Q0605
{
    static void Main12()
    {
        bool calPlace = CanPlaceFlowers(new int[] { 0, 0, 0 },2);
    }

    public static bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        if (flowerbed.Length == 1)
        {
            if (flowerbed[0] == 0 && n == 1) return true;
            else if (n == 0) return true;
            else return false;
        }
        for (int i = 0; i < flowerbed.Length; i++)
        {
            if (i == 0)
            {
                if(flowerbed[i] == 0 && flowerbed[i + 1] == 0) { n--; i++; }
            }
            else if (i == flowerbed.Length - 1)
            {
                if(flowerbed[i] == 0 && flowerbed[i - 1] == 0) n--;
            }
            else if (flowerbed[i] == 0 && flowerbed[i - 1] == 0 && flowerbed[i + 1] == 0)
            {
                n--; i++;
            }
            if (n == 0) return true;
        }
        return false;
    }
}
