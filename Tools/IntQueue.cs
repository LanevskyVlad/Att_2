using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public class IntQueue
    {
        class Node
        {
            public int Value { get; set; }
            public Node Next { get; set; }

            public Node(int value = 0, Node next = null)
            {
                Value = value;
                Next = next;
            }
        }
        private Node Head;
        private Node Tail;
        public int Count { get; private set; }
        public bool IsEmpty => Count == 0;
        public IntQueue() => Clear();
        public IntQueue(List<int> list)
        {
            Clear();
            for (int i = 0; i < list.Count; i++)
                Enqueue(list[i]);
        }
        public void Clear()
        {
            Head = new Node();
            Tail = Head;
            Count = 0;
        }
        public int Peek()
        {
            if (Count == 0)
                throw new InvalidOperationException();
            return Head.Next.Value;
        }
        public int Dequeue()
        {
            if (Count == 0)
                throw new InvalidOperationException();
            int value = Head.Next.Value;
            Head = Head.Next;
            Count--;
            return value;
        }
        public void Enqueue(int value)
        {
            Tail.Next = new Node(value);
            Tail = Tail.Next;
            Count++;
        }
        public void RemoveAfterD(int D)
        {
            Node Go = Head.Next;
            while (Go != null && Go.Next != null)
            {
                if (Go.Value == D && Go.Next.Value != D)
                {
                    Go.Next = Go.Next.Next;
                    Count--;
                }
                Go = Go.Next;
            }
        }
        public List<int> ToList()
        {
            List<int> list = new List<int>();
            while (!IsEmpty)
                list.Add(Dequeue());
            return list;
        }
    }
}
