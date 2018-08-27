using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

public static class WordCount
{
    public static IDictionary<string, int> CountWords(string phrase)
    {
        var wordsRepetition = new Dictionary<string, int>();

        Regex.Replace(phrase, "[^a-zA-Z0-9\']", " ")
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
