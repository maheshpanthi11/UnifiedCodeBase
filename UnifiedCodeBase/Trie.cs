using System;
using System.Collections.Generic;
using System.Text;

namespace UnifiedCodeBase
{
    public class Trie
    {
        private Node root;
        public Trie()
        {
            root = new Node('\0');
        }

        public void Insert(string word = "random")
        {
            var curr = root;
            for (int i = 0; i < word.Length; i++)
            {
                char c = word[i];
                if (curr.Childrens[c - 'a'] == null) curr.Childrens[c - 'a'] = new Node(c);
                curr = curr.Childrens[c - 'a'];
            }
            curr.IsWord = true;
        }

        public bool Search(string word)
        {
            var node = GetNode(word);
            return node != null && node.IsWord;
        }

        public bool IsPrefix(string word)
        {
            return GetNode(word) != null;
        }

        private Node GetNode(string word)
        {
            var curr = root;
            for (int i = 0; i < word.Length; i++)
            {
                char c = word[i];
                if (curr.Childrens[c - 'a'] == null) return null;
                curr = curr.Childrens[c - 'a'];
            }
            return curr;
        }

        public class Node
        {
            public bool IsWord { get; set; } = false;
            public char Charactor { get; set; }
            public Node[] Childrens { get; set; }

            public Node(char c)
            {
                Charactor = c;
                Childrens = new Node[26];
            }
        }

    }
}
