using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

public static class WordCount
{
    private static Regex _regex = new Regex("[^a-zA-Z0-9\']");

    public static IDictionary<string, int> CountWords(string phrase)
    {
        return _regex.Replace(phrase, " ")
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(e => e.ToLower().Trim('\''))
            .GroupBy(e => e)
            .ToDictionary(k => k.Key, v => v.Count());
    }
}
