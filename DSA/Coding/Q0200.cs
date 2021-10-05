using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
    class Q0200
    {
        static void Main200()
        {
            //char[][] grid2 = new char[][] { new char[] { '1', '0', '1', '1', '0', '1', '1' } };
            //NumIslands(grid2);
            NumIslands(new char[][] {
            new char[] {'1', '1', '0', '0', '0' },
            new char[] {'1', '1', '0', '0', '0' },
            new char[] { '0', '0', '1', '0', '0' },
            new char[] {'0', '0', '0', '1', '1' }
            });

            //char[][] grid3 = new char[][] { new char[] { '1', '1', '1' }, new char[] { '0', '1', '0' }, new char[] { '1', '1', '1' } };
            //NumIslands(grid3);
        }
        public static int NumIslands(char[][] grid)
        {
            if (grid == null || grid.Length == 0)
            {
                return 0;
            }

            int nr = grid.Length;
            int nc = grid[0].Length;
            int num_islands = 0;
            for (int r = 0; r < nr; ++r)
            {
                for (int c = 0; c < nc; ++c)
                {
                    if (grid[r][c] == '1')
                    {
                        ++num_islands;
                        DFS(grid, r, c);
                    }
                }
            }
            return num_islands;
        }

        static void DFS(char[][] grid, int r, int c)
        {
            int nr = grid.Length;
            int nc = grid[0].Length;

            if (r < 0 || c < 0 || r >= nr || c >= nc || grid[r][c] == '0')
            {
                return;
            }

            grid[r][c] = '0';
            DFS(grid, r - 1, c);
            DFS(grid, r + 1, c);
            DFS(grid, r, c - 1);
            DFS(grid, r, c + 1);
        }
    }
}
