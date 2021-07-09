using System;

namespace UnifiedCodeBase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which proram you are trying to run");
            var input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "trie":
                    var trie = new Trie();
                    //Console.WriteLine("Insert words trie");
                    trie.Insert("random");
                    var isWord = trie.Search("random");
                    var isPrefix = trie.IsPrefix("ran");
                    break;
                case "firstmissingnumber":
                    var obj = new FirstMissingPostive();
                    var result = obj.FindFirstMissingPostive();
                    var result1 = obj.FirstMissingNumberBF();
                    break;
                default:
                    break;
            }
        }
    }
}
