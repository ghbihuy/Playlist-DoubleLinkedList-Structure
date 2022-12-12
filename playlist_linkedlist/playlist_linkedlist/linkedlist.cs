using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace playlist_linkedlist
{
    public class Node
    {
        public string Value;
        public Node Next, Previous;
        public Node()
        {
            Value = null;
            Next = Previous = null;
        }
        public Node(string element)
        {
            this.Value = element;
            Next = Previous = null;
        }
    }
    public class DoubleLinkedList
    {
        private int count;
        public Node First;
        public Node Last;
        public DoubleLinkedList()
        {
            First = new Node();
            Last = new Node();
            First.Next = Last;
            Last.Previous = First;
        }
        public Node Find(string Value)
        {
            Node current = new Node();
            current = First;
            while (current.Value != Value)
            {
                current = current.Next;
            }
            return current;
        }
        public void AddLast(string Value)
        {
            if (First.Value == null && Last.Value == null && First.Next == Last)
            {
                First.Value = Value;
                Last.Value = Value;
                count = 1;
            }
            else
            {
                if (count == 1)
                {
                    Last.Value = Value;
                    count = -1;
                }
                else
                {
                    Node node = new Node(Last.Value);
                    Last.Previous.Next = node;
                    node.Previous = Last.Previous;
                    node.Next = Last;
                    Last.Previous = node;
                    Last.Value = Value;
                }
            }
        }
        public void Remove(string value)
        {
            Node current = Find(value);
            if (current != First || current != Last)
            {
                current.Previous.Next = current.Next;
                current.Next.Previous = current.Previous;
                current.Next = null;
                current.Previous = null;
            }
            else
            {
                if (current == First)
                {
                    First.Next = First.Next.Next;
                    First.Next.Next.Previous = First;
                    First.Value = First.Next.Value;
                    First.Next.Previous = null;
                    First.Next.Next = null;
                }
                else
                {
                    Last.Previous = Last.Previous.Previous;
                    Last.Previous.Previous.Next = Last;
                    Last.Value = Last.Previous.Value;
                    Last.Previous.Previous = null;
                    Last.Previous.Next = null;
                }
            }
        }
    }
}
