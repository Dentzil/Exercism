using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class SimpleLinkedList<T> : IEnumerable<T>
{
    public SimpleLinkedList(T value, SimpleLinkedList<T> next = null)
    {
        Value = value;
        Next = next;
    }

    public SimpleLinkedList(IEnumerable<T> values)
    {
        if (!values.Any())
        {
            throw new Exception("An empty simple linked list cannot be initialized.");
        }

        Value = values.First();

        var current = this;
        foreach (var item in values.Skip(1))
        {
            current.Next = new SimpleLinkedList<T>(item);
            current = current.Next;
        }
    }

    public T Value { get; private set; }

    public SimpleLinkedList<T> Next { get; private set; }

    public SimpleLinkedList<T> Add(T value)
    {
        var current = this;
        while (current.Next != null)
        {
            current = current.Next;
        }

        current.Next = new SimpleLinkedList<T>(value);

        return this;
    }

    public IEnumerator<T> GetEnumerator()
    {
        var current = this;
        yield return current.Value;

        while (current.Next != null)
        {
            current = current.Next;
            yield return current.Value;
        }
    }

    public SimpleLinkedList<T> Reverse()
    {
        var head = new SimpleLinkedList<T>(Value);
        var next = Next;

        while (next != null)
        {
            head = new SimpleLinkedList<T>(next.Value, head);
            next = next.Next;
        }

        return head;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
