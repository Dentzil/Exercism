using System;
using System.Collections.Generic;
using System.Linq;

public class Sieve
{
    public static int[] Primes(int n)
    {
        if (n <= 1)
        {
            throw new ArgumentOutOfRangeException();
        }

        bool[] indexes = Enumerable.Range(0, n + 1).Select(e => true).ToArray();
        List<int> primes = new List<int>();

        for (int i = 2; i <= n; i++)
        {
            if (indexes[i])
            {
                primes.Add(i);

                for (int j = i * i; j <= n; j += i)
                {
                    indexes[j] = false;
                }
            }
        }

        return primes.ToArray();
    }
}
