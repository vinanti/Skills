using System;
using System.Collections.Generic;

namespace Coding
{
    class Q1189
    {
        static void Main1189()
        {
            MaxNumberOfBalloons("nlaebolko");
        }
        public static int MaxNumberOfBalloons(string text)
        {
            List<char> bucket = new List<char>();
            foreach (char c in text)
                bucket.Add(c);
            bool notFound = false;
            string balloon = "balloon";
            int counter = 0;
            while (!notFound)
            {
                foreach (char b in balloon)
                {
                    if (!bucket.Contains(b))
                    {
                        notFound = true;
                        break;
                    }
                    else
                    {
                        bucket.Remove(b);
                    }
                }
                if (!notFound) counter++;
            }
            return counter;
        }
    }
}
