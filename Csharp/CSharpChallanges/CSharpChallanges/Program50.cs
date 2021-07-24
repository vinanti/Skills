/*
 Days in a Month
Create a function that takes the month and year (as integers) and returns the number of days in that month.

Examples
Days(2, 2018) ➞ 28

Days(4, 654) ➞ 30

Days(2, 200) ➞ 29

Days(2, 1000) ➞ 29
 */
using System;

namespace CSharpChallanges
{
    class Program50
    {
        static void Main50(string[] args)
        {
            Console.WriteLine(Days(2,2018));
            Console.WriteLine(Days(4,654));
            Console.WriteLine(Days(2,200));
            Console.WriteLine(Days(2,1000));
        }
        public static int Days(int month, int year) => DateTime.DaysInMonth(year, month);
    }
}
