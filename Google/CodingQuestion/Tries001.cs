/*Implement Tries
 208. Implement Trie (Prefix Tree)
https://leetcode.com/problems/implement-trie-prefix-tree/

A trie (pronounced as "try") or prefix tree is a tree data structure used to efficiently store and retrieve keys in a dataset of strings. There are various applications of this data structure, such as autocomplete and spellchecker.

Implement the Trie class:
Trie() Initializes the trie object.
void insert(String word) Inserts the string word into the trie.
boolean search(String word) Returns true if the string word is in the trie (i.e., was inserted before), and false otherwise.
boolean startsWith(String prefix) Returns true if there is a previously inserted string word that has the prefix prefix, and false otherwise.

Example 1:
Input
["Trie", "insert", "search", "search", "startsWith", "insert", "search"]
[[], ["apple"], ["apple"], ["app"], ["app"], ["app"], ["app"]]
Output
[null, null, true, false, true, null, true]

Explanation
Trie trie = new Trie();
trie.insert("apple");
trie.search("apple");   // return True
trie.search("app");     // return False
trie.startsWith("app"); // return True
trie.insert("app");
trie.search("app");     // return True

Constraints:
1 <= word.length, prefix.length <= 2000
word and prefix consist only of lowercase English letters.
At most 3 * 104 calls in total will be made to insert, search, and startsWith.
 */
using System;

namespace Tries001ns
{
    class Tries001
    {
        static void Main001()
        {
            Trie trie = new Trie();
            trie.Insert("apple");
            Console.WriteLine(trie.Search("apple"));   // return True
            Console.WriteLine(trie.Search("app"));     // return False
            Console.WriteLine(trie.StartsWith("app")); // return True
            trie.Insert("app");
            Console.WriteLine(trie.Search("app"));     // return True
        }
    }
    class Node
    {
        public char c;
        public bool isWord;
        public Node[] children;
        public Node(char c)
        {
            this.c = c;
            isWord = false;
            children = new Node[26];
        }
    }
    class Trie
    {
        private Node root;

        /*Initialize data structure here*/
        public Trie()
        {
            root = new Node('\0');
        }
        /*Inserts a word into the trie*/
        public void Insert(string word)
        {
            Node curr = root;
            for (int i = 0; i < word.Length; i++)
            {
                char c = word[i];
                if (curr.children[c - 'a'] == null) curr.children[c - 'a'] = new Node(c);
                curr = curr.children[c - 'a'];
            }
            curr.isWord = true;
        }
        /*Return if the word is in the trie*/
        public bool Search(string word)
        {
            Node node = GetNode(word);
            return node != null && node.isWord;
        }
        /*Return if there is any word in the trie that starts with the given prefix*/
        public bool StartsWith(string prefix)
        {
            return GetNode(prefix) != null;
        }
        private Node GetNode(string word)
        {
            Node curr = root;
            for (int i = 0; i < word.Length; i++)
            {
                char c = word[i];
                if (curr.children[c - 'a'] == null) return null;
                curr = curr.children[c - 'a'];
            }
            return curr;
        }
    }
}
