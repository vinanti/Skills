/*Plus One
 https://leetcode.com/explore/learn/card/array-and-string/201/introduction-to-array/1148/

 Given a non-empty array of decimal digits representing a non-negative integer, increment one to the integer.

The digits are stored such that the most significant digit is at the head of the list, and each element in the array contains a single digit.

You may assume the integer does not contain any leading zero, except the number 0 itself.

 

Example 1:

Input: digits = [1,2,3]
Output: [1,2,4]
Explanation: The array represents the integer 123.
Example 2:

Input: digits = [4,3,2,1]
Output: [4,3,2,2]
Explanation: The array represents the integer 4321.
Example 3:

Input: digits = [0]
Output: [1]
 

Constraints:

1 <= digits.length <= 100
0 <= digits[i] <= 9
 
 */

/*
Queries:
1. non empty & non -ve
2.0 to int limit? array length 1 to 100, 0 to 10^100 - Double - 10^300

Approch:
1. convert int[] into number 
2. icrement
3. conver number to int[] array 
        //long number = Convert.ToInt64(string.Join("", digits));
        //number++;
        //return number.ToString().Select(n => (int)Char.GetNumericValue(n)).ToArray();
*/
public class StringQ003
{
    static void Main003()
    {
        int[] num1 = new int[] { 1, 2, 3 };
        num1 = PlusOne(num1);  //1, 2, 4
        foreach (int item in num1)
            System.Console.WriteLine(item);

        int[] num2 = new int[] { 4,3,2,1 };
        num2 = PlusOne(num2);  //4, 3, 2, 2
        foreach (int item in num2)
            System.Console.WriteLine(item);

        int[] num3 = new int[] { 0 };
        num3 = PlusOne(num3);  //1
        foreach (int item in num3)
            System.Console.WriteLine(item);
    }
    public static int[] PlusOne(int[] digits)
    {
        bool tenthPlace = true;
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            if (tenthPlace)
            {
                if (digits[i] == 9)
                {
                    tenthPlace = true;
                    digits[i] = 0;
                }
                else
                {
                    tenthPlace = false;
                    digits[i] = digits[i] + 1;
                }
            }
        }
        if (tenthPlace)
        {
            int[] dig = new int[digits.Length + 1];
            dig[0] = 1;
            for (int i = 0; i < digits.Length; i++)
            {
                dig[i + 1] = digits[i];
                i++;
            }
            return dig;
        }
        return digits;
    }
}