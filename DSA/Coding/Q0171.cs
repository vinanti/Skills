using System;

namespace Coding
{
    class Q0171
    {
        static void Main171()
        {
            TitleToNumber("ZY");
        }
        public static int TitleToNumber(string columnTitle)
        {
            string titleList = "*ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int power = columnTitle.Length - 1;
            int titleNumber = 0;
            foreach (char c in columnTitle)
            {
                titleNumber += titleList.IndexOf(c) * (int)Math.Pow(26, power);
                power--;
            }
            return titleNumber;
        }
    }
}
