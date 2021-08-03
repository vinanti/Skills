using System;
using System.Linq;
using System.Collections.Generic;

namespace DSAChallenges
{
    class Program
    {
        static void Main0(string[] args)
        {
            var n = 123;


            Console.WriteLine(ColorfulNumber(n));
        }

        public static int ColorfulNumber(int n)
        {
            var nList = n.ToString().ToCharArray().Select(c => (int)(c - '0')).ToList();
            if (nList.Contains(0)) return 0;
            if (!nList.OrderBy(x => x).SkipWhile((x, i) => i<(nList.Count-1) && nList[i] != nList[i+1]).Any()) return 0;
            List<int> product = new List<int>();
            for(int i=0; i<nList.Count; i++)
            {
                for (int j = 0; j < nList.Count; j++)
                {
                    if(j < nList.Count - i)
                        product.Add(nList.Skip(i).TakeWhile((x, index) => index <= j).Aggregate((total, next) => total * next));
                }
                    
            }
            if (product.OrderBy(x => x).SkipWhile((x, i) => i < (product.Count - 1) && product[i] != product[i + 1]).Any())
                return 1;
            else
                return 0;
        }
    }
}
