/*Graph Search, DFS and BFS
 https://www.youtube.com/watch?v=zaBhtODEL0w&list=PLI1t_8YX-ApvMthLj56t1Rf-Buio5Y8KL&index=15
https://questpond.teachable.com/ Chapter 4 :- Graph data structure ,BFS and DFS
 */
using System;
using System.Collections.Generic;

namespace Graph_BFS
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
            g.BFS(1);
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

        public void BFS(int s)
        {
            //this is for vertex visited
            //so that we do not go in a loop
            bool[] visited = new bool[V];

            //queue for which the adjacent vertex
            Queue<int> queue = new Queue<int>();

            //mark the first vertex as visited
            visited[s] = true;

            //add to queue
            queue.Enqueue(s);

            while (queue.Count != 0)
            {
                s = queue.Dequeue();
                Console.WriteLine("->" + s);

                foreach (var next in adj[s])
                {
                    if (!visited[next])
                    {
                        visited[next] = true;
                        //add to the queue
                        queue.Enqueue(next);
                    }
                }
            }
        }
    }
}
