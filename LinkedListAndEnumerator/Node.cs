using System;

namespace LinkedListAndEnumerator
{
    public class Node
    {
        public int data;
        public Node next;

        public Node(int i)
        {
            data = i;
            next = null;
        }

        public void Print()
        {
            Console.Write("|" + data + "|-> ");
            
            if (next != null)
                next.Print();
        }

        public void AddSorted(int data)
        {
            if (next == null)
                next = new Node(data);
            else if (data < next.data)
            {
                Node tmp = new Node(data);
                tmp.next = this.next;
                this.next = tmp;
            }
            else
                next.AddSorted(data);
        }

        public void AddToEnd(int data)
        {
            if (next == null)
                next = new Node(data);
            else
                next.AddToEnd(data);
        }
    }
}