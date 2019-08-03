using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialsPoint_ConsoleApp
{
    class Strings
    {
        static void Main(string[] args)
        {
            string fname, lname;
            fname = "Vinanti";
            lname = "Thakur";

            //Concate srings
            string fullname = fname + " " + lname;
            Console.WriteLine("Full Name: {0}", fullname);
            fullname = string.Concat(fname, lname);
            Console.WriteLine("Full Name: {0}", fullname);

            //by using string constructor
            char[] letters = { 'H', 'e', 'l', 'l', 'o' };
            //convert charater array to string
            string greetings = new string(letters); 
            Console.WriteLine("Greetings: {0}", greetings);
            //convert string to charater array
            char[] ch = greetings.ToCharArray(); 

            //methods returing string
            string[] sarray = { "Hello", "From", "Tutorials", "Point" };
            string message = String.Join(" ", sarray);
            Console.WriteLine("Message: {0}", message);
            message = String.Join("-", sarray);
            Console.WriteLine("Message: {0}", message);

            //formatting method to convert a value
            DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 1);
            string chat = String.Format("Message sent at {0:t} on {0:D}", waiting);
            Console.WriteLine("Message: {0}", chat);

            //Convert to lower and upper case
            string str = "Tutorials Point India Private Limited";
            string lower = str.ToLower();
            string upper = str.ToUpper();
            Console.WriteLine(lower);
            Console.WriteLine(upper);

            //Check string starting with/ending with
            Console.WriteLine(str.StartsWith("TU"));
            Console.WriteLine(str.StartsWith("Tu"));
            Console.WriteLine(str.EndsWith("ED"));
            Console.WriteLine(str.EndsWith("ed"));

            //To check if string contains
            Console.WriteLine(str.Contains("India"));
        }
    }
}
