using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
    class Q0254
    {
        static void Main254()
        {
            GetFactors(12);
        }
        public static IList<IList<int>> GetFactors(int n)
        {
            List<IList<int>> result = new List<IList<int>>();
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    if(i <= n/i)
                        result.Add(new List<int>() { i, n / i });
                    if (n / i > 2)
                    {
                        IList<IList<int>> factorsList = new List<IList<int>>();
                        factorsList = GetFactors(n / i);
                        if (factorsList.Count > 0)
                        {
                            foreach (List<int> f in factorsList)
                            {
                                List<int> temp = new List<int>(f);
                                if(temp[temp.Count-1]<=i)
                                {
                                    temp.Add(i);
                                    result.Add(temp);
                                }
                            }
                        }
                    }
                }
            }
            return result;
        }
    }
}
