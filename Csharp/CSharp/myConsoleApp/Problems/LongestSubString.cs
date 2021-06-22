using System;
namespace myConsoleApp
{
    class Program100
    {
        static int LengthOfLongestSubstring(string s) 
        {
            if (s.Length == 0)
            return 0;
            if (checkAllCharUnique(s))
            return s.Length;
            int x = 0;
            int l = s.Length;
            string longss = s.Substring(0,1);
            foreach(char c in s)
            {
                string longss2 = getUniqueMaxSubString(c, s.Substring(x));
                x++;
                if (longss.Length < longss2.Length)
                    longss = longss2;
            }
            return longss.Length;
        }  
        static string getUniqueMaxSubString(char c, string s)
        {
           int max = 0;
    string ss = c.ToString();
    string ss2 = ss;
    for (int i=0; i<s.Length; i++)
    {
        int at1 = s.IndexOf(c);
        int at2 = -1;
        if(at1 != -1)
            at2 = s.IndexOf(c,at1+1);
        if(at2 == -1)
            ss2 = s.Substring(at1);
        else
            ss2 = s.Substring(at1, at2-at1);
        if(checkAllCharUnique(ss))
        {   
             if(max < at2-at1)
             {
                  max = at2 - at1;
                  ss = ss2;
                  i--;
             }
        }       
    }
    return ss;
        }
        static bool checkAllCharUnique(string s)
        {
            foreach(char c in s)
            {
                int i = s.IndexOf(c,0);
                if (s.IndexOf(c,i+1) > 0)
                    return false;
            }
            return true;
        }
        static void Main100(string[] args)
        {
            //System.Console.WriteLine("Enter String");
            string s = "au";
            int l = LengthOfLongestSubstring(s);
            System.Console.WriteLine(l);
        }
    }
}
