using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
    class Q0935
    {
        static void Main11()
        {
            KnightDialer(11);
        }
        public static int KnightDialer(int n)
        {
            if (n == 1) return 10;
            Dictionary<int, List<int>> master = new Dictionary<int, List<int>>();
            master.Add(0, new List<int>() { 4, 6 });
            master.Add(1, new List<int>() { 6, 8 });
            master.Add(2, new List<int>() { 7, 9 });
            master.Add(3, new List<int>() { 4, 8 });
            master.Add(4, new List<int>() { 0, 3, 9 });
            master.Add(5, new List<int>() { });
            master.Add(6, new List<int>() { 0, 1, 7 });
            master.Add(7, new List<int>() { 2, 6 });
            master.Add(8, new List<int>() { 1, 3 });
            master.Add(9, new List<int>() { 2, 4 });
            List<string> list = new List<string>();
            for (int i = 0; i < 10; i++)
                list.Add(i.ToString());
            n--;
            while (n > 0)
            {
                List<string> dummyList = new List<string>(list);
                list.Clear();
                foreach (string d in dummyList)
                {
                    int mas = d[d.Length - 1] - '0';
                    List<int> masterList = new List<int>(master[mas]);
                    foreach (int m in masterList)
                        list.Add(d + m);
                }
                n--;
            }
            return list.Count;
        }
    }
}
