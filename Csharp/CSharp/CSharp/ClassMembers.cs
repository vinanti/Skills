using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMemeberns
{
    class Test
    {
        int marks; //instance
        static int maxmarks = 50; //class
        void CalculatePercent()
        {
            int percent = this.marks * 100 / Test.maxmarks;
            Console.WriteLine(percent);
        }
        static void Main1(string[] args)
        {
            Test t1 = new Test();
            t1.marks = 43;
            t1.CalculatePercent();

            Test t2 = new Test();
            t2.marks = 38;
            t2.CalculatePercent();
        }
    }
}
