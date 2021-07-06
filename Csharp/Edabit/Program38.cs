//Word Endings
using System;
using System.Linq;

namespace Edabit
{
    class Program38
    {
        static void Main38(string[] args)
        {
            string[] endingAdded = AddEnding(new string[] {"clever", "meek", "hurried", "nice"}, "ly");
            foreach(string e in endingAdded)
                Console.WriteLine(e);
        }
        public static string[] AddEnding(string[] arr, string ending)
        {
            for(int i=0; i<arr.Length; i++)
                arr[i] = arr[i] + ending;
            return arr;
        }
    }
}