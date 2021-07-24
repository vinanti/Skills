/*
 Is it Time for Milk and Cookies?
Christmas Eve is almost upon us, so naturally we need to prepare some milk and cookies for Santa! Create a function that accepts year, month and day as integers and returns true if it's Christmas Eve (December 24th) and false otherwise.

Examples
Date( 2013, 12, 24 ) ➞ true

Date( 2013, 0, 23 ) ➞ false

Date( 3000, 12, 24 ) ➞ true
 */
using System;

namespace CSharpChallanges
{
    class Program49
    {
        static void Main49(string[] args)
        {
            Console.WriteLine(TimeForMilkAndCookies(2013, 12, 24));
            Console.WriteLine(TimeForMilkAndCookies(2013, 0, 23));
            Console.WriteLine(TimeForMilkAndCookies(3000, 12, 24));
        }
        public static bool TimeForMilkAndCookies(int year, int month, int day) => (month == 12 && day == 24);

    }
}
