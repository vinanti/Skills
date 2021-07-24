//The Farm Problem
/*In this challenge, a farmer is asking you to tell him how many legs can be counted among all his animals. The farmer breeds three species:

chickens = 2 legs
cows = 4 legs
pigs = 4 legs
The farmer has counted his animals and he gives you a subtotal for each species. You have to implement a function that returns the total number of legs of all the animals.

Examples
animals(2, 3, 5) ➞ 36

animals(1, 2, 3) ➞ 22

animals(5, 2, 8) ➞ 50*/
using System;

namespace CSharpChallanges
{
    class Program19
    {
        static void Main19(string[] args)
        {
            Console.WriteLine(animals(2,3,5));
            Console.WriteLine(animals(1,2,3));
            Console.WriteLine(animals(5,2,8));
        }
        public static int animals(int chickens, int cows, int pigs) => (chickens*2 + cows*4 + pigs*4);

    }
}
