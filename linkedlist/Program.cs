//linked lisusing System;

public class Node
{
    public int Data;
    public Node Next;

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

public class LinkedList
{
    private Node head;

    public LinkedList()
    {
        head = null;
    }

    // Add a new node to the end of the list
    public void Add(int data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }

    // Print all elements in the list
    public void PrintList()
    {
        Node current = head;
        while (current != null)
        {
            Console.Write(current.Data + " -> ");
            current = current.Next;
        }
        Console.WriteLine("null");
    }
}

class Program
{
    static void Main(string[] args)
    {
        LinkedList list = new LinkedList();
        list.Add(10);
        list.Add(20);
        list.Add(30);

        Console.WriteLine("Linked List:");
        list.PrintList();
    }
}