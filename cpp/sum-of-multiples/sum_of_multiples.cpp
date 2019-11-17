#include "sum_of_multiples.h"

namespace sum_of_multiples
{
    long to(std::vector<int> divisors, int n)
    {
        long sum = 0;
        
        for (int i = 1; i < n; i++)
        {
            for (int divisor: divisors)
            {
                if (i % divisor == 0)
                {
                    sum += i;
                    break;
                }
            }
        }
            
        return sum;
    }
}
