using System;
using System.Text.RegularExpressions;
using System.Linq;

public static class Series
{
    public static string[] Slices(string inputString, int length)
    {
        if (string.IsNullOrEmpty(inputString))
        {
            throw new ArgumentException("Empty input string.");
        }

        if (length <= 0)
        {
            throw new ArgumentException("Slice length must be greather than 0.");
        }

        if (length >= inputString.Length)
        {
            return new[] { inputString };
        }

        return Regex.Matches(inputString, $"(?=(\\d{{{length}}}))")
                    .Cast<Match>()
                    .Select(e => e.Groups[1].Value)
                    .ToArray();
    }
}
