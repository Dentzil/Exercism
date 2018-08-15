using System.Collections.Generic;
using System.Linq;

public static class RnaTranscription
{
    private static Dictionary<char, char> dnaToRnaMap = new Dictionary<char, char>
    {
        ['G'] = 'C',
        ['C'] = 'G',
        ['T'] = 'A',
        ['A'] = 'U'
    };

    public static string ToRna(string dna)
    {
        return string.Concat(dna.Select(e => dnaToRnaMap[e]));
    }
}
