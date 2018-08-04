namespace Exercism_protein_translation
{
    using System.Collections.Generic;
    using System.Linq;

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

        public static string[] Translate(string rna)
        {
            List<string> proteins = new List<string>();

            for (int i = 0; i < rna.Length; i += 3)
            {
                string codon = rna.Substring(i, 3);
                if (codonProteinMap[codon] == "STOP")
                {
                    break;
                }

                proteins.Add(codonProteinMap[codon]);
            }
                
            return proteins.ToArray();
        }
    }
}
