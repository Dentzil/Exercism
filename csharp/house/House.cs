using System;
using System.Collections.Generic;
using System.Linq;

public static class House
{
    private static List<string> phrases = new List<string>
    {
        "the house that Jack built",
        "the malt that lay in",
        "the rat that ate",
        "the cat that killed",
        "the dog that worried",
        "the cow with the crumpled horn that tossed",
        "the maiden all forlorn that milked",
        "the man all tattered and torn that kissed",
        "the priest all shaven and shorn that married",
        "the rooster that crowed in the morn that woke",
        "the farmer sowing his corn that kept",
        "the horse and the hound and the horn that belonged to"
    };

    public static string Recite(int verseNumber)
    {
        var text = string.Join(" ", phrases.Take(verseNumber).Reverse());

        return $"This is {text}.";
    }

    public static string Recite(int startVerse, int endVerse)
    {
        var texte = new List<string>(endVerse - startVerse + 1);

        for (int i = startVerse; i <= endVerse; i++)
        {
            texte.Add(House.Recite(i));
        }

        return string.Join("\n", texte);
    }
}
