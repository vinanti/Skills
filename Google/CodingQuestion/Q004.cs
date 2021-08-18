/* Blackjack
 * https://codingbat.com/prob/p117019
 Given 2 int values greater than 0, return whichever value is nearest to 21 without going over. Return 0 if they both go over.


blackjack(19, 21) → 21
blackjack(21, 19) → 21
blackjack(19, 22) → 19
 
Q:
MaxInt

T:
blackjack(22, 25) → 0
blackjack(23, 20) → 20
blackjack(19, 22) → 19
blackjack(19, 21) → 21
blackjack(21, 19) → 21


A:
if both > 21 -> return 0
If any > 21 -> return other
whichever is greter return

E:

T: O(1)

Errors:
1. main M capital
str[] -> string[]
*/
using System;
namespace Q004ns
{
    class Q004
    {
        static void Main004()
        {
            Console.WriteLine(blackjack(22, 25));
            Console.WriteLine(blackjack(23, 20));
            Console.WriteLine(blackjack(19, 22));
            Console.WriteLine(blackjack(19, 21));
            Console.WriteLine(blackjack(21, 19));
        }
        public static int blackjack(int num1, int num2)
        {
            //Approach 1
            //if( num1 > 21 && num2 > 21) return 0;
            //if( num1 > 21) return num2; else if(num2 > 21) return num1;
            //if(num1 > num2) return num1; else return num2;

            //Approach 2:
            return (num1 > 21 && num2 > 21)? 0 : (num1 > 21)? num2: (num2 > 21)? num1: (num1 > num2)? num1: num2;

        }
    }
}


