/* Product & sum of digits
 https://leetcode.com/problems/subtract-the-product-and-sum-of-digits-of-an-integer/
1281. Subtract the Product and Sum of Digits of an Integer

Given an integer number n, return the difference between the product of its digits and the sum of its digits.

Example 1:
Input: n = 234
Output: 15 
Explanation: 
Product of digits = 2 * 3 * 4 = 24 
Sum of digits = 2 + 3 + 4 = 9 
Result = 24 - 9 = 15

Example 2:
Input: n = 4421
Output: 21
Explanation: 
Product of digits = 4 * 4 * 2 * 1 = 32 
Sum of digits = 4 + 4 + 2 + 1 = 11 
Result = 32 - 11 = 21
 
Constraints:
1 <= n <= 10^5

Q.
11 1 2 -> 1
max n -> 10^5 == 100000 
9*9*9*9*9  exceeds int max limit? not exceeds
num >= 1

T.
5    -> 0
13   -> 1
234  -> 15
4421 -> 21

A.
1. siggle digit no -> 0
2. get a digit dig = num % 10, num = num/10 -> untill num not zero
3. sum+dig, prod*dig
4. Abs |sum - prod|

E.
    private static int SubtractProductAndSum(int n) // 234
        {
            if(n/10 == 0) return 0;
            int sum = 0, product = 1;
            do{
                int digit = n % 10; //4, 3, 2
                sum += digit; //0 + 4 + 3 + 2 = 9
                product *= digit; // 1 * 4 * 3 * 2 = 24
                n /= 10; //23, 2,  0
            }while(n!=0); 
            return Math.Abs(product - sum); //24 - 9 = 15
        }

Error
1. variable declaration in single line should be coma seperated
2. Absolute method is Math.Abs not Math.Absolute
3. static method
4. variable product should be 1 else it will keep multiply with 0
 */
using System;

namespace Q007ns
{
    class Q007
    {
        static void Main007(string[] args)
        {
            Console.WriteLine(SubtractProductAndSum(5));
            Console.WriteLine(SubtractProductAndSum(13));
            Console.WriteLine(SubtractProductAndSum(234));
            Console.WriteLine(SubtractProductAndSum(4421));
        }

        private static int SubtractProductAndSum(int n) 
        {
            if(n/10 == 0) return 0;
            int sum = 0, product = 1;
            do{
                int digit = n % 10; 
                sum += digit; 
                product *= digit; 
                n /= 10; 
            }while(n!=0); 
            return Math.Abs(product - sum); 
        }
    }
}

