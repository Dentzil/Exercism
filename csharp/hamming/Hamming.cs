namespace Exercism_hamming
{
    using System.Linq;

    public class Hamming
    {
        public static int Compute(string dna1, string dna2)
        {
            return dna1.Zip(dna2, (a, b) => a == b).Count(e => e == false);
        }
    }
}
