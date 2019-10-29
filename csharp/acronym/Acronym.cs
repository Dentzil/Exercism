using System.Text.RegularExpressions;
using System.Linq;

public static class Acronym
{
    private static Regex _regex = new Regex("[^a-zA-Z']");

    public static string Abbreviate(string phrase)
    {
        var words = _regex.Split(phrase).Where(e => e != string.Empty).ToList();

        return string.Join("", words.Select(e =>  char.ToUpper(e[0])));
    }
}
