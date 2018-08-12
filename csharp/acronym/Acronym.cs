using System.Text.RegularExpressions;
using System.Linq;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        var singleWords = Regex.Split(phrase, "[^a-zA-Z]")
                               .Where(e => e != string.Empty)
                               .ToList();

        return string.Join("", singleWords.Select(e =>  char.ToUpper(e[0])));
    }
}
