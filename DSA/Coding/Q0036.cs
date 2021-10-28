using System;
using System.Collections.Generic;

namespace Coding
{
    class Q0036
    {
        static void Main36()
        {
            IsValidSudoku(new char[][] {new char[] {'5','3','.','.','7','.','.','.','.'}
                                        ,new char[] {'6','.','.','1','9','5','.','.','.'}
                                        ,new char[] {'.','9','8','.','.','.','.','6','.'}
                                        ,new char[] {'8','.','.','.','6','.','.','.','3'}
                                        ,new char[] {'4','.','.','8','.','3','.','.','1'}
                                        ,new char[] {'7','.','.','.','2','.','.','.','6'}
                                        ,new char[] {'.','6','.','.','.','.','2','8','.'}
                                        ,new char[] {'.','.','.','4','1','9','.','.','5'}
                                        ,new char[] {'.','.','.','.','8','.','.','7','9'}});

            /*
           [[".",".",".",".",".",".","5",".","."],
            [".",".",".",".",".",".",".",".","."],
            [".",".",".",".",".",".",".",".","."],
            ["9","3",".",".","2",".","4",".","."],
            [".",".","7",".",".",".","3",".","."],
            [".",".",".",".",".",".",".",".","."],
            [".",".",".","3","4",".",".",".","."],
            [".",".",".",".",".","3",".",".","."],
            [".",".",".",".",".","5","2",".","."]]
             
             
             */
        }
        public static bool IsValidSudoku(char[][] board)
        {
            foreach (char[] b in board)
                if (!IsValidArray(b)) return false;

            for (int i = 0; i < 9; i++)
            {
                char[] temp = new char[9];
                for (int j = 0; j < 9; j++)
                    temp[j] = board[j][i];
                if (!IsValidArray(temp)) return false;
            }
            int x = 0, y = 0;
            while (x < 9)
            {
                char[] temp = new char[9];
                int k = 0;
                for (int i = y; i < y + 3; i++)
                {
                    for (int j = x; j < x + 3; j++)
                    {
                        temp[k] = board[i][j];
                        k++;
                    }
                }
                if (!IsValidArray(temp)) return false;
                if (x == 6)
                {
                    if (y == 6) { x = 9; y = 0; }
                    else if (y == 3) { y = 6; }
                    else if (y == 0) { y = 3; }
                }
                if (x == 3)
                {
                    if (y == 6) { x = 6; y = 0; }
                    else if (y == 3) { y = 6; }
                    else if (y == 0) { y = 3; }
                }
                if (x == 0)
                {
                    if (y == 6) { x = 3; y = 0; }
                    else if (y == 3) { y = 6; }
                    else if (y == 0) { y = 3; }
                }
            }
            return true;
        }
        public static bool IsValidArray(char[] array)
        {
            HashSet<char> bucket = new HashSet<char>();
            foreach (char a in array)
                if (a != '.')
                    if (!bucket.Contains(a)) bucket.Add(a);
                    else return false;
            return true;
        }
    }
}
