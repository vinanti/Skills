using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
    class Q0146
    {
    }
    public class LRUCache
    {
        int Capacity = 0;
        Dictionary<int, int> LRUList = new Dictionary<int, int>();
        Queue<int> KeyQueue = new Queue<int>();
        public LRUCache(int capacity)
        {
            this.Capacity = capacity;
        }

        public int Get(int key)
        {
            if (LRUList.ContainsKey(key))
            {
                AddLastInQueue(key);
                return LRUList[key];
            }
            else
            {
                return -1;
            }
        }

        public void Put(int key, int value)
        {
            if (LRUList.ContainsKey(key))
            {
                AddLastInQueue(key);
                LRUList[key] = value;
            }
            else if (LRUList.Count < Capacity)
            {
                KeyQueue.Enqueue(key);
                LRUList.Add(key, value);
            }
            else
            {
                int leasetUsedKey = KeyQueue.Dequeue();
                LRUList.Remove(leasetUsedKey);
                LRUList.Add(key, value);
                KeyQueue.Enqueue(key);
            }
        }
        private void AddLastInQueue(int key)
        {
            int size = KeyQueue.Count;
            for (int i = 0; i < size; i++)
            {
                int current = KeyQueue.Dequeue();
                if (current != key) KeyQueue.Enqueue(current);
            }
            KeyQueue.Enqueue(key);
        }
    }

    /**
     * Your LRUCache object will be instantiated and called as such:
     * LRUCache obj = new LRUCache(capacity);
     * int param_1 = obj.Get(key);
     * obj.Put(key,value);
     */
}
