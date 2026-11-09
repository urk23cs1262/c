using System;

class Program
{
    class Node
    {
        public int data;
        public Node next;

        public Node(int value)
        {
            data = value;
        }
    }

    static Node Reverse(Node head)
    {
        Node prev = null;
        Node current = head;

        while (current != null)
        {
            Node next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }

        return prev;
    }

    static void Main()
    {
        Node head = new Node(1);
        head.next = new Node(2);
        head.next.next = new Node(3);

        head = Reverse(head);

        while (head != null)
        {
            Console.Write(head.data + " ");
            head = head.next;
        }
    }
}