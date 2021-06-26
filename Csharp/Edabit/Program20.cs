//Football Points
using System;

namespace Edabit
{
    class Program20
    {
        static void Main20(string[] args)
        {
            Console.WriteLine(FootballPoints(3,4,2));
            Console.WriteLine(FootballPoints(5,0,2));
            Console.WriteLine(FootballPoints(0,0,1));
        }
        public static int FootballPoints(int wins, int draws, int losses) => wins*3 + draws*1 + losses*0;

    }
}
