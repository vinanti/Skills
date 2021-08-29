using System;
class Q1089
{
    static void DuplicateZeros(int[] arr)
    {
        for (int i = arr.Length - 1; i >= 0; i--)
            if(arr[i] == 0)
                for (int j = arr.Length-1; j > i; j--)
                    arr[j] = arr[j - 1];
    }
    static void Main1089()
    {
        DuplicateZeros(new int[] { 1, 0, 2, 3, 0, 4, 5, 0 });
    }
}
