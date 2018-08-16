using static System.Math;

using System;

public class Grains
{
    public static ulong Total() => 18446744073709551615;

    public static ulong Square(int n)
    {
        if (n <= 0 || n > 64)
        {
            throw new ArgumentOutOfRangeException();
        }

        return (ulong)(Pow(2, n) / 2);
    }
}
