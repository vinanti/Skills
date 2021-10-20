using System;

namespace Coding_AString04
{
    class Usage_String
    {
        static void Main01()
        {
            // initialize
            string s1 = "Hello World";
            Console.WriteLine("s1 is \"" + s1 + "\"");
            string s2 = s1;
            Console.WriteLine("s2 is another reference to s1.");
            string s3 = new string(s1);
            Console.WriteLine("s3 is a copy of s1.");

            Console.WriteLine(s1[0]);

            // compare using '=='
            Console.WriteLine("Compared by '==':");
            // true since string is immutable and s1 is binded to "Hello World"
            Console.WriteLine("s1 and \"Hello World\": " + (s1 == "Hello World"));
            // true since s1 and s2 is the reference of the same object
            Console.WriteLine("s1 and s2: " + (s1 == s2));
            // true since s3 is refered to new object of s1
            Console.WriteLine("s1 and s3: " + (s1 == s3));

            // compare using 'equals'
            Console.WriteLine("Compared by 'equals':");
            Console.WriteLine("s1 and \"Hello World\": " + s1.Equals("Hello World"));
            Console.WriteLine("s1 and s2: " + s1.Equals(s2));
            Console.WriteLine("s1 and s3: " + s1.Equals(s3));

            // compare using 'compareTo'
            Console.WriteLine("Compared by 'compareTo':");
            Console.WriteLine("s1 and \"Hello World\": " + (s1.CompareTo("Hello World") == 0));
            Console.WriteLine("s1 and s2: " + (s1.CompareTo(s2) == 0));
            Console.WriteLine("s1 and s3: " + (s1.CompareTo(s3) == 0));


            //1.Initialize
            string strHi = "HI";
            string str = new string(new char[] { 'H', 'i' });

            //2.Size
            int size = str.Length;

            //3.Access 1st element
            //NA

            //4.Add element
            str += "!";

            //5.Modify element
            //NA

            //6.Remove element
            //NA

            //7.Remove all elements
            str = string.Empty;

            //8.Check if element exists
            bool exits = str.Contains('i');

            //9.Index of element
            int index = str.IndexOf('i');
            int indexLast = str.LastIndexOf('i');

            //10.Iterate elements
            foreach (char c in str)
                Console.WriteLine(c);

            //11.Convert to array
            char[] charArray = str.ToCharArray();

            //12.Copy elements to array
            //NA

            //13.Sort
            //NA

            //14. Substring
            string str2 = str.Substring(1, 2);
        }
    }
}