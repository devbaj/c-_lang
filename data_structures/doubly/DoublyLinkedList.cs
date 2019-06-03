using System;
using doubly;

public class DoublyLinkedList
{
    public DllNode Head;
    public DoublyLinkedList()
    {
        Head = null;
    }

    public void Add(int val)
    {
        DllNode newNode = new DllNode(val);
        if (Head == null) { Head = newNode; }
        else
        {
            DllNode runner = Head;
            while (runner.Next != null)
            {
                runner = runner.Next;
            }
            runner.Next = newNode;
            newNode.Prev = runner;
        }
    }

    public bool Remove(int val)
    {
        if (Head == null) { return false; }
        else if (Head.Value == val)
        {
            Head = Head.Next;
            Head.Prev = null;
            return true;
        }
        else
        {
            DllNode runner = Head;
            while (runner.Next != null)
            {
                if (runner.Value == val)
                {
                    runner.Prev.Next = runner.Next;
                    runner.Next.Prev = runner.Prev;
                    return true;
                }
            }
            if (runner.Value == val)
            {
                runner.Prev.Next = null;
                return true;
            }
            else { return false; }
        }
    }

    public void Reverse()
    {
        if (Head == null) { System.Console.WriteLine("Cannot reverse an empty list"); }
        else if (Head.Next == null) { return; }
        else
        {
            DllNode runner = Head;
            while (runner.Next != null) { runner = runner.Next;}
            Head = runner;
            DllNode temp = runner.Prev;
            runner.Prev = null;
            runner = runner.Next;
            while (runner.Next != null)
            {
                if (runner.Prev == null)
                {
                    runner.Next = null;
                }
                temp = runner.Next;
                runner.Next = runner.Prev;
                runner.Prev = temp;
            }
        }
    }
}