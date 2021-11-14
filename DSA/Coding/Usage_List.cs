using System;
using System.Collections.Generic;

namespace Coding
{
    class Usage_List
    {
        static void Main()
        {
            //1.Initialize
            List<int> list = new List<int>();
            list.Add(10);

            //2.Size
            int size = list.Count;

            //3.Access 1st element
            int ele = list[0];

            //4.Add element
            list.Add(20);
            list.Add(30);
            list.Add(15);
            list.Add(20);

            //5.Modify element
            list[0] = 5;

            //6.Remove element
            list.Remove(30);

            //7.Remove all elements
            //list.Clear();

            //8.Check if element exists
            bool exists = list.Contains(15);

            //9.Index of element
            int index = list.IndexOf(20);
            index = list.LastIndexOf(20);

            //10.Iterate elements
            foreach (int l in list)
                Console.WriteLine(l);

            for (int i = 0; i < list.Count; i++)
                Console.WriteLine(list[i]);

            //11.Convert to array
            int[] array = list.ToArray();

            //12.Copy elements to array
            int[] array2 = new int[50];
            list.CopyTo(array2, 1);

            //13.Sort
            list.Sort();

            //Merge 2 lists
            List<int> list2 = new List<int>();
            list2.Add(50);
            list.AddRange(list2);

            //
            list.RemoveAt(2);

            List<List<List<int>>> intterList = new List<List<List<int>>>();
            List<int> list1 = new List<int>() { 1, 2, 3 };
            List<int> list22 = new List<int>() { 1, 2, 3 };
            List<int> list3 = new List<int>() { 1, 2, 3 };
            List<List<int>> list11 = new List<List<int>>(){list1, list22, list3};
            List<List<int>> list12 = new List<List<int>>() { list1, list22, list3 };
            intterList.Add(list11);
            intterList.Add(list12);

            int a = intterList[0][0][0];
            int b = intterList[0][1][2];

        }
    }
}
