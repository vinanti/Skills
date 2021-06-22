using System;
//#define PI

namespace myConsoleApp
{
    class Test_ClassMember
    {
        int marks; //instance
        static int maxmarks = 50; //class
        void CalculatePercent()
        {
            int percent = this.marks * 100 / maxmarks;
            System.Console.WriteLine(percent);
        }
        static void MainTM(string[] args)
        {
            Test_ClassMember.maxmarks = 100;
            Test_ClassMember t1 = new Test_ClassMember();
            t1.marks = 45;
            t1.CalculatePercent();

            Test_ClassMember t2 = new Test_ClassMember();
            t2.marks = 30;
            t2.CalculatePercent();
        }
    }
}
