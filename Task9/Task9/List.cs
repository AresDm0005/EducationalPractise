using System;
using System.Collections;
using System.Collections.Generic;

namespace Task9
{
    public class List : IEnumerable
    {
        public class Node
        {
            public int Data { get; set; }
            public Node Next { get; set; }

            public Node(int item)
            {
                Data = item;
                Next = null;
            }
        }

        public int Length { get; protected set; }
        private Node head;
        private Node tail;

        public List()
        {
            Length = 0;
            head = null;
            tail = null;
        }

        public List(int[] arr)
        {
            head = null;
            tail = null;
            for (int i = 0; i < arr.Length; i++)
                Add(arr[i]);
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index > Length) throw new IndexOutOfRangeException();
                return FindNode(index).Next.Data;
            }

            set
            {
                if (index < 0 || index > Length) throw new IndexOutOfRangeException();

                Node node = FindNode(index).Next;
                node.Data = value;
            }
        }

        protected Node FindNode(int index)
        {
            Node find = head;

            // Для вставки & удаления нам нужен узел за 1 до индекса
            index--;

            int ind = 0;
            while (ind < index)
            {
                find = find.Next;
                ind++;
            }

            return find;
        }

        public void Add(int item)
        {
            Node node = new Node(item);

            if (head == null) head = node;
            else tail.Next = node;

            Length++;
            tail = node;
        }

        public void Remove(int index)
        {
            if (index < 0) throw new ArgumentOutOfRangeException("Индекс", "Индекс должен быть выражен неотрицательным числом");
            if (index > Length) throw new ArgumentOutOfRangeException("Индекс", "Индекс должен быть меньше или равно числу элементов в листе");

            if (index == 0) head = head.Next;
            else
            {
                Node node = FindNode(index);
                node.Next = node.Next.Next;
            }

            Length--;
        }

        public void Sort(IComparer<int> comparer)
        {
            int[] array = new int[Length];

            Node node = head;
            int index = 0;
            while (node != null)
            {
                array[index++] = node.Data;
                node = node.Next;
            }

            Array.Sort(array, comparer);
            Clear();

            for (int i = 0; i < array.Length; i++)
                Add(array[i]);
        }

        public void Clear()
        {
            Node node = head;

            while (node != null)
            {
                Node prev = node;
                node = node.Next;
                prev.Next = null;
            }

            head = null;
            tail = null;
            Length = 0;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            Node node = head;
            while (node != null)
            { 
                yield return node.Data;
                node = node.Next;
            }
        }

        public int Sum()
        {
            int sum = 0;

            Node node = head;
            while (node != null)
            {
                sum += node.Data;
                node = node.Next;
            }

            return sum;
        }

        public int Sum(Node node)
        {
            return (node != null) ? node.Data + Sum(node.Next) : 0;
        }

        public int SumRecurs()
        {
            return Sum(head);
        }
    }
}
