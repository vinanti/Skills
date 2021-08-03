using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Length
    {
        int feet, inch;
        public Length()
        {
            this.feet = 0;
            this.inch = 0;
        }
        public Length(int feet, int inch)
        {
            this.feet = feet;
            this.inch = inch;
        }
        public static Length operator +(Length l1, Length l2)
        {
            Length l3 = new Length();
            l3.feet = l1.feet + l2.feet;
            l3.inch = l1.inch + l2.inch;
            if(l3.inch >= 12)
            {
                l3.feet++;
                l3.inch -= 12;
            }
            return l3;
        }
        string GetLength()
        {
            return String.Format("Length : {0}' {1}\"", feet, inch);
        }
        static void Main(string[] args)
        {
            Length len1 = new Length(2, 11);
            Length len2 = new Length(4, 5);
            Length len3 = len1 + len2;
            Console.WriteLine(len1.GetLength());
            Console.WriteLine(len2.GetLength());
            Console.WriteLine(len3.GetLength());
        }
    }
}
