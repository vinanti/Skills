using System;
//#define PI

namespace myConsoleApp
{
    class ConstructorClass
    {
        int marks; 
        static int maxmarks; 
        ConstructorClass()
        {
            this.marks = 45;
        }
        ConstructorClass(int marks)
        {
            this.marks = marks;
        }
        ConstructorClass(ConstructorClass t)
        {
            this.marks = t.marks;
        }
        static ConstructorClass()
        {
            ConstructorClass.maxmarks = 50;
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
            ConstructorClass t3 = new ConstructorClass(t1);
            t3.CalculatePercent();
            ConstructorClass t4 = new ConstructorClass(45);
            ConstructorClass t5 = t4;
            t5.CalculatePercent();
            t4.marks = 25;
            t5.CalculatePercent();
        }
    }
}
