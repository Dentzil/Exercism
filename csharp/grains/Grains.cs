namespace Exercism_grains
{
    using static System.Math;

    public class Grains
    {
        public static ulong Total() => 18446744073709551615;

        public static ulong Square(int n)
        {
            return (ulong)(Pow(2, n) / 2);
        }
    }
}
