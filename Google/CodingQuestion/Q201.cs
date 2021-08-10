/*create an Array to hold up to 15 DVD
  */
using System;

namespace Q201ns
{
    class Q201
    {   
        static void Main201(string[] args)
        {
            DVD[] dvdCollection = new DVD[15];
            DVD dvd1 = new DVD("dvd1", 1984, "no director");
            dvdCollection[0] = dvd1;
            dvdCollection[0].toString();
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
 
