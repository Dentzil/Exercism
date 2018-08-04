namespace Exercism_armstrong_number
{
    using static System.Math;

    using System.Collections.Generic;
    using System.Linq;

    public static class ArmstrongNumbers
    {
        public static bool IsArmstrongNumber(int number)
        {
            var digits = number.ToDigits().ToArray();
            int numberOfDigits = digits.Length;

            int sumOfPowers = 0;
            foreach (var d in digits)
            {
                sumOfPowers += (int)Pow(d, numberOfDigits);
            }

            return sumOfPowers == number;
        }
    }

    public static class IntegerExtentions
    {
        public static IEnumerable<int> ToDigits(this int number)
        {
            if (number == 0)
            {
                yield return 0;
            }

            while (number != 0)
            {
                yield return number % 10;
                number /= 10;
            }
        }
    }
}
