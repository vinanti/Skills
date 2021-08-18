/*Longest Word
 https://coderbyte.com/editor/Longest%20Word:Python3?

 Have the function LongestWord(sen) take the sen parameter being passed and return the longest word in the string. If there are two or more words that are the same length, return the first word from the string with that length. Ignore punctuation and assume sen will not be empty. Words may also contain numbers, for example "Hello world123 567"
Examples
Input: "fun&!! time"
Output: time
Input: "I love dogs"
Output: love
 */
using System;
using System.Linq;
using System.Collections.Generic;
class MainClass
{

    public static string LongestWord(string sen)
    {
        string[] list = sen.Split(" ");
        list = list.OrderByDescending(x => x).ToArray();
        foreach(string l in list)
        {
            if (IsAllAlphabets(l)) return l;
        }
        // code goes here  
        return string.Empty;

    }

    public static bool IsAllAlphabets(string str)
    {
        foreach(char c in str)
        {
            if (!char.IsLetter(c)) return false;
        }
        return true;
    }

    static void Main205()
    {
        // keep this function call here
        Console.WriteLine(LongestWord("fun & !!time")); //time
        Console.WriteLine(LongestWord("I love dogs")); //love
        Console.WriteLine(LongestWord("")); //
    }

}