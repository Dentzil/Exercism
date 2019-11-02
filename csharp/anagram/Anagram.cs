using System;
using System.Collections.Generic;
using System.Linq;

public class Anagram
{
    private string _baseWord;
    private IEnumerable<char> _baseWordChars;

    public Anagram(string baseWord)
    {
        _baseWord = baseWord;
        _baseWordChars = GetOrderedChars(baseWord);
    }

    public string[] FindAnagrams(string[] candidates)
    {
        return candidates.Where(IsMatch).ToArray();
    }

    private IEnumerable<char> GetOrderedChars(string word)
    {
        return word.Select(e => char.ToLowerInvariant(e)).OrderBy(e => e);
    }

    private bool IsMatch(string word)
    {
        return IsNotEqual(word) && HasSameChars(GetOrderedChars(word));
    }

    private bool IsNotEqual(string word)
    {
        return !string.Equals(_baseWord, word, StringComparison.InvariantCultureIgnoreCase);
    }

    private bool HasSameChars(IEnumerable<char> chars)
    {
        return _baseWordChars.SequenceEqual(chars);
    }
}
