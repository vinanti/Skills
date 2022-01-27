using System;

namespace DSAConcepts
{
    class Arrays01_CreatingAnArray
    {
        static void Main()
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

        public string ConvertToString()
        {
            return this.name + ", directed by " + this.director + ", released in " + this.releaseYear;
        }
    }
}
