using System;

namespace Coding_Array02_AccessElements1
{
    class AArray02_AccessElements
    {
        static void Main02()
        {
            // The actual code for creating an Array to hold DVD's.
            DVD[] dvdCollection = new DVD[15];

            // Firstly, we need to actually create a DVD object for The Avengers.
            DVD avengersDVD = new DVD("The Avengers", 2012, "Joss Whedon");

            // Next, we'll put it into the 8th place of the Array. Remember, because we
            // started numbering from 0, the index we want is 7.
            dvdCollection[7] = avengersDVD;

            DVD incrediblesDVD = new DVD("The Incredibles", 2004, "Brad Bird");
            DVD findingDoryDVD = new DVD("Finding Dory", 2016, "Andrew Stanton");
            DVD lionKingDVD = new DVD("The Lion King", 2019, "Jon Favreau");

            // Put "The Incredibles" into the 4th place: index 3.
            dvdCollection[3] = incrediblesDVD;

            // Put "Finding Dory" into the 10th place: index 9.
            dvdCollection[9] = findingDoryDVD;

            // Put "The Lion King" into the 3rd place: index 2.
            dvdCollection[2] = lionKingDVD;

            DVD starWarsDVD = new DVD("Star Wars", 1977, "George Lucas");
            dvdCollection[3] = starWarsDVD;

            // Print out what's in indexes 7, 10, and 3.
            Console.WriteLine(dvdCollection[7].ConvertToString());
            //Console.WriteLine(dvdCollection[10].ConvertToString());
            Console.WriteLine(dvdCollection[3].ConvertToString());

            // Will print:

            // The Avengers, directed by Joss Whedon, released in 2012
            // null
            // Star Wars, directed by George Lucas, released in 1977
        }
    }
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
