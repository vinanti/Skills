using System;
using System.Text;
namespace myConsoleApp
{
    class Programst
    {
        static void Mainst(string[] args)
        {
            string fname, lname;
            fname = "Vinanti";
            lname = "Thakur";

            string  fullname = fname + " " + lname; //concatination
            System.Console.WriteLine(fullname);

            fullname = string.Concat(fname, lname);
            System.Console.WriteLine(fullname);

            StringBuilder sb = new StringBuilder(fname);
            sb.Append("Patil");
            System.Console.WriteLine(sb);

            //String constructor
            char[] letters = {'H','e','l','l','o'};
            string greetings = new string(letters);
            System.Console.WriteLine("Greetings: {0}", greetings);
            char[] ch = greetings.ToCharArray();

            //Method retirning string
            string[] sarray = {"Hello", "From", "Tutorial", "Point"};
            string message = string.Join("-", sarray);
            System.Console.WriteLine("Message: {0}", message);

            //Formatting method to convert a value
            DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 1);
            string chat = string.Format("Message set at {0:t} on {0:D}", waiting);
            System.Console.WriteLine("Message:{0}", chat);

            string str = "Tutorials PoInt India Private Limited";
            string lower = str.ToLower();
            string upper = str.ToUpper();
            System.Console.WriteLine(lower);
            System.Console.WriteLine(upper);

            System.Console.WriteLine(str.StartsWith("Tu"));
            System.Console.WriteLine(str.StartsWith("TU"));
            System.Console.WriteLine(str.EndsWith("ED"));
            System.Console.WriteLine(str.EndsWith("ed"));

            System.Console.WriteLine(str.Contains("India"));

            System.Console.WriteLine(str.Equals(upper));
            System.Console.WriteLine(str.Equals(upper, StringComparison.CurrentCultureIgnoreCase));

            System.Console.WriteLine(str.IndexOf("In"));
            System.Console.WriteLine(str.IndexOf("In",13));

            System.Console.WriteLine(str.Length);


        }
    }
}
