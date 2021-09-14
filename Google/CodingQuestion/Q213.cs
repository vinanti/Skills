﻿/*Linear Search*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q213ns
{
    class Q213
    {
        public static bool linearSearch(int[] array, int length, int element)
        {
            // Check for edge cases. Is the array null or empty?
            // If it is, then we return false because the element we're
            // searching for couldn't possibly be in it.
            if (array == null || length == 0)
            {
                return false;
            }

            // Carry out the linear search by checking each element,
            // starting from the first one.
            for (int i = 0; i < length; i++)
            {
                // We found the element at index i.
                // So we return true to say it exists.
                if (array[i] == element)
                {
                    return true;
                }
            }

            // We didn't find the element in the array.
            return false;
        }

        static void Main213()
        {

            // Declare a new array of 6 elements
            int[] array = new int[6];

            // Variable to keep track of the length of the array
            int length = 0;

            // Iterate through the 6 indexes of the Array.
            for (int i = 0; i < 6; i++)
            {
                // Add a new element and increment the length as well
                array[length++] = i;
            }

            // Print out the results of searching for 4 and 30.
            Console.WriteLine("Does the array contain the element 4? - " + linearSearch(array, length, 4));
            Console.WriteLine("Does the array contain the element 30? - " + linearSearch(array, length, 30));

            // Does the array contain the element 4? - true
            // Does the array contain the element 30? - false
        }
    }
}