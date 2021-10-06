using System;
using System.Collections.Generic;

namespace HashTable01
{
    class Design_HashSet
    {
        static void Main01()
        {
            /**
            * Your MyHashSet object will be instantiated and called as such:
            * MyHashSet obj = new MyHashSet();
            * obj.add(key);
            * obj.remove(key);
            * bool param_3 = obj.contains(key);
            */
            MyHashSet myHashSet = new MyHashSet();
            myHashSet.Add(1);      // set = [1]
            myHashSet.Add(2);      // set = [1, 2]
            Console.WriteLine(myHashSet.Contains(1)); // return True
            Console.WriteLine(myHashSet.Contains(3)); // return False, (not found)
            myHashSet.Add(2);      // set = [1, 2]
            Console.WriteLine(myHashSet.Contains(2)); // return True
            myHashSet.Remove(2);   // set = [1]
            Console.WriteLine(myHashSet.Contains(2)); // return False, (already removed)
        }
    }
    class MyHashSet
    {
        private int MAX_LEN = 100000; // the amount of buckets
        private List<int>[] set;      // hash set implemented by array

        /** Returns the corresponding bucket index. */
        private int GetIndex(int key)
        {
            return key % MAX_LEN;
        }

        /** Search the key in a specific bucket. Returns -1 if the key does not existed. */
        private int GetPos(int key, int index)
        {
            // Each bucket contains a list.
            List<int> temp = set[index];
            if (temp == null)
            {
                return -1;
            }
            // Iterate all the elements in the bucket to find the target key.
            for (int i = 0; i < temp.Count; ++i)
            {
                if (temp[i] == key)
                {
                    return i;
                }
            }
            return -1;
        }

        /** Initialize your data structure here. */
        public MyHashSet()
        {
            set = new List<int>[MAX_LEN];
        }

        public void Add(int key)
        {
            int index = GetIndex(key);
            int pos = GetPos(key, index);
            if (pos < 0)
            {
                // Add new key if key does not exist.
                if (set[index] == null)
                {
                    set[index] = new List<int>();
                }
                set[index].Add(key);
            }
        }

        public void Remove(int key)
        {
            int index = GetIndex(key);
            int pos = GetPos(key, index);
            if (pos >= 0)
            {
                // Remove the key if key exists.
                set[index].Remove(index);
            }
        }

        /** Returns true if this set did not already contain the specified element */
        public bool Contains(int key)
        {
            int index = GetIndex(key);
            int pos = GetPos(key, index);
            return pos >= 0;
        }
    }
}


