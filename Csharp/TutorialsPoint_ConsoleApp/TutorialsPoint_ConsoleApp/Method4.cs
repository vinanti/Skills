using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialsPoint_ConsoleApp
{
    class Method4
    {
        static char GetGrade()
        {
            float percent = GetPercentage();
            if (percent >= 80)
                return 'A';
            else if (percent >= 60)
                return 'B';
            else if (percent >= 40)
                return 'C';
            else
                return 'D';
        }
        static float GetPercentage()
        {
            float totalmarks = GetTotal();
            float percentage = totalmarks * 100 / 300;
            return percentage;
        }
        static float GetTotal()
        {
            Console.Write("Enter Marks 1 :");
            float marks1 = float.Parse(Console.ReadLine());

            Console.Write("Enter Marks 2 :");
            float marks2 = float.Parse(Console.ReadLine());

            Console.Write("Enter Marks 3 :");
            float marks3 = float.Parse(Console.ReadLine());

            float total = marks1 + marks2 + marks3;
            return total;
        }
        static void Main1(string[] arg)
        {
            Console.WriteLine("Grade : " + GetGrade());
        }
    }
}
