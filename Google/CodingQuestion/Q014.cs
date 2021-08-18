/*Fins intesection
 https://www.coderbyte.com/editor/Find%20Intersection:Python3
 
 Find Intersection
Have the function FindIntersection(strArr) read the array of strings stored in strArr which will contain 2 elements: the first element will represent a list of comma-separated numbers sorted in ascending order, the second element will represent a second list of comma-separated numbers (also sorted). Your goal is to return a comma-separated string containing the numbers that occur in elements of strArr in sorted order. If there is no intersection, return the string false.
Examples
Input: ["1, 3, 4, 7, 13", "1, 2, 4, 13, 15"]
Output: 1,4,13
Input: ["1, 3, 9, 10, 17, 18", "1, 4, 9, 10"]
Output: 1,9,10
 
 */
using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
namespace Q014ns
{
    class Q014
    {
        static void Main014()
        {
            Console.WriteLine("Case 1");
            string[] strArr1 = new string[] { "1, 3, 4, 7, 13", "1, 2, 4, 13, 15" };
            Console.WriteLine(FindIntersection(strArr1)); //1,4,13

            Console.WriteLine("Case 2");
            string[] strArr2 = { "1, 3, 9, 10, 17, 18", "1, 4, 9, 10" };
            Console.WriteLine(FindIntersection(strArr2)); //1,9,10

        }
        static string FindIntersection(string[] strArr)
        {
            List<int> num1 = strArr[0].Split(',').Select(x => Convert.ToInt32(x)).ToList();
            List<int> num2 = strArr[1].Split(',').Select(x => Convert.ToInt32(x)).ToList();
            return string.Join(",", num1.Intersect(num2).Select(x => x.ToString()).ToArray());
        }
    }
}
