using System;
using System.Collections.Generic;

public static class ListOps
{
    public static int Length<T>(List<T> input)
    {
        int length = 0;

        foreach (var item in input)
        {
            length++;
        }

        return length;
    }

    public static List<T> Reverse<T>(List<T> input)
    {
        var reversed = new List<T>();
        
        for (int i = ListOps.Length(input) - 1; i >= 0; i--)
        {
            reversed.Add(input[i]);
        }

        return reversed;
    }

    public static List<TOut> Map<TIn, TOut>(List<TIn> input, Func<TIn, TOut> map)
    {
        var mapped = new List<TOut>();

        foreach (var item in input)
        {
            mapped.Add(map(item));
        }

        return mapped;
    }

    public static List<T> Filter<T>(List<T> input, Func<T, bool> predicate)
    {
        var filtered = new List<T>();

        foreach (var item in input)
        {
            if (predicate(item))
            {
                filtered.Add(item);
            }
        }

        return filtered;
    }

    public static TOut Foldl<TIn, TOut>(List<TIn> input, TOut start, Func<TOut, TIn, TOut> func)
    {
        var acc = start;

        foreach (var item in input)
        {
            acc = func(acc, item);
        }

        return acc;
    }

    public static TOut Foldr<TIn, TOut>(List<TIn> input, TOut start, Func<TIn, TOut, TOut> func)
    {
        var acc = start;

        for (int i = ListOps.Length(input) - 1; i >= 0; i--)
        {
            acc = func(input[i], acc);
        }

        return acc;
    }

    public static List<T> Concat<T>(List<List<T>> input)
    {
        var concatenated = new List<T>();

        foreach (var item in input)
        {
            concatenated = ListOps.Append(concatenated, item);
        }

        return concatenated;
    }

    public static List<T> Append<T>(List<T> left, List<T> right)
    {
        var appended = new List<T>();

        foreach (var item in left)
        {
            appended.Add(item);
        }

        foreach (var item in right)
        {
            appended.Add(item);
        }

        return appended;
    }
}
