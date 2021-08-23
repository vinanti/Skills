/*
using System;
using System.Collections.Generic;

namespace HashTable02_HashMap_NS
{
    class HashTable02_HashMap
    {
        static void Main02()
        {
            MyHashMap obj = new MyHashMap();
            obj.put(key, value); int param_2 = obj.get(key); obj.remove(key);
        }
    }
    class Pair<U, V>
    {
        public U first;
        public V second;

        public Pair(U first, V second)
        {
            this.first = first;
            this.second = second;
        }
    }


    class Bucket
    {
        private List<Pair<int, int>> bucket;

        public Bucket()
        {
            this.bucket = new LinkedList<Pair<int, int>>();
        }

        public int get(int key)
        {
            foreach(Pair<int, int> pair in this.bucket)
            {
                if (pair.first.Equals(key))
                    return pair.second;
            }
            return -1;
        }

        public void update(int key, int value)
        {
            bool found = false;
            foreach(Pair<int, int> pair in this.bucket)
            {
                if (pair.first.Equals(key))
                {
                    pair.second = value;
                    found = true;
                }
            }
            if (!found)
                this.bucket.Add(new Pair<int, int>(key, value));
        }

        public void remove(int key)
        {
            foreach(Pair<int, int> pair in this.bucket)
            {
                if (pair.first.Equals(key))
                {
                    this.bucket.Remove(pair);
                    break;
                }
            }
        }
    }

    class MyHashMap
    {
        private int key_space;
        private List<Bucket> hash_table;

        //Initialize your data structure here. 
        public MyHashMap()
        {
            this.key_space = 2069;
            this.hash_table = new ArrayList<Bucket>();
            for (int i = 0; i < this.key_space; ++i)
            {
                this.hash_table.Add(new Bucket());
            }
        }

        // value will always be non-negative. 
        public void put(int key, int value)
        {
            int hash_key = key % this.key_space;
            this.hash_table.get(hash_key).update(key, value);
        }

        /**
         * Returns the value to which the specified key is mapped, or -1 if this map contains no mapping
         * for the key
         
        public int get(int key)
        {
            int hash_key = key % this.key_space;
            return this.hash_table.get(hash_key).get(key);
        }

        /** Removes the mapping of the specified value key if this map contains a mapping for the key 
        public void remove(int key)
        {
            int hash_key = key % this.key_space;
            this.hash_table.get(hash_key).remove(key);
        }
    }
}
*/