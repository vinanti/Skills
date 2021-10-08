using System;
using System.Collections.Generic;
namespace Solution
{
    public class Solution
    {
        public static void Main01(string[] args)
        {
            // you can write to stdout for debugging purposes, e.g.
            Console.WriteLine("This is a debug message");
        }
    }
    public class phone
    {
        public Dictionary<int, string[]> master = new Dictionary<int, string[]>(){
                {2,new string[] {"a","b","c"} }
            };
        public List<string> GetCombinations(int[] input)
        {
            if (input.Length == 1)
            {
                return new List<string> { master[input[0]].ToString() };
            }
            HashSet<string> hashset = new HashSet<string>();

            List<string> strList = new List<string>();
            foreach (int i in input)
            {
                strList.Add(master[i].ToString());
            }
            string str = string.Empty;
            for (int i = 0; i < strList.Count; i++)
            {

            }
            return new List<string>();
        }
    }
}