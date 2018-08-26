public static class RomanNumeralExtension
{
    private static string[] Thousands = { "", "M", "MM", "MMM" };
    private static string[] Hundreds = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
    private static string[] Tens = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
    private static string[] Ones = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

    public static string ToRoman(this int value)
    {
        string[] roman = new string[4];

        roman[0] = Thousands[(value / 1000 ) % 10];
        roman[1] = Hundreds[(value / 100) % 10];
        roman[2] = Tens[(value / 10) % 10];
        roman[3] = Ones[value % 10];

        return string.Join("", roman);
    }
}
