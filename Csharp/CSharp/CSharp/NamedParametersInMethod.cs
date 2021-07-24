using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedParametersInMethodns
{
    class NamedParametersInMethod
    {
        static float RectangleArea(float height, float width)
        {
            float area = height * width;
            return area;
        }
        static void Main1(string[] args)
        {
            float result = RectangleArea(width: 12, height: 10.5f);
            Console.WriteLine(result);
        }
    }
}
