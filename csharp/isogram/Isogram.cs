using System.Collections.Generic;
using System.Linq;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        Dictionary<char, int> lettersRepetition = new Dictionary<char, int>();

        foreach (var c in word)
        {
            if (char.IsLetter(c))
            {
                var letter = char.ToLower(c);

                if (lettersRepetition.ContainsKey(letter))
                {
                    lettersRepetition[letter]++;
                }
                else
                {
                    lettersRepetition[letter] = 1;
                }
            }
        }

        return word.Length == 0 || lettersRepetition.GroupBy(e => e.Value).Count() == 1;
    }
}
