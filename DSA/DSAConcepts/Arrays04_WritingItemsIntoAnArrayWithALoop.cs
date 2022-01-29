using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAConcepts04
{
    class Arrays04_WritingItemsIntoAnArrayWithALoop
    {
        static void Main()
        {
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
