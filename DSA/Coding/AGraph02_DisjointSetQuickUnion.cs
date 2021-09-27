﻿//https://leetcode.com/explore/learn/card/graph/618/disjoint-set/3840/
using System;

namespace Coding_AGraph02_UnionFindQuickUnion
{
    class UnionFind
    {
        int[] root;

        public UnionFind(int size)
        {
            root = new int[size];
            for (int i = 0; i < size; i++)
            {
                root[i] = i;
            }
        }

        public int Find(int x)
        {
            while (x != root[x])
                x = root[x];
            return x;
        }

        public void Union(int x, int y)
        {
            int rootX = Find(x);
            int rootY = Find(y);
            if (rootX != rootY)
                root[rootY] = rootX;
        }

        public bool Connected(int x, int y)
        {
            return Find(x) == Find(y);
        }
    }

    public class App
    {
        static void Main02()
        {
            UnionFind uf = new UnionFind(10);
            // 1-2-5-6-7 3-8-9 4
            uf.Union(1, 2);
            uf.Union(2, 5);
            uf.Union(5, 6);
            uf.Union(6, 7);
            uf.Union(3, 8);
            uf.Union(8, 9);
            Console.WriteLine(uf.Connected(1, 5)); // true
            Console.WriteLine(uf.Connected(5, 7)); // true
            Console.WriteLine(uf.Connected(4, 9)); // false
                                                   // 1-2-5-6-7 3-8-9-4
            uf.Union(9, 4);
            Console.WriteLine(uf.Connected(4, 9)); // true
        }
    }
}
