using System;

namespace Coding
{
    class Q0168
    {
        static void Main168()
        {
            ConvertToTitle(52);
        }
        public static string ConvertToTitle(int columnNumber)
        {
            string titleList = "ZABCDEFGHIJKLMNOPQRSTUVWXY";
            string title = string.Empty;
            while (columnNumber > 0)
            {
                int num = columnNumber % 26 == 0 ? 26 : columnNumber % 26;
                title = titleList[num] + title;
                columnNumber -= num;
                columnNumber /= 26;
            }
            return title;
        }
    }
}
