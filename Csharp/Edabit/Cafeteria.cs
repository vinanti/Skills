//How Edabit Works
using System;
using System.Linq;
using System.Collections;
namespace Edabit
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 10;
            int K = 1;
            int M = 2;
            int[] S = new int[] {2, 6};
            Console.WriteLine(getMaxAdditionalDinersCount(N, K, M, S));
        }
        public static int getMaxAdditionalDinersCount(int N, int K, int M, int[] S) {
            if(N < M+K)
                return 0;
            int[] Narr = new int[N];
            ArrayList myAL = new ArrayList();
            for(int i = 1; i <= N; i++)
                Narr[i-1] = i;
            foreach(int i in S)
            {
                int x1 = i-K>0?i-K:0;
                int x2 = i+K<N?i+K:N;
                Narr = Array.FindAll(Narr,x => x < x1 || x > x2);                
            }
            foreach(int n1 in Narr)
            {
                myAL.Add(n1);
                int x1 = n1-K>0?n1-K:0;
                int x2 = n1+K<N?n1+K:N;
                Narr = Array.FindAll(Narr,x => x < x1 || x > x2);
            }
            //Narrs.Concat(Narr);
            return myAL.Count;
        }

    }
}
