using System;
//#define PI

namespace myConsoleApp
{
    class ConstructorClass
    {
        int marks; 
        static int maxmarks = 50; 
        ConstructorClass()
        {
            this.marks = 45;
        }
        ConstructorClass(int marks)
        {
            this.marks = marks;
        }
        void CalculatePercent()
        {
            int percent = this.marks * 100 / maxmarks;
            System.Console.WriteLine(percent);
        }
        static void Maincon(string[] args)
        {
            ConstructorClass t1 = new ConstructorClass();
            t1.CalculatePercent();
            ConstructorClass t2 = new ConstructorClass(35);
            t2.CalculatePercent();
        }
    }
}
