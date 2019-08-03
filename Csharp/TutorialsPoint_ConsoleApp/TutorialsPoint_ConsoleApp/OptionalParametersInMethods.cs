using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialsPoint_ConsoleApp
{
    class OptionalParametersInMethods
    {
        static float RectangleArea(float height, float width = 10)
        {
            float area = height * width;
            return area;
        }
        static void Main1(string[] args)
        {
            float result = RectangleArea(height: 10.5f);
            Console.WriteLine(result);
            result = RectangleArea(height: 10.5f, width: 20);
            Console.WriteLine(result);
        }
    }
}
