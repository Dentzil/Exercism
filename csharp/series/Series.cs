using System;
using System.Text.RegularExpressions;
using System.Linq;

public static class Series
{
    public static string[] Slices(string series, int sliceLength)
    {
        CheckSeries(series);
        CheckSliceLength(sliceLength, series.Length);

        return Regex.Matches(series, $"(?=(\\d{{{sliceLength}}}))")
                    .Cast<Match>()
                    .Select(e => e.Groups[1].Value)
                    .ToArray();
    }

    private static void CheckSeries(string series)
    {
        if (series == string.Empty)
        {
            throw new ArgumentException("Series cannot be empty");
        }
    }

    private static void CheckSliceLength(int sliceLength, int seriesLength)
    {
        if (sliceLength <= 0)
        {
            throw new ArgumentException("Slice length must be greather than 0");
        }

        if (sliceLength > seriesLength)
        {
            throw new ArgumentException("Slice length must be less than or equal the series length");
        }
    }
}
