/* Compute factorial
 * https://www.coderbyte.com/editor/First%20Factorial:Python3
 First Factorial
Have the function FirstFactorial(num) take the num parameter being passed and return the factorial of it. 
For example: if num = 4, then your program should return (4 * 3 * 2 * 1) = 24. 
For the test cases, the range will be between 1 and 18 and the input will always be an integer.
Examples
Input: 4
Output: 24
Input: 8
Output: 40320
Q:
1-18
int

T:
1! -> 1
2! -> 2
3! -> 3 * 2 * 1
n! -> n * (n-1)!

A:
Recursion for input > 1

C:
O(1)

Errors:
1. missed static to function
2. public not required, insted use private
3. Double is required beuse 18! exceed int max limit
*/
using System;
namespace Q006ns
{
    class Q006
    {
        static void Main006(string[] argus)
        {
            Console.WriteLine(FirstFactorial(1)); //1
            Console.WriteLine(FirstFactorial(2)); //2
            Console.WriteLine(FirstFactorial(3)); //6
            Console.WriteLine(FirstFactorial(4)); //24
            Console.WriteLine(FirstFactorial(8)); //40320
            Console.WriteLine(FirstFactorial(18)); //
        }
        private static double FirstFactorial(int num)
        {
            //Approach 1:
            /*
            if (num == 1) return 1;
            return (double)(num * FirstFactorial(num-1));
            */

            //Approach 2:
            return (num == 1)? 1 : (double)(num * FirstFactorial(--num));
        }
    }
}

