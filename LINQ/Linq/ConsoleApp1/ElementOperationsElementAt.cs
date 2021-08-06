using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ElementOperationsElementAt
    {
        static void Main()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //EX.1 - fetch element present at index 4
            var result = numbers.ElementAt(4);
            Console.WriteLine(result);

            //Ex.2 - get the element for index which is not preset
            var result2 = numbers.ElementAtOrDefault(10);
            Console.WriteLine(result2);


            Console.ReadLine();
        }
    }
}
