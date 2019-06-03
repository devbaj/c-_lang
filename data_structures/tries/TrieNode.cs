using System;
using tries;

public class TrieNode
{
    public char Value;
    public bool IsWord;
    public char[] Nexts;
    public TrieNode(char value)
    {
        Value = value;
        IsWord = false;
        Nexts = new char[] {};
    }
}