using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqChallenges
{
    class Program9
    {
        static void Main(string[] args)
        {
            /*Decrypt number
Given a non-empty string consisting only of special chars (!, @, # etc.), return a number (as a string) 
            where each digit corresponds to given special char on the keyboard ( 1→ !, 2 → @, 3 → # etc.).
Expected input and output
"())(" → "9009"
"*$(#&" → "84937"
"!!!!!!!!!!" → "1111111111"*/

            var encryptedNumber = "#(@*%)$(&$*#&";

            string specialChar = ")!@#$%^&*(";

            var result = new string(encryptedNumber.Select(e => char.Parse(specialChar.IndexOf(e).ToString())).ToArray());

            //foreach (int item in result)
                Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
