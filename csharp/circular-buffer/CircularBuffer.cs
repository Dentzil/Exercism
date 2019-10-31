using System;
using System.Collections.Generic;

public class CircularBuffer<T>
{
    private Queue<T> _buffer;
    private int _capacity = 0;

    public CircularBuffer(int capacity)
    {
        _buffer = new Queue<T>(capacity);
        _capacity = capacity;
    }

    public T Read()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Empty buffer.");
        }

        return _buffer.Dequeue();
    }

    public void Write(T value)
    {
        if (IsFull())
        {
            throw new InvalidOperationException("Full buffer.");
        }

        _buffer.Enqueue(value);
    }

    public void Overwrite(T value)
    {
        if (IsFull())
        {
            _buffer.Dequeue();
        }
        
        _buffer.Enqueue(value);
    }

    public void Clear()
    {
        _buffer.Clear();
    }

    private bool IsEmpty()
    {
        return _buffer.Count == 0;
    }

    private bool IsFull()
    {
        return _buffer.Count == _capacity;
    }
}
