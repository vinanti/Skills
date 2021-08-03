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
        Test(Test t) // Copy constructor
        {
            this.marks = t.marks;
        }
        static Test()
        {
            Test.maxmarks = 50;
        }
        
        void CalculatePercent()
        {
            int percent = this.marks * 100 / Test.maxmarks;
            Console.WriteLine(percent);
        }
        static void Main1(string[] args)
        {
            Test t1 = new Test();
            t1.CalculatePercent();
            Test t2 = new Test(35);
            t2.CalculatePercent();
            Test t3 = new Test(t2);
            t3.CalculatePercent();

            Test t4 = new Test(45);
            Test t5 = t4;
            t4.marks = 48;
            t5.CalculatePercent();


            Console.ReadLine();
            

        }
    }
}
