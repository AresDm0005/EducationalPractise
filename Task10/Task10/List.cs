using System;
using System.Collections;

namespace Task10
{
    public class TwoWayList : IEnumerable
    {
        private class Node
        {
            public double Data { get; set; }
            public Node Next { get; set; }
            public Node Prev { get; set; }

            public Node(double item)
            {
                Data = item;
                Next = null;
                Prev = null;
            }
        }

        public int Count { get; private set; }
        private Node head;
        private Node tail;

        public TwoWayList(double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                AddLast(arr[i]);
        }

        public void AddFirst(double item)
        {
            Node node = new Node(item);

            if (head != null)
            {
                node.Prev = null;
                node.Next = head;
                head.Prev = node;
            }
            else tail = node;

            head = node;
            Count++;
        }

        public void AddLast(double item)
        {
            Node node = new Node(item);

            if (head == null) head = node;
            else
            {
                tail.Next = node;
                node.Prev = tail;
                node.Next = null;
            }

            tail = node;

            Count++;
        }        

        public void RemoveAt(int index)
        {
            if (index < 0) throw new ArgumentOutOfRangeException("Index", "Index must be non negative number");
            if (index > Count) throw new ArgumentOutOfRangeException("Index", "Index must be less than size of the list");

            if (index == 0)
            {
                head = head.Next;
                head.Prev = null;
                Count--;
                return;
            }

            Node find = head;
            int ind = 0;
            while (ind < index)
            {
                find = find.Next;
                ind++;
            }

            Node prev = find.Prev;
            Node next = find.Next;

            if (find == tail)
            {
                prev.Next = null;
                tail = prev;
            }
            else
            {
                prev.Next = next;
                next.Prev = prev;
            }

            Count--;
        }

        public double Solve()
        {
            Node left = head;
            Node right = tail;

            double sum = 0;
            while (left != null && right != null)
            {
                sum += left.Data * right.Data;
                left = left.Next;
                right = right.Prev;
            }

            return sum;
        }

        public IEnumerator GetEnumerator()
        {
            Node node = head;
            while(node != null)
            {
                yield return node.Data;
                node = node.Next;
            }
        }
    }
}
