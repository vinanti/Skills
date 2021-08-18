/*Q202 Accessing Elements in Arrays
 https://leetcode.com/explore/featured/card/fun-with-arrays/521/introduction/3294/
2 Primitive Operations:
Writing Elements into an Array
Reading Elements from ana array
*/

using System;

namespace Q202ns
{
    class Q202
    {
        static void Main202()
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

            //Notice that we put The Incredibles into the Array at index 3. What happens if we now run this next piece of code?
            DVD starWarsDVD = new DVD("Star Wars", 1977, "George Lucas");
            dvdCollection[3] = starWarsDVD;

            // Print out what's in indexes 7, 10, and 3.
            if (dvdCollection[7] != null)
                Console.WriteLine(dvdCollection[7].toString());
            if (dvdCollection[10] != null)
                Console.WriteLine(dvdCollection[10].toString());
            if (dvdCollection[3] != null)
                Console.WriteLine(dvdCollection[3].toString());

            // Will print:

            // The Avengers, directed by Joss Whedon, released in 2012
            // null
            // Star Wars, directed by George Lucas, released in 1977

            //Write items into an Array with a loop
            int[] squareNumbers = new int[10];

            // Go through each of the Array indexes, from 0 to 9.
            for (int i = 0; i < 10; i++)
            {
                // We need to be careful with the 0-indexing. The next square number
                // is given by (i + 1) * (i + 1).
                // Calculate it and insert it into the Array at index i.
                int square = (i + 1) * (i + 1);
                squareNumbers[i] = square;
            }
            for(int i=0; i<squareNumbers.Length; i++)
                Console.WriteLine("Square of " + (i+1) + " is " + squareNumbers[i]);

            //// For each VALUE in the Array.
            Console.WriteLine("Print values of array");
            foreach (var s in squareNumbers)
                Console.WriteLine(s);
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