using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialsPoint_ConsoleApp
{
    class Arrays
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array element");
            int[] arr = new int[] { 7, 3, 5, 1, 9, 2 };
            Console.WriteLine(arr[0]);

            Console.WriteLine("Array for loop");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("Array foreach");
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Sorting of an Array Assending (Bubble sort - n * (n-1)");
            arr = new int[] { 7, 3, 5, 1, 9, 2 };
            int temp;
            for (int i = 1; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Sorting of an Array Desending (Bubble sort - n * (n-1)");
            arr = new int[] { 7, 3, 5, 1, 9, 2 };
            //int temp;
            for (int i = 1; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Search Operation");
            arr = new int[] { 7, 3, 5, 1, 9, 2 };
            //int = temp;
            Console.WriteLine("Enter the number to search");
            int num = int.Parse(Console.ReadLine());
            bool found = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if(num == arr[i])
                {
                    found = true;
                    break;
                }
            }
            if(found)
                Console.WriteLine("Element found");
            else
                Console.WriteLine("Element not found");

            Console.WriteLine("Multi diamentional Array");
            int[,] arr1 = new int[3, 4] { { 1, 2, 3, 4, }, { 10, 20, 30, 40 }, { 11, 22, 33, 44 } };
            for(int i=0;i<3;i++)
            {
                for(int j=0; j<4;j++)
                {
                    Console.Write(arr1[i,j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Jagged Array");
            int[][] arr2 = new int[3][];
            arr2[0] = new int[3] { 1, 2, 3 };
            arr2[1] = new int[2] { 10, 20 };
            arr2[2] = new int[4] { 11, 22, 33, 44 };
            foreach(int[] ar in arr2)
            {
                foreach (int item in ar)
                {
                    Console.Write(item + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
