using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
    class Amazon
    {
        public List<string> IndenticalBooks(string[] authors)
        {
            //Dictionary<string, int> bucket = new Dictionary<string, int>();
            List<string> authorNames = new List<string>();
            List<int> bookCount = new List<int>();
            foreach (string author in authors)
            {
                if (!authorNames.Contains(author))
                {
                    authorNames.Add(author);
                    bookCount.Add(1);
                }
                else
                {
                    bookCount[authorNames.IndexOf(author)] = bookCount[authorNames.IndexOf(author)] + 1;
                }
            }
            List<string> result = new List<string>();
            while (bookCount.Count > 0)
            {
                int max1 = bookCount.Max();
                int index1 = bookCount.IndexOf(max1);
                int max2 = bookCount.Max();
                int index2 = bookCount.IndexOf(max2);

            }

            return new List<string>();
        }
    }
}
