/* search for number sequence
 https://codingbat.com/prob/p193604
Given an array of ints, return True if the sequence of numbers 1, 2, 3 appears in the array somewhere.


array123([1, 1, 2, 3, 1]) → True
array123([1, 1, 2, 4, 1]) → False
array123([1, 1, 2, 1, 2, 3]) → True 

Q:
emapty array? yes
max array

T:
array123([]) → False
array123([1,2]) → False
array123([1, 1, 2, 3, 1]) → True
array123([1, 1, 2, 4, 1]) → False
array123([1, 1, 2, 1, 2, 3]) → True 

A:
Brutforce
One foor loop
if find 1, check next 2 and nexttonext 3 True

E:
1, 1, 2, 3, 1
I1: 1, 1, 2
I2: 1, 2, 3 - true

C:
Approach 1,2: O(n)
Approach 3: O(1) 
*/
using System;
using System.Collections.Generic;
using System.Linq;
namespace Q005ns
{
    class Q005
    {
        static void Main005(string[] args)
        {
            Console.WriteLine(array123(new int[] { }));
            Console.WriteLine(array123(new int[] { 1, 2 }));
            Console.WriteLine(array123(new int[] { 1, 1, 2, 3, 1 }));
            Console.WriteLine(array123(new int[] { 1, 1, 2, 4, 1 }));
            Console.WriteLine(array123(new int[] { 1, 1, 2, 1, 2, 3 }));
        }
        public static bool array123(int[] arr)
        {
            //Approach 1:
            /*
            if (arr.Length < 3) return false;
            for(int i = 0; i < arr.Length-2; i++) 
                if(arr[i] == 1 && arr[i+1] == 2 && arr[i+2] == 3) return true;
            return false;
            */

            //Approach 2 - if stmt not required
            //for (int i = 0; i < arr.Length - 2; i++)
            //    if (arr[i] == 1 && arr[i + 1] == 2 && arr[i + 2] == 3) return true;
            //return false;

            //Approach 3: avoid loop 
            return arr.SkipWhile((a, i) => !(i < arr.Length-2 && arr[i] == 1 && arr[i+1] == 2 && arr[i+2] == 3)).ToList().Any();

        }
    }
}