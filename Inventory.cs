using System;

class Node
{
    public int Data;   // Stores the value
    public Node Next;  // Points to the next node

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

class SinglyLinkedList
{
    private Node head;

    // Add a node at the end
    public void Insert(int data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
            return;
        }
        
        Node temp = head;
        while (temp.Next != null)
        {
            temp = temp.Next;
        }
        temp.Next = newNode;
    }

    // Display the linked list
    public void Display()
    {
        Node temp = head;
        while (temp != null)
        {
            Console.Write(temp.Data + " -> ");
            temp = temp.Next;
        }
        Console.WriteLine("null");
    }

    // Delete a node from the beginning
    public void Delete()
    {
        if (head == null)
        {
            Console.WriteLine("List is empty!");
            return;
        }
        head = head.Next;
    }
}

class Program
{
    static void Main()
    {
        SinglyLinkedList list = new SinglyLinkedList();
        
        list.Insert(10);
        list.Insert(20);
        list.Insert(30);
        
        Console.WriteLine("Linked List:");
        list.Display();
        
        Console.WriteLine("After Deleting First Node:");
        list.Delete();
        list.Display();
    }
}
f