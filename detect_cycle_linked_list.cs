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

    static bool HasCycle(Node head)
    {
        Node slow = head;
        Node fast = head;

        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;

            if (slow == fast)
                return true;
        }

        return false;
    }

    static void Main()
    {
        Node a = new Node(1);
        Node b = new Node(2);
        Node c = new Node(3);

        a.next = b;
        b.next = c;
        c.next = b;

        Console.WriteLine(HasCycle(a) ? "Cycle Found" : "No Cycle");
    }
}