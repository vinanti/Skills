/* Reverse a string
 https://www.coderbyte.com/editor/First%20Reverse:Csharp
Have the function FirstReverse(str) take the str parameter being passed and return the string in reversed order. 
For example: if the input string is "Hello World and Coders" then your program should return the string sredoC dna dlroW olleH.
Examples
Input: "coderbyte"
Output: etybredoc
Input: "I Love Code"
Output: edoC evoL I

Q:
str empty? yes -> empty
str alpha numeric special char - yes
case sensitve 

T:
"" -> ""
"Hello World and Coders" -> sredoC dna dlroW olleH
"coderbyte" -> etybredoc
"I Love Code" -> edoC evoL I
"Abc 123 !@#" -> #@! 321 cbA
A:
empty/blank/single char -> same
conver to char array
Linq Reverse()
conver to string (revered char array)
return

E:
"Abc 123 !@#" Length = 11
[a,b,c,...]
[#, @, 1..]
"#@! 321 cbA"

C:
O(1)

Error:
1. missed System for Linq directives
2. Generic collection not required.
 */
using System;
using System.Linq;

namespace Q008ns
{
    class Q008
    {
        static void Main008()
        {
            Console.WriteLine(FirstReverse(""));
            Console.WriteLine(FirstReverse("Hello World and Coders"));
            Console.WriteLine(FirstReverse("coderbyte"));
            Console.WriteLine(FirstReverse("I Love Code"));
            Console.WriteLine(FirstReverse("Abc 123 !@#"));
        }
        static string FirstReverse(string str)
        {
            //Approach 1
            return (str.Length < 2)? str : new string(str.ToArray().Reverse().ToArray());

            //Approach 2
            //spli string - reverse and join
            //return string.Join(str.Split("").Reverse().ToArray(),"");
        }
    }
}

