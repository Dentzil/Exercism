using System.Linq;

public class Bob
{
    public static string Response(string text)
    {
        if (IsNothingSaid(text))
        {
            return "Fine. Be that way!";
        }

        if (IsQuestionYelled(text))
        {
            return "Calm down, I know what I'm doing!";
        }

        if (IsYelled(text))
        {
            return "Whoa, chill out!";
        }

        if (IsQuestionAsked(text))
        {
            return "Sure.";
        }

        return "Whatever.";
    }

    private static bool IsNothingSaid(string text)
    {
        return string.IsNullOrWhiteSpace(text);
    }

    private static bool IsQuestionAsked(string text)
    {
        return text.TrimEnd().Last() == '?';
    }

    private static bool IsQuestionYelled(string text)
    {
        return IsQuestionAsked(text) && IsYelled(text);
    }

    private static bool IsYelled(string text)
    {
        return text.Any(e => char.IsLetter(e)) && text.Where(e => char.IsLetter(e)).All(e => char.IsUpper(e));
    }
}
