using System.Text.RegularExpressions;

public static class IsbnVerifier
{
    private static Regex _isbn10FormatRegex = new Regex(@"^\d{9}(\d|X)$");

    public static bool IsValid(string number)
    {
        number = number.Replace("-", "");

        if (_isbn10FormatRegex.IsMatch(number) == false)
        {
            return false;
        }

        int checkSum = 0;

        for (int i = 0; i < 10; i++)
        {
            checkSum += (number[i] == 'X' ? 10 : number[i] - 48) * (10 - i);
        }

        checkSum %= 11;

        return checkSum == 0;
    }
}
