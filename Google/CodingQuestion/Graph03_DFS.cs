/*Graph Search, DFS and BFS
 https://www.youtube.com/watch?v=zaBhtODEL0w&list=PLI1t_8YX-ApvMthLj56t1Rf-Buio5Y8KL&index=15
https://questpond.teachable.com/ Chapter 4 :- Graph data structure ,BFS and DFS
 */
using System;
using System.Collections.Generic;

namespace Graph
{
    class Program
    {
        static void Main001()
        {
            Graph g = new Graph(7);
            g.AddEdge(1, 2);
            g.AddEdge(1, 3);
            g.AddEdge(3, 4);
            g.AddEdge(3, 5);
            g.AddEdge(4, 6);
            g.DFS(1);
        }
    }
    public class Graph
    {
        private int V = 0;
        private List<int>[] adj = null; //Adjaceny
        public Graph(int size)
        {
            V = size;
            adj = new List<int>[V];

            for (int i = 0; i < V; ++i)
                adj[i] = new List<int>();
        }

        public void AddEdge(int v1, int v2)
        {
            adj[v1].Add(v2);
        }
        public void DFS(int s)
        {
            bool[] visited = new bool[V];

            //For DFS use stack
            Stack<int> stack = new Stack<int>();
            visited[s] = true;
            stack.Push(s);

            while (stack.Count != 0)
            {
                s = stack.Pop();
                Console.WriteLine("next->" + s);
                foreach (int i in adj[s])
                {
                    if (!visited[i])
                    {
                        visited[i] = true;
                        stack.Push(i);
                    }
                }
            }
        }
    }
}
