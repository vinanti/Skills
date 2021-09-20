using System;
using System.Collections.Generic;

namespace Coding
{
    class Q0212
    {
        static void Main212()
        {
            char[][] board = new char[][] { new char[] { 'o' , 'a' , 'a' , 'n' }, new char[] { 'e' , 't' , 'a' , 'e' }, new char[] { 'i' , 'h' , 'k' , 'r' }, new char[] { 'i' , 'f' , 'l' , 'v' } };
            string[] words = new string[] { "oath", "pea", "eat", "rain" };
            FindWords(board, words);
        }
        public static IList<string> FindWords(char[][] board, string[] words)
        {
            List<string> result = new List<string>();
            foreach (string w in words)
            {
                string boardWord = string.Empty;
                for (int i = 0; i < board.Length; i++)
                {
                    for (int j = 0; j < board[0].Length; j++)
                    {
                        boardWord += board[i][j];
                    }
                    if (boardWord.Contains(w)) result.Add(w);
                }

                boardWord = string.Empty;
                for (int i = 0; i < board[0].Length; i++)
                {
                    for (int j = 0; j < board.Length; j++)
                    {
                        boardWord += board[i][j];
                    }
                    if (boardWord.Contains(w)) result.Add(w);
                }
            }
            return (IList<string>)result;
        }
    }
}
