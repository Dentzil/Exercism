using System.Text;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        var encodedText = new StringBuilder(text.Length);

        foreach (var c in text)
        {
            if (char.IsLetter(c))
            {
                var i = (char.ToLower(c) - 97 + shiftKey) % 26;
                encodedText.Append((char)(char.IsUpper(c) ? (i + 65) : (i + 97)));
            }
            else
            {
                encodedText.Append(c);
            }
        }

        return encodedText.ToString();
    }
}
