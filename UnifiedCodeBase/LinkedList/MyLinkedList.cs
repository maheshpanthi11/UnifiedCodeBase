using System;
using System.Collections.Generic;
using System.Text;

namespace UnifiedCodeBase
{
    public class MyLinkedList<T>
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public int Length { get; set; } = 0;

        public MyLinkedList(T value)
        {
            var node = new Node(value);
            this.Head = node;
            this.Tail = this.Head;
            Length++;
        }

        public Node Append(T value)
        {
            var node = new Node(value);
            Tail.Next = node;
            Tail = node;
            this.Length++;
            return node;
        }

        public Node Prepend(T value)
        {
            var node = new Node(value);
            node.Next = Head;
            Head = node;
            Length++;
            return node;
        }

        public Node Insert(T value, int index)
        {
            var node = new Node(value);
            var leader = GetNodeAt(index - 1);
            node.Next = leader.Next;
            leader.Next = node;
            return node;
        }

        public void Delete(int index)
        {
            var leader = GetNodeAt(index - 1);
            var next = leader.Next.Next;
            leader.Next = next;
        }

        private Node GetNodeAt(int index)
        {
            var current = this.Head;
            var counter = 0;

            if (index > Length)
            {
                return Tail;
            }
            while (index != counter)
            {
                current = current.Next;
                counter++;
            }

            return current;
        }

        public class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }

            public Node(T data)
            {
                Data = data;
                Next = null;
            }
        }
    }
}
