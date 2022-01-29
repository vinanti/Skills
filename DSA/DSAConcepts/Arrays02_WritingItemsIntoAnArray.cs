using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAConcepts02
{
    class Arrays02_WritingItemsIntoAnArray
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
