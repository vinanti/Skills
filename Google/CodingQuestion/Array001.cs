/*Built a comparitor to use to sort an array*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingQuestion
{
    class Array001
    {
        static void Main001(string[] args)
        {
            Player p1 = new Player("Gayle", 1903);
            Player p2 = new Player("John", 1791);
            Player p3 = new Player("Andy", 1400);
            Player p4 = new Player("Davis", 1400);
            Player p5 = new Player("Tobin", 1400);
            Player p6 = new Player("Chad", 1250);
            Player p7 = new Player("Vanessa", 700);
            Player p8 = new Player("Sarah", 400);
            Player p9 = new Player("Natalie", 350);
            Player p10 = new Player("Peter", 350);
            Player[] players = new Player[10] { p1, p2,p3,p4,p5,p6,p7,p8,p9,p10 };

            int a = compare(p1, p4);
            /*
            -ve if x < y --> x should apear firat
            0 if x==y
            1 if x > y --> x should appear second
             */

        }
        public static int compare(Player a, Player b)
        {
            if(a.Score == b.Score)
                return a.Name.CompareTo(b.Name);
            return b.Score - a.Score;
        }
    }
    class Player
    {
        public string Name;
        public int Score;

        public Player(string name, int score)
        {
            Name = name;
            Score = score;
        }
    }
}
