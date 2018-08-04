namespace Exercism_triangle
{
    using System;

    public enum TriangleKind
    {
        Degenerate,
        Equilateral,
        Isosceles,
        Scalene
    }

    public class Triangle
    {
        public static TriangleKind Kind(decimal a, decimal b, decimal c)
        {
            if (IsIllegal(a, b, c))
            {
                throw new TriangleException();
            }

            if (IsDegenerate(a, b, c))
            {
                return TriangleKind.Degenerate;
            }

            if (IsEquilateral(a, b, c))
            {
                return TriangleKind.Equilateral;
            }

            if (IsIsosceles(a, b, c))
            {
                return TriangleKind.Isosceles;
            }

            return TriangleKind.Scalene;
        }

        private static bool IsIllegal(decimal a, decimal b, decimal c)
        {
            return (a + b < c) || (a + c < b) || (b + c < a) || (a + b + c == 0);
        }

        private static bool IsDegenerate(decimal a, decimal b, decimal c)
        {
            return (a + b == c) || (a + c == b) || (b + c == a);
        }

        private static bool IsEquilateral(decimal a, decimal b, decimal c)
        {
            return (a == b) && (b == c);
        }

        private static bool IsIsosceles(decimal a, decimal b, decimal c)
        {
            return (a == b) || (a == c) || (b == c);
        }
    }

    public class TriangleException : Exception { }
}
