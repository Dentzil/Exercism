namespace Exercism_perfect_numbers
{
    using static System.Math;

    public enum NumberType
    {
        Abundant,
        Deficient,
        Perfect
    }

    public class PerfectNumbers
    {
        public static NumberType Classify(int number)
        {
            int sumOfFactors = CalculateSumOfFactors(number);

            if (sumOfFactors == number)
            {
                return NumberType.Perfect;
            }

            return sumOfFactors > number ? NumberType.Abundant : NumberType.Deficient;
        }

        private static int CalculateSumOfFactors(int number)
        {
            int limit = (int)Sqrt(number);

            int sum = 1;

            for (int i = 2; i <= limit; i++)
            {
                if (number % i == 0)
                {
                    sum += i;

                    if (number / i != i)
                    {
                        sum += number / i;
                    }
                }
            }

            return sum;
        }
    }
}
