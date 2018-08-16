using System;

public class DifferenceOfSquares
{
    public static long CalculateSquareOfSum(int n)
    {
        if (n < 0)
        {
            throw new ArgumentOutOfRangeException();
        }

        return (long)Math.Pow(n * (n + 1) / 2, 2);
    }

    public static long CalculateSumOfSquares(int n)
    {
        if (n < 0)
        {
            throw new ArgumentOutOfRangeException();
        }

        return (long)n * (n + 1) * (2 * n + 1) / 6;
    }

    public static long CalculateDifferenceOfSquares(int n)
    {
        return CalculateSquareOfSum(n) - CalculateSumOfSquares(n);
    }
}
