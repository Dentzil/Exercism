namespace Exercism_difference_of_squares
{
    using System;

    public class Squares
    {
        public long SumOfSquares { get; }

        public long SquareOfSum { get; }

        public long DifferenceOfSquares { get; }

        public Squares(int n)
        {
            if (n < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            SumOfSquares = (long)n * (n + 1) * (2 * n + 1) / 6;
            SquareOfSum = (long)Math.Pow(n * (n + 1) / 2, 2);
            DifferenceOfSquares = SquareOfSum - SumOfSquares;
        }
    }
}
