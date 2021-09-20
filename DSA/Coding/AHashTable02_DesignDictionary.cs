//TODO: Design Hash Map

public class Solution
{
    public string ReverseWords(string s)
    {
        if (s.Length < 1) return s;
        string[] slist = s.Split();
        s = string.Empty;
        foreach (string l in slist)
        {
            for (int i = l.Length - 1; i >= 0; i--)
                s += l[i];
            s += " ";
        }
        return s.Trim();
    }
}

//using System.Linq;
//public class Solution
//{
//    public string ReverseWords(string s)
//    {
//        if (s.Length < 1) return s;
//        string[] slist = s.Split();
//        s = string.Empty;
//        foreach (string l in slist)
//            s += l.Reverse().ToString() + " ";
//        return s.Trim();
//    }
//}