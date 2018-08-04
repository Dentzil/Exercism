namespace Exercism_nucleotide_count
{
    using System;
    using System.Collections.Generic;

    public class DNA
    {
        public Dictionary<char, int> NucleotideCounts = new Dictionary<char, int>
        {
            ['A'] = 0,
            ['C'] = 0,
            ['G'] = 0,
            ['T'] = 0
        };

        public DNA(string dna)
        {
            foreach (var nucleotide in dna)
            {
                if (NucleotideCounts.ContainsKey(nucleotide))
                {
                    NucleotideCounts[nucleotide]++;
                }
            }
        }

        public int Count(char nucleotide)
        {
            if (!NucleotideCounts.ContainsKey(nucleotide))
            {
                throw new InvalidNucleotideException($"Nucleotide {nucleotide} doesn't exist.");
            }

            return NucleotideCounts[nucleotide];
        }
    }

    public class InvalidNucleotideException : Exception
    {
        public InvalidNucleotideException() { }

        public InvalidNucleotideException(string message) : base(message) { }
    }
}
