using System;
using System.Linq;

public class Hamming
{
    public static int Distance(string dna1, string dna2)
    {
        if (dna1?.Length != dna2?.Length)
        {
            throw new ArgumentException();
        }

        return dna1.Zip(dna2, (a, b) => a == b).Count(e => e == false);
    }
}
