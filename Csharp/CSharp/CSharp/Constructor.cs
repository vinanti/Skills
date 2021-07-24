using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructorns
{
    class Test
    {
        int marks;
        static int maxmarks = 50;
        Test() //Default Constructor
        {
            this.marks = 30;
        }
        Test(int marks) //Parameterized constuctor
        {
            this.marks = marks;
        }
        
        void CalculatePercent()
        {
            int percent = this.marks * 100 / Test.maxmarks;
            Console.WriteLine(percent);
        }
        static void Main(string[] args)
        {
            Test t1 = new Test();
            t1.CalculatePercent();
            Test t2 = new Test(35);
            t2.CalculatePercent();
            Console.ReadLine();
        }
    }
}
