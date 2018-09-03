using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class TwelveDays
{
    private static List<string> _ordinalNumbers = new List<string>
    {
        "first", "second", "third", "fourth", "fifth", "sixth", "seventh", "eighth", "ninth", "tenth", "eleventh", "twelfth"
    };

    private static List<string> _phrases = new List<string>
    {
        "a Partridge in a Pear Tree",
        "two Turtle Doves",
        "three French Hens",
        "four Calling Birds",
        "five Gold Rings",
        "six Geese-a-Laying",
        "seven Swans-a-Swimming",
        "eight Maids-a-Milking",
        "nine Ladies Dancing",
        "ten Lords-a-Leaping",
        "eleven Pipers Piping",
        "twelve Drummers Drumming"
    };

    public static string Recite(int verseNumber)
    {
        var ordinalNumber = _ordinalNumbers[verseNumber - 1];
        var text = new StringBuilder();

        for (int i = verseNumber - 1; i >= 0; i--)
        {
            if (i == 0 && verseNumber != 1)
            {
                text.Append($", and {_phrases[i]}");
            }
            else 
            {
                text.Append($", {_phrases[i]}");
            }
        }

        return $"On the {ordinalNumber} day of Christmas my true love gave to me{text.ToString()}.";
    }

    public static string Recite(int startVerse, int endVerse)
    {
        var text = Enumerable.Range(startVerse, endVerse - startVerse + 1).Select(e => TwelveDays.Recite(e));
        
        return string.Join("\n", text);
    }
}
