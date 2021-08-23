/*Quick Find - Disjoint SetQuick Find - Disjoint Set*/
using System;
using System.Linq;
namespace Graph002
{
    class UnionFind
    {
        private int[] root;

        public UnionFind(int size)
        {
            root = new int[size];
            for (int i = 0; i < size; i++)
            {
                root[i] = i;
            }
        }

        public int find(int x)
        {
            return root[x];
        }

        public void union(int x, int y)
        {
            int rootX = find(x);
            int rootY = find(y);
            if (rootX != rootY)
            {
                for (int i = 0; i < root.Length; i++)
                {
                    if (root[i] == rootY)
                    {
                        root[i] = rootX;
                    }
                }
            }
        }

        public int province()
        {
            return root.Distinct().Count(); 
        }
    }

    public class App
    {
        static void Main002()
        {
            int[][] isConnected1 = new int[][] {new int[] {1, 1, 0}, new int[]{1, 1, 0}, new int[]{0, 0, 1} };
            Console.WriteLine(FindCircleNum(isConnected1));

            int[][] isConnected2 = new int[][] { new int[] { 1, 0, 0 }, new int[] { 0, 1, 0 }, new int[] { 0, 0, 1 } };
            Console.WriteLine(FindCircleNum(isConnected2));

        }
        public static int FindCircleNum(int[][] isConnected)
        {
            UnionFind uf = new UnionFind(isConnected.Length);
            for (int i = 0; i < isConnected.Length; i++)
                for (int j = i; j < isConnected.Length; j++)
                    if (isConnected[i][j] == 1) uf.union(i, j);
            return uf.province();
        }
    }
}
