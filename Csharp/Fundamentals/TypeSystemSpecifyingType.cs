using System;
namespace TypeSystemSpecifyingType
{
    class Program
    {
        static void Main1(string[] args)
        {
            System.Console.WriteLine(GetName(1));
        }
        public static string GetName(int ID)
        {
            if (ID < names.Length)
                return names[ID];
            else
                return String.Empty;
        }
        private static string[] names = { "Spencer", "Sally", "Doug" };
    
    }
}
