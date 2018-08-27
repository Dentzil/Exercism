using System;
using System.Text.RegularExpressions;
using System.Linq;

public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span) 
    {
        CheckDigits(digits);
        CheckSpan(span, digits.Length);

        return  Regex.Matches(digits, $"(?=(\\d{{{span}}}))")
                     .Cast<Match>()
                     .Select(e => GetProduct(e.Groups[1].Value))
                     .Max();
    }

    private static void CheckDigits(string digits)
    {
         if (!HasOnlyDigits(digits))
         {
             throw new ArgumentException($"Wrong digit sequence: {digits}");
         }
    }

    private static bool HasOnlyDigits(string digits)
    {
        return digits.All(char.IsDigit);
    }

    private static void CheckSpan(int span, int digitsLength)
    {
        if (span < 0)
        {
            throw new ArgumentException("Span must be greather than 0");
        }

        if (span > digitsLength)
        {
            throw new ArgumentException("Span cannot be longer than digits length");
        }
    }

    private static long GetProduct(string series)
    {
        return (long)series.Aggregate(1, (total, next) => total *= next - 48);
    }
}
