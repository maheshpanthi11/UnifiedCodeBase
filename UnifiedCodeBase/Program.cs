﻿using System;
using System.Collections.Generic;
using UnifiedCodeBase.Arrays;

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
                case "alphatriangle":
                    var tri = new AlphabetTriangle();
                    tri.ShowTriangle();

                    break;
                case "startriangle":
                    var star = new TriangleStar();
                    star.MakeStar();
                    break;
                case "mergearray":
                    MergeArray.Execute();
                    break;
                case "twosum":
                    TwoSum.Execute();
                    break;
                case "maxsumarray":
                    var maxSum = new MaxSumArray();
                    maxSum.MaxSubArray(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });
                    break;
                case "moveZeros":
                    var moveZeros = new MoveZeros();
                    moveZeros.MoveZeroes(new int[] { 0, 1, 0, 3, 12 });
                    break;
                case "containsduplicates":
                    var contains = new ContainsDuplicate();
                    contains.ContainsDuplicateItems(new int[] { 1, 2, 3, 1 });
                    break;
                case "linkedlist":
                    var linkList = new MyLinkedList<int>(9);
                    linkList.Append(5);
                    linkList.Prepend(10);
                    linkList.Append(13);
                    linkList.Append(14);
                    linkList.Insert(11, 3);
                    break;
                case "searchindex":
                    var search = new SearchIndex();
                    search.SearchInsert(new int[] { 1, 3, 5, 6 }, 0);
                    break;
                default:
                    Execute();
                    break;
            }
        }

        public static void Execute()
        {
            Console.WriteLine("Invalid Choice");
        }
    }
}


