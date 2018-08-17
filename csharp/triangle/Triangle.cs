    using System;

    public class Triangle
    {
        public static bool IsEquilateral(double a, double b, double c)
        {
            return !IsIllegal(a, b, c) && (a == b) && (b == c);
        }

        public static bool IsIsosceles(double a, double b, double c)
        {
            return !IsIllegal(a, b, c) && ((a == b) || (a == c) || (b == c));
        }

        public static bool IsScalene(double a, double b, double c)
        {
            return !IsIllegal(a, b, c) && (a != b) && (b != c);
        }

        private static bool IsIllegal(double a, double b, double c)
        {
            return (a + b < c) || (a + c < b) || (b + c < a) || (a + b + c == 0);
        }
    }
