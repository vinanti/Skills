using System;
using System.Collections.Generic;

namespace Coding_AQueue03
{
    class Node
    {
        public char val;
        public List<Node> next;
        public Node(char val = '0', List<Node> next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    class AQueue04_BFSTemplateI
    {
        static void Main01()
        {
            Node root =
                new Node('A', new List<Node>() {
                    new Node('B', new List<Node>() { new Node('E') }),
                    new Node('C', new List<Node>() { new Node('E'), new Node('F', new List<Node>() { new Node('G')} )}),
                    new Node('D', new List<Node>() { new Node('G') }) });
            int length =  BFS(root, new Node('G'));
        }
        /**
 * Return the length of the shortest path between root and target node.
 */
        static int BFS(Node root, Node target)
        {
            Queue<Node> queue = new Queue<Node>(); ;  // store all nodes which are waiting to be processed
            int step = 0;       // number of steps neeeded from root to current node
                                // initialize
                                //add root to queue;
            queue.Enqueue(root);
            // BFS
            while (queue.Count > 0)
            {
                step = step + 1;
                // iterate the nodes which are already in the queue
                int size = queue.Count;
                for (int i = 0; i < size; ++i)
                {
                    Node cur = queue.Peek(); //the first node in queue;
                    //return step if cur is target;
                    if (cur.val == target.val) return step;

                    if (cur.next != null)
                        foreach (Node next in cur.next) // the neighbors of cur
                        {
                            //add next to queue;
                            queue.Enqueue(next);
                        }
                    //remove the first node from queue;
                    queue.Dequeue();
                }
            }
            return -1;          // there is no path from root to target
        }
    }
}
