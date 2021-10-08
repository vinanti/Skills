using System;
using System.Collections.Generic;

namespace Coding
{
    class Q1370
    {
        static void Main01()
        {
            SortString("aaaabbbbcccc");
        }
        public static string SortString(string s)
        {
            char[] sArray = s.ToCharArray();
            Array.Sort(sArray);
            Stack<char> stack1 = new Stack<char>();
            Stack<char> stack2 = new Stack<char>();
            string result = string.Empty;
            for (int i = sArray.Length - 1; i >= 0; i--)
                stack1.Push(sArray[i]);
            char temp = ' ';
            while (stack1.Count > 0 || stack2.Count > 0)
            {
               // if(stack1.Count > 0) temp = stack1.Pop();
                while (stack1.Count > 0)
                {
                    temp = stack1.Count > 0 ? stack1.Pop() : ' ';
                    if (temp == stack1.Peek())
                    {
                        stack1.Pop();
                        stack2.Push(temp);
                    }
                    else
                        result += temp;


                }
                //if (stack2.Count > 0) temp = stack2.Pop();
                while (stack2.Count > 0)
                {
                    temp = stack2.Count > 0 ? stack2.Pop() : ' ';
                    if (temp == stack2.Peek())
                    {
                        stack2.Pop();
                        stack1.Push(temp);
                    }
                    else
                        result += temp;
                   

                }
            }
            return result;
        }
    }
}
