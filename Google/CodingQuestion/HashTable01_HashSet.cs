using System;
using System.Collections.Generic;

namespace CodingQuestion
{
    class HashTable01_HashSet
    {
        static void Main01()
        {
            MyHashSet obj = new MyHashSet();
            obj.Add(3);
            obj.Add(103);
            Console.WriteLine(obj.Contains(3));
            obj.Remove(3);
            Console.WriteLine(obj.Contains(3));

        }
    }

    class MyHashSet
    {
        private Bucket[] bucketArray;
        private int keyRange;

        /** Initialize your data structure here. */
        public MyHashSet()
        {
            this.keyRange = 100;
            this.bucketArray = new Bucket[this.keyRange];
            for (int i = 0; i < this.keyRange; ++i)
                this.bucketArray[i] = new Bucket();
        }

        protected int _hash(int key)
        {
            return (key % this.keyRange);
        }

        public void Add(int key)
        {
            int bucketIndex = this._hash(key);
            this.bucketArray[bucketIndex].Insert(key);
        }

        public void Remove(int key)
        {
            int bucketIndex = this._hash(key);
            this.bucketArray[bucketIndex].Delete(key);
        }

        /** Returns true if this set contains the specified element */
        public bool Contains(int key)
        {
            int bucketIndex = this._hash(key);
            return this.bucketArray[bucketIndex].Exists(key);
        }
    }


    class Bucket
    {
        private List<int> container;

        public Bucket()
        {
            container = new List<int>();
        }

        public void Insert(int key)
        {
            int index = this.container.IndexOf(key);
            if (index == -1)
            {
                this.container.Add(key);
            }
        }

        public void Delete(int key)
        {
            this.container.Remove(key);
        }

        public bool Exists(int key)
        {
            int index = this.container.IndexOf(key);
            return (index != -1);
        }
    }
}
