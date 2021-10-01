using System;
using System.Collections.Generic;

namespace Coding_ATries01
{
    class ATries01_ImplementTrie
    {
        static void Main01()
        {
            Trie trie = new Trie();
            trie.Insert("apple");
            Console.WriteLine(trie.Search("apple"));  // return True
            Console.WriteLine(trie.Search("app"));    // return False
            Console.WriteLine(trie.StartsWith("app"));// return True
            trie.Insert("app");
            Console.WriteLine(trie.Search("app"));   // return True
        }
    }
    class Trie
    {
        class TrieNode
        {
            public bool isWord;
            public Dictionary<char, TrieNode> childrenMap = new Dictionary<char, TrieNode>();
        }

        private TrieNode root;

        /** Initialize your data structure here. */
        public Trie()
        {
            root = new TrieNode();
        }

        /** Inserts a word into the trie. */
        public void Insert(string word)
        {
            TrieNode cur = root;
            for (int i = 0; i < word.Length; i++)
            {
                char c = word[i];
                if (cur.childrenMap.GetValueOrDefault(c) == null)
                {
                    // insert a new node if the path does not exist
                    cur.childrenMap.Add(c, new TrieNode());
                }
                cur = cur.childrenMap.GetValueOrDefault(c);
            }
            cur.isWord = true;
        }

        /** Returns if the word is in the trie. */
        public bool Search(string word)
        {
            TrieNode cur = root;
            for (int i = 0; i < word.Length; i++)
            {
                char c = word[i];
                if (cur.childrenMap.GetValueOrDefault(c) == null)
                {
                    return false;
                }
                cur = cur.childrenMap.GetValueOrDefault(c);
            }
            return cur.isWord;
        }

        /** Returns if there is any word in the trie that starts with the given prefix. */
        public bool StartsWith(string prefix)
        {
            TrieNode cur = root;
            for (int i = 0; i < prefix.Length; i++)
            {
                char c = prefix[i];
                if (cur.childrenMap.GetValueOrDefault(c) == null)
                {
                    return false;
                }
                cur = cur.childrenMap.GetValueOrDefault(c);
            }
            return true;
        }
    }
}
