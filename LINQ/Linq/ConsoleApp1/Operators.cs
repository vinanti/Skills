using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorsnp
{
    class Operators
    {
        static void Main(string[] args)
        {
            List<string> strList1 = new List<string> { "Mihika", "Vinanti" };
            List<List<string>> strList2 = new List<List<string>> { new List<string> { "Mihika", "Vinanti" }, new List<string> { "Yogesh", "Thakur" } };

            List<int> numList1 = new List<int> { 0,1, 2, 3, 4, 5 };
            
            List<List<int>> numList2 = 
                new List<List<int>> { 
                    new List<int> { 0, 1 }, 
                    new List<int> { 10, 11 }, 
                    new List<int> { 20, 21 }, 
                    new List<int> { 30, 31 } };

            

            List<List<List<int>>> numList3 = 
                new List<List<List<int>>> { 
                    new List<List<int>> {
                        new List<int> { 0, 1 },
                        new List<int> { 10, 11 },
                        new List<int> { 20, 21 },
                        new List<int> { 30, 31 } }, 
                    new List<List<int>> {
                        new List<int> { 100, 101 },
                        new List<int> { 110, 111 },
                        new List<int> { 120, 121 },
                        new List<int> { 130, 131 } } };

            int a = numList3[1][2][1];

            var res1 = numList1.Select(x => x).ToList();
            var msNum = numList2.SelectMany(x => x).ToList();
            var msNum2 = numList3.SelectMany(x => x.SelectMany(y => y)).ToList();
            var msNum3 = numList2.SelectMany(x => x.Select(y => y+1)).ToList();


            int[] myNum = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var res2 = myNum.Select(x => x > 5); //Returned true/false value if conditiona or assign values if assigment
            var res3 = myNum.Where(x => x == 5);  //capture records which pass condition

            int[] myNum3 = new int[] { 1, 2, 3, 7, 8, 9 };

            var mixedData = new List<object> { "Adam", "Harry", "Kim", "John", 1, 2, 3, 4, 5 };
            var res4 = mixedData.OfType<int>().ToList();

            var res5 = mixedData.OrderBy(x => x.ToString()).ToList();

            var res6 = myNum.OrderBy(x => x).ThenByDescending(x => x).ToList();

            var res7 = myNum.All(x => x > 0);

            var res8 = myNum.Join(myNum3, n => n, n3 => n3, (n, n3) => n).ToList();
            var res9 = myNum.Intersect(myNum3).ToList();

            var res10 = myNum.ToLookup(n => n>5);

            foreach(var g in res10)
            {
                Console.WriteLine(g.Key);
                foreach(var s in g)
                {
                    Console.WriteLine(s);
                }
            }

            int[] nums = new int[] { 2, 3, 4, 5, 6, 7, 8, 9 , 10};

            int num1 = nums.ElementAt(5);
            int num2 = nums.ElementAtOrDefault(10);
            int num3 = nums.First();
            int num4 = nums.FirstOrDefault();
            int num5 = nums.Last();
            int num6 = nums.LastOrDefault();
            int num7 = nums.Where(x=> x==7).Single();
            int num8 = nums.Where(x => x >50).SingleOrDefault();

            var num9 = nums.Aggregate((a, b) => a * b);
            var num10 = nums.Average(x => x);
            var num11 = nums.Count();
            var num12 = nums.Count(x => x % 2 == 0);

            var num13 = nums.Min();
            var num14 = nums.Max();

            var num15 = nums.Sum();

            int[] numbers = new int[] { 82, 3, 4, 15, 6, 7, 8, 9, 10 };
            var num16 = numbers.OrderBy(x => x);

            Console.ReadLine();
        }
    }
}
