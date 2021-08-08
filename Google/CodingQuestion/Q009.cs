/* String Splosion
 https://codingbat.com/prob/p117334
 
 Given a non-empty string like "Code" return a string like "CCoCodCode".


stringSplosion("Code") → "CCoCodCode"
stringSplosion("abc") → "aababc"
stringSplosion("ab") → "aab"

Q.
Non empty string
single char -> no splosion
Exceeds max length? No
will it have number/special char? yes

T.
a -> a
stringSplosion("Code") → "CCoCodCode"
stringSplosion("abc") → "aababc"
stringSplosion("ab") → "aab"

A.
if single char -> return same
brut force 
forloope for each index
nes string = capture untill same string

E.

C.

Error:
1. missed directive System
2.string.Empty -> E capital
3.result apended insted of main string - silly mistake

 */
using System;
namespace Q009ns
{
    class Q009
    {
        static void Main009(string[] args)
        {
            Console.WriteLine(stringSplosion("a"));
            Console.WriteLine(stringSplosion("Code"));
            Console.WriteLine(stringSplosion("abc"));
            Console.WriteLine(stringSplosion("ab"));
        }
        static string stringSplosion(string str)
        {
            //Approach 1
            if (str.Length < 2) return str;
            string result = string.Empty;
            for(int i=0; i<str.Length; i++)
            {
                result += str.Substring(0,i+1);
            }
            return result;
            
        }
    }
}



