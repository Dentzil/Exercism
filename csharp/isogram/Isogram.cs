namespace Exercism_isogram
{
    using System.Collections.Generic;
    using System.Linq;

    public static class Isogram
    {
        public static bool IsIsogram(string word)
        {
            Dictionary<char, int> lettersRepetition = new Dictionary<char, int>();

            string lowerCaseWord = word.ToLower();

            foreach (var c in lowerCaseWord)
            {
                if (char.IsLetter(c))
                {
                    if (lettersRepetition.ContainsKey(c))
                    {
                        lettersRepetition[c]++;
                    }
                    else
                    {
                        lettersRepetition[c] = 1;
                    }
                }
            }

            return lettersRepetition.GroupBy(e => e.Value).Count() == 1;
        }
    }
}
