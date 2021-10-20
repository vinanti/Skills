using System;
using System.Collections;

namespace Coding_AString02
{

    public class Usage_ArrayList
    {
        static void Main01()
        {
            //1.Initialize
            ArrayList arrayList = new ArrayList() { 1, 2 };
            ArrayList arrayList1;  // arrayList1 == null

            //2.Size
            Console.WriteLine("The size of arrayList1 is: " + arrayList.Count);

            //3.Access 1st element
            Console.WriteLine("The first element in arrayList1 is: " + arrayList[0]);

            //4.Add element
            arrayList.Add(50);
            arrayList.Insert(1, 25);

            //5.Modify element
            arrayList[1] = 35;

            //6.Remove element
            arrayList.Remove(50);

            //7.Remove all elements
            arrayList.Clear();

            //8.Check if element exists
            arrayList.Contains(35);

            //9.Index of element
            arrayList.IndexOf(35);

            //10.Iterate elements
            for (int i = 0; i < arrayList.Count; i++)
                Console.WriteLine(arrayList[i]);
            foreach (int item in arrayList)
                Console.WriteLine(item);


            //11.Convert to array
            int[] nums = new int[] { 2, 5, 1, 4, 3 };
            arrayList = new ArrayList(new int[] { 2, 5 });
            arrayList = new ArrayList(nums);

            

            //12.Copy elements to array
            //13.Check if equal
            //14.Sort


            // 2. cast an array to a vector


            // 3. make a copy
            ArrayList arrayList2 = arrayList;                      // another reference to v1
            ArrayList arrayList3 = new ArrayList(arrayList);     // make an actual copy of v1

  


            // 6. modify element
            arrayList2[0] = 5;      // modify v2 will actually modify v1
            Console.WriteLine("The first element in v1 is: " + arrayList[0]);
            arrayList2.Insert(0, -1);
            Console.WriteLine("The first element in v1 is: " + arrayList[0]);

            // 7. sort
            arrayList.Sort();

            // 8. add new element at the end of the ArrayList
            arrayList.Add(-1);
            arrayList.Insert(3, 5);

            // 9. delete the last element
            arrayList.Remove(5);
            arrayList.RemoveAt(2);

            //10. Index of element in ArrayList
            int index = arrayList.IndexOf(5);
            Console.WriteLine("Index of 5:" + index);

            //11.Remove all elements
            //arrayList0.Clear();

            //Check element exists
            arrayList.Contains(5);

            int[] array = new int[50];
            arrayList.CopyTo(array, 2);
        }
    }
}
