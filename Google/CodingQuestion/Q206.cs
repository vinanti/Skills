/*Lonley Integer' Using Bit Manipulation
 * https://www.youtube.com/watch?v=eXWjCgbL01U&list=PLI1t_8YX-ApvMthLj56t1Rf-Buio5Y8KL&index=16
 * https://www.hackerrank.com/challenges/ctci-lonely-integer/problem
 Consider an array of integers where all but one of the integers occur in pairs. In other words, every element occurs exactly twice except for one unique element. Find the unique element.

For example, given the array , you would return .

Function Description

Complete the findLonely function in the editor below. It should return the unique integer in .

findLonely has the following parameter(s):

arr: an array of integers
Input Format

The first line contains a single integer, , denoting the number of integers in .
The second line contains  space-separated integers, each an element, .

Constraints

It is guaranteed that  is an odd number.
, where .
Output Format

Print the unique number in  on a new line.

Sample Input 0

1
1
Sample Output 0

1
Explanation 0
The array only contains a single , so we print  as our answer.

Sample Input 1

3
1 1 2
Sample Output 1

2
Explanation 1
We have two 's and one . We print , because that's the only unique element in the array.

Sample Input 2

5
0 0 1 2 1
Sample Output 2

2
Explanation 2
We have two 's, two 's, and one . We print , because that's the only unique element in the array.
 
 */
using System;
using System.Collections.Generic;
class Q206
{
    static void Main()
    {
        Console.WriteLine(findLonely(new List<int> { 1})); //1
        Console.WriteLine(findLonely(new List<int> { 1, 1, 2 })); //2
        Console.WriteLine(findLonely(new List<int> { 0,0,1,2,1 })); //2
    }
    // Complete the findLonely function below.
    static int findLonely(List<int> arr)
    {
        int result = 0;
        foreach (int value in arr)
        {
            result ^= value;
        }
        return result;
    }
}