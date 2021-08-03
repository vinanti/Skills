using System;
using System.Collections.Generic;

namespace Graph
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph g = new Graph(7);
            g.AddEdge(1, 2);
            g.AddEdge(1, 3);
            g.AddEdge(3, 4);
            Console.WriteLine("-----------");
            g.BFS(1);
            //Console.WriteLine("-----------");
            //g.BFS(2);
            //Console.WriteLine("-----------");
            //g.BFS(3);
            //Console.WriteLine("-----------");
            //g.BFS(4);
            //Console.WriteLine("-----------");
            //g.BFS(5);
            //Console.WriteLine("-----------");
            //g.BFS(6);
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

            while(queue.Count != 0)
            {
                s = queue.Dequeue();
                Console.WriteLine("->" + s);

                foreach (var next in adj[s])
                {
                    if(!visited[next])
                    {
                        visited[next] = true;
                        //add to the queue
                        queue.Enqueue(next);
                    }
                }
            }
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
