using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class ProteinTranslation
{
    private static Dictionary<string, string> codonProteinMap = new Dictionary<string, string>
    {
        ["AUG"] = "Methionine",
        ["UUU"] = "Phenylalanine", ["UUC"] = "Phenylalanine",
        ["UUA"] = "Leucine", ["UUG"] = "Leucine",
        ["UCU"] = "Serine", ["UCC"] = "Serine", ["UCA"] = "Serine", ["UCG"] = "Serine",
        ["UAU"] = "Tyrosine", ["UAC"] = "Tyrosine",
        ["UGU"] = "Cysteine", ["UGC"] = "Cysteine",
        ["UGG"] = "Tryptophan",
        ["UAA"] = "STOP", ["UAG"] = "STOP", ["UGA"] = "STOP"
    };

    public static string[] Proteins(string rna)
    {
        var codons = Regex.Matches(rna, "[A-Z]{3}")
                          .Cast<Match>()
                          .Select(e => e.Value)
                          .ToArray();

        List<string> proteins = new List<string>(codons.Length);
        foreach (var codon in codons)
        {
            if (!codonProteinMap.ContainsKey(codon))
            {
                throw new Exception($"Invalid codon: {codon}");
            }

            if (codonProteinMap[codon] == "STOP")
            {
                break;
            }

            proteins.Add(codonProteinMap[codon]);
        }
            
        return proteins.ToArray();
    }
}
