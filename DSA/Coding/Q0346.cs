using System;
using System.Collections.Generic;

namespace Coding_Q0346
{
    class Q0346
    {
        static void Main346()
        {
            //Your MovingAverage object will be instantiated and called as such:
            MovingAverage movingAverage = new MovingAverage(3);
            Console.WriteLine(movingAverage.Next(1)); // return 1.0 = 1 / 1
            Console.WriteLine(movingAverage.Next(10)); // return 5.5 = (1 + 10) / 2
            Console.WriteLine(movingAverage.Next(3)); // return 4.66667 = (1 + 10 + 3) / 3
            Console.WriteLine(movingAverage.Next(5)); // return 6.0 = (10 + 3 + 5) / 3
        }
    }
    public class MovingAverage
    {
        int[] list = new int[] { };
        int pointer = 0;
        bool flag;

        /** Initialize your data structure here. */
        public MovingAverage(int size)
        {
            list = new int[size];
        }

        public double Next(int val)
        {
            if(pointer >= list.Length)
            {
                pointer = 0; flag = true;
            }
            list[pointer] = val;
            pointer++;
            double avg = 0;
            double length = flag ? list.Length : pointer;
            for (int i = 0; i < length; i++)
            {
                avg += list[i];
            }
            return avg/length;
        }
    }
}
