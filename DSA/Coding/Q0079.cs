using System;
using System.Collections.Generic;

namespace Coding
{
    class Q0079
    {
        static void Main01()
        {
            Exist(new char[][] { new char[] { 'A', 'B', 'C', 'E' }, new char[] { 'S', 'F', 'C', 'S' }, new char[] { 'A', 'D', 'E', 'E' } }, "ABCCED");
        }
        public static bool Exist(char[][] board, string word)
        {
            Dictionary<List<int>, List<int>> list = new Dictionary<List<int>, List<int>>();
            int left = -1, right = -1, top = -1, down = -1;
            for (int i = 0; i < board.Length; i++)
                for (int j = 0; j < board[0].Length; j++)
                {
                    if (board[i][j] == word[0])
                    {
                        left = j + 1 > -1 ? 1 : -1;
                        right = j - 1 < board.Length ? 1 : -1;
                        top = i + 1 > -1 ? 1 : -1;
                        down = i - 1 < board[0].Length ? 1 : -1;
                        list.Add(new List<int> { i, j }, new List<int> { left, right, top, down });
                    }
                }
            foreach (char w in word.Substring(1, board.Length - 1))
            {
                Dictionary<List<int>, List<int>> tempList = new Dictionary<List<int>, List<int>>(list);
                foreach (KeyValuePair<List<int>, List<int>> pair in tempList)
                {
                    List<int> position = pair.Key;
                    List<int> direction = pair.Value;
                    left = direction[0];
                    right = direction[1];
                    top = direction[2];
                    down = direction[3];
                    int i = position[0], j = position[1];
                    if (left == 1 && j + 1 < board[0].Length && board[i][j + 1] == w)
                    {
                        j++;
                        left = j - 1 > -1 ? 1 : -1;
                        right = -1;
                        top = i - 1 > -1 ? 1 : -1;
                        down = i + 1 < board[0].Length ? 1 : -1;
                        list.Add(new List<int> { i, j }, new List<int> { left, right, top, down });
                        j--;
                    }
                    if (right == 1 && j - 1 > -1 && board[i][j - 1] == w)
                    {
                        j--;
                        left = -1;
                        right = j + 1 < board.Length ? 1 : -1;
                        top = i - 1 > -1 ? 1 : -1;
                        down = i + 1 < board[0].Length ? 1 : -1;
                        list.Add(new List<int> { i, j }, new List<int> { left, right, top, down });
                        j++;
                    }
                    if (top == 1 && i - 1 > -1 && board[i - 1][j] == w)
                    {
                        i--;
                        left = j - 1 > -1 ? 1 : -1;
                        right = j + 1 < board.Length ? 1 : -1;
                        top = -1;
                        down = i + 1 < board[0].Length ? 1 : -1;
                        list.Add(new List<int> { i, j }, new List<int> { left, right, top, down });
                        i++;
                    }
                    if (down == 1 && i + 1 < board.Length && board[i + 1][j] == w)
                    {
                        i++;
                        left = j - 1 > -1 ? 1 : -1;
                        right = j + 1 < board.Length ? 1 : -1;
                        top = i - 1 > -1 ? 1 : -1;
                        down = -1;
                        list.Add(new List<int> { i, j }, new List<int> { left, right, top, down });
                        i--;
                    }
                    list.Remove(position);
                }
            }
            return false;
        }
    }
}
