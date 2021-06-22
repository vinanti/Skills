using System;
//#define PI

namespace myConsoleApp
{
    class Test
    {
        int marks;
        void CalculatePercent()
        {
            int percent = this.marks * 100 / 50;
            System.Console.WriteLine(percent);
        }
        static void MainIC(string[] args)
        {
            Test t1 = new Test();
            t1.marks = 45;
            t1.CalculatePercent();

            Test t2 = new Test();
            t2.marks = 38;
            t2.CalculatePercent();
        }
    }
}
