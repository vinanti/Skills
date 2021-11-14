using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
    class LinkedInQ1
    {
        static void Main05()
        {
            Pow(2, 4);
        }
        public static long Pow(long a, int b)
        { //a = 2, b = 4
          // implementation here
            long ans = 1;
            int left = b % 2; //0
            for (int i = 0; i < b / 2; i++)//i=1
            {
                ans *= a * a; //ans=4*2*2 = 16
            }
            if (left == 1) ans *= a;
            return ans;
        }
    }
}
