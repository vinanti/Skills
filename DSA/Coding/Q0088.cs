using System;
class Q0088
{
    static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int l = m + n - 1; m--; n--;
        while(l >= 0)
        {
            if(m>=0 && n>= 0)
                if(nums1[m] > nums2[n]) 
                    nums1[l--] = nums1[m--];
                else nums1[l--] = nums2[n--];
            else if (m >= 0)
                nums1[l--] = nums1[m--];
            else if (n >= 0)
                nums1[l--] = nums2[n--];
        }
    }
    static void Main0088()
    {
        Merge(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3);
    }
}
