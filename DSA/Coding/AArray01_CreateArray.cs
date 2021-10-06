//Creating an Array
using System;

namespace Coding_Array01
{
    class AArray01_CreateArray
    {
        static void Main01()
        {
            // The actual code for creating an Array to hold DVD's.
            DVD[] dvdCollection = new DVD[15];

        }
    }

    // A simple definition for a DVD.
    public class DVD
    {
        public string name;
        public int releaseYear;
        public string director;

        public DVD(string name, int releaseYear, string director)
        {
            this.name = name;
            this.releaseYear = releaseYear;
            this.director = director;
        }

        public void ConvertToString()
        {
            Console.WriteLine(this.name + ", directed by " + this.director + ", released in " + this.releaseYear);
        }
    }
}
