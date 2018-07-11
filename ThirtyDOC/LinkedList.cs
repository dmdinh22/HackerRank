using System;

namespace HackerRank.ThirtyDOC
{
    class Node
    {
        public int data;
        public Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }

    }
    class LinkedList
    {
        public static Node insert(Node head, int data)
        {
            //Complete this method
            if (head == null)
            {
                return new Node(data);

            }
            head.next = insert(head.next, data);

            return head;
        }

        static void display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }
        static void LinkedListMain(String[] args)
        {

            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            display(head);
        }
    }
}