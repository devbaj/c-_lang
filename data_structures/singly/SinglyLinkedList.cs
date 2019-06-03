using System;
using singly;

public class SinglyLinkedList
{
    public SllNode Head;
    public SinglyLinkedList()
    {
        Head = null;
    }

    public void Add(int value)
    {
        SllNode newNode = new SllNode(value);
        if (Head == null) { Head = newNode; }
        else
        {
            SllNode runner = Head;
            while (runner.Next != null) { runner = runner.Next; }
            runner.Next = newNode;
        }
    }

    public void Remove()
    {
        if (Head == null) { return; }
        SllNode runner = Head;
        while (runner.Next.Next != null) { runner = runner.Next; }
        runner.Next = null;
    }

    public void PrintValues()
    {
        if (Head == null) { System.Console.WriteLine("List is empty"); }
        else
        {
            SllNode runner = Head;
            while (runner != null) { System.Console.WriteLine(runner.Value); }
        }
    }

    public SllNode FindInt(int n)
    {
        if (Head == null) { return null; }
        SllNode runner = Head;
        while (runner != null)
        {
            if (runner.Value == n) { return runner; }
        }
        return null;
    }

    public void RemoveAt(int n)
    {
        if (Head == null) { System.Console.WriteLine("List is already empty"); }
        else if (n == 0) { Head = Head.Next; }
        else
        {
            int count = 0;
            SllNode runner = Head;
            while (runner.Next.Next != null)
            {
                if (count == n - 1)
                {
                    runner.Next = runner.Next.Next;
                }
                runner = runner.Next;
                count++;
            }
            if (count == n)
            {
                Remove();
            }
        }
    }
}