namespace Exercism_sum_of_multiples
{
    using System.Linq;

    public class SumOfMultiples
    {
        public static long To(int[] multipliers, int n)
        {
            return Enumerable.Range(1, n - 1)
                             .Where(e => multipliers.Any(m => e % m == 0))
                             .Sum();
        }
    }
}
