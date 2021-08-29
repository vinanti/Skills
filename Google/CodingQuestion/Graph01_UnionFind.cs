/*Union Find - Disjoint Set*/
using System;
class UnionFind
{
    private int[] root;
    public UnionFind(int size)
    {
        root = new int[size];
        for (int i = 0; i < size; i++)
            root[i] = i;
    }
    public int find(int x) => root[x];
    public void union(int x, int y)
    {
        int rootX = find(x);
        int rootY = find(y);
        if (rootX != rootY)
            for (int i = 0; i < root.Length; i++)
                if (root[i] == rootY) root[i] = rootX;
    }
    public bool connected(int x, int y) => find(x) == find(y);
}
public class App
{
    static void Main01()
    {
        UnionFind uf = new UnionFind(10);
        // 1-2-5-6-7 3-8-9 4
        uf.union(1, 2);
        uf.union(2, 5);
        uf.union(5, 6);
        uf.union(6, 7);
        uf.union(3, 8);
        uf.union(8, 9);
        Console.WriteLine(uf.connected(1, 5)); // true
        Console.WriteLine(uf.connected(5, 7)); // true
        Console.WriteLine(uf.connected(4, 9)); // false
        // 1-2-5-6-7 3-8-9-4
        uf.union(9, 4);
        Console.WriteLine(uf.connected(4, 9)); // true
    }
}