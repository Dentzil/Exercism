    using static System.Math;

    using System;

    public enum Classification
    {
        Abundant,
        Deficient,
        Perfect
    }

    public class PerfectNumbers
    {
        public static Classification Classify(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            int sumOfFactors = CalculateSumOfFactors(number);
            if (sumOfFactors == number && sumOfFactors != 1)
            {
                return Classification.Perfect;
            }

            return sumOfFactors > number ? Classification.Abundant : Classification.Deficient;
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
