using System;
namespace myConsoleApp
{
    class Programp1
    {
        static void Mainp1(string[] args)
        {
            string s = "aaaaaa";
            string t = "bbaaaa";
            int si1 = 0;
            int si2 = 0;
            foreach(char c in s)
            {
                si2 = t.IndexOf(c, si1);
                if(si2 == -1)
                    System.Console.WriteLine(false);
                if(si2 > si1)
                    si1 = si2+1;
            }
            System.Console.WriteLine(true);
        }
    }
}
