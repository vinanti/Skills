/*Creating an Array
 *Accesing Elements in Array
    Writing Items into an Array
    Reading Items from an Array
 https://leetcode.com/explore/featured/card/fun-with-arrays/521/introduction/3236/
 */
using System;

namespace Q201ns
{
    class Array01_CreateAccess
    {   
        static void Main01()
        {
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
            Console.WriteLine(dvdCollection[7].toString());
            //Console.WriteLine(dvdCollection[10].toString());  //throw null exception
            Console.WriteLine(dvdCollection[3].toString());

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

        public string toString()
        {
            Console.WriteLine(
                this.name + ", directed by " + this.director + ", released in " + this.releaseYear);
            return string.Empty;
        }
    }
}
 
