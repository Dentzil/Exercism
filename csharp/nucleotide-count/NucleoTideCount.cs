using System;
using System.Collections.Generic;

public class NucleotideCount
{
    public static Dictionary<char, int> Count(string dna)
    {
        if (dna == null)
        {
            throw new ArgumentNullException(nameof(dna));
        }

        var nucleotideCount = new Dictionary<char, int>
        {
            ['A'] = 0,
            ['C'] = 0,
            ['G'] = 0,
            ['T'] = 0
        };

        foreach (var nucleotide in dna)
        {
            if (!nucleotideCount.ContainsKey(nucleotide))
            {
                throw new ArgumentException($"Invalid nucleotide: {nucleotide}.");
            }

            nucleotideCount[nucleotide]++;
        }

        return nucleotideCount;
    }
}
