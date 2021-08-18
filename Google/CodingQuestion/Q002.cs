/* Make bricks
 * https://codingbat.com/prob/p183562
 
We want to make a row of bricks that is goal inches long. 
We have a number of small bricks (1 inch each) and big bricks (5 inches each). 
Return true if it is possible to make the goal by choosing from the given bricks. 
This is a little harder than it looks and can be done without any loops. 
See also: Introduction to MakeBricks

https://www.youtube.com/watch?v=86PSF-n43-g&t=14s
https://www.youtube.com/watch?v=pEw1sB13fjM

makeBricks(3, 1, 8) → true
makeBricks(3, 1, 9) → false
makeBricks(3, 2, 10) → true
Q:
1st var - small brik
2nd var - big briks
3rd var - Goal

T:
makeBricks(2, 1, 0) -> true
makeBricks(3, 1, 8) → true
makeBricks(3, 1, 9) → false
makeBricks(3, 2, 10) → true

A:
Goal % b = r % s = 0 yes

E:
//s = 3, b = 1 * 5 = 8, goal = 8 % 5 = 3 % 3 = 0 true
//(3, 1, 9) => s=3, b=5, Goal = 9 % 5 = 4 % 3 = 1 false

C:
O(1)
 */
using System;

namespace Q002
{
    class makeBricksns
    {
        static void Main002()
        {
            Console.WriteLine(makeBricks(2, 1, 0)); //True
            Console.WriteLine(makeBricks(3, 1, 8)); //True
            Console.WriteLine(makeBricks(3, 1, 9)); //False
            Console.WriteLine(makeBricks(3, 2, 10));//True
            Console.WriteLine(makeBricks(3, 1, 7)); //True
        }
        public static bool makeBricks(int small, int big, int goal)
        {
            return !(goal > big * 5 + small && goal % 5 > small);

            //Video solution
            //if (goal > big * 5 + small) return false;
            //if (goal % 5 > small) return false;
            //return true;

            //My solution
            //int bigRequired = goal/5 > big ? big : goal/5;
            //return bigRequired>0?(goal % (bigRequired*5) <= small): (goal <= small);
        }

    }
}
