using System;
using System.Collections.Generic;
namespace Coding
{
    class Q0042
    {
        static void Main42()
        {
            Trap(new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 });
        }
        public static int Trap(int[] height)
        {
            int ans = 0, current = 0;
            Stack<int> st = new Stack<int>();
            while (current < height.Length)
            {
                while (st.Count > 0 && height[current] > height[st.Peek()])
                {
                    int top = st.Peek();
                    st.Pop();
                    if (st.Count == 0) break;
                    int distance = current - st.Peek() - 1;
                    int bounded_height = Math.Min(height[current], height[st.Peek()]) - height[top];
                    ans += distance * bounded_height;
                }
                st.Push(current++);
            }
            return ans;
        }
    }
}
