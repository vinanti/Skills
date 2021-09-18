using System;
class Q1089
{
    static void Main1089()
    {
        DuplicateZeros(new int[] { 1, 0, 2, 3, 0, 4, 5, 0 });
    }
    //Brut Force solution
    static void DuplicateZeros(int[] arr)
    {
        int[] temp = new int[arr.Length];
        Array.Copy(arr, temp, arr.Length);
        int t = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if(temp[i-t] == 0)
            {
                arr[i] = 0;
                if(i+1 < arr.Length)
                    arr[i + 1] = 0;
                i++; t++;
            }
            else
            {
                arr[i] = temp[i - t];
            }
        }
    }

    //Other approch - reduced space complexcity
    //static void DuplicateZeros(int[] arr)
    //{
    //    for (int i = arr.Length - 1; i >= 0; i--)
    //        if (arr[i] == 0)
    //            for (int j = arr.Length - 1; j > i; j--)
    //                arr[j] = arr[j - 1];
    //}
}
