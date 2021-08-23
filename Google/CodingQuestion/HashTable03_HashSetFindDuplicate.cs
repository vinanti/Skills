using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingQuestion
{
    class HashTable03_HashSetFindDuplicate
    {
        static void Main03()
        {
            List<int> list1 = new List<int> { 1, 2, 3, 1, 2, 4, 5 };
            Console.WriteLine(findDuplicates(list1));
            List<int> list2 = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine(findDuplicates(list2));
        }
        static bool findDuplicates(List<int> keys)
        {
            HashSet<int> hashset = new HashSet<int>();
            foreach(int key in keys)
            {
                if (hashset.Contains(key))
                {
                    return true;
                }
                hashset.Add(key);
            }
            return false;
        }
    }
}
