using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
    class LinkedInQ2
    {
        static void Main01()
        {
            GeneratePermutations("abc");
        }
        public static List<string> GeneratePermutations(string s)
        {
            List<string> list = new List<string>();
            foreach (char c in s)
                list.Add(c.ToString());

            int length = s.Length - 1; //2
            while (length > 0)
            {
                List<string> dummyList = new List<string>(list);
                list.Clear();
                foreach (string d in dummyList)
                {
                    foreach (char c in s)
                    {
                        if (!d.Contains(c))
                            list.Add(d + c.ToString());
                    }
                }
                length--;
            }
            return list;
        }
    }
}
