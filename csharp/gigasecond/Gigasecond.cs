using System;

public class Gigasecond
{
    public static int Value { get; } = 1000000000;

    public static DateTime Add(DateTime date)
    {
        return date.AddSeconds(Value);
    }
}
