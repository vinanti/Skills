using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
    class Design_HashSet02
    {
        static void Main45()
        {
            Hashtable ht = new Hashtable();
            HashSet<int> hs = new HashSet<int>();
            BitArray keys = new BitArray(1000001);
            MyHashSet myHashSet = new MyHashSet();
            myHashSet.Add(1);      // set = [1]
            myHashSet.Add(2);      // set = [1, 2]
            myHashSet.Contains(1); // return True
            myHashSet.Contains(3); // return False, (not found)
            myHashSet.Add(2);      // set = [1, 2]
            myHashSet.Contains(2); // return True
            myHashSet.Remove(2);   // set = [1]
            myHashSet.Contains(2); // return False, (already removed)

        }
    }
    class MyHashSet
    {
        
        List<int> bucket = new List<int>();
        public void Add(int val)
        {
            if (!bucket.Contains(val)) bucket.Add(val);
        }
        public bool Contains(int val)
        {
            if (bucket.Contains(val)) return true;
            else return false;
        }
        public void Remove(int val)
        {
            if (bucket.Contains(val)) bucket.Remove(val);
        }
    }
}
