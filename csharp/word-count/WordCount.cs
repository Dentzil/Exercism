using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

public static class WordCount
{
    private static Regex _regex = new Regex("[^a-zA-Z0-9\']");

    public static IDictionary<string, int> CountWords(string phrase)
    {
        var wordsRepetition = new Dictionary<string, int>();

        _regex.Replace(phrase, " ")
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .ToList()
            .ForEach(e => 
            {
                var word = e.ToLower().Trim('\'');

                if (wordsRepetition.ContainsKey(word))
                {
                    wordsRepetition[word]++;
                }
                else
                {
                    wordsRepetition.Add(word, 1);
                }
            });
        
        return wordsRepetition;
    }
}
