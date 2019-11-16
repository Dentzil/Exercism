#include "difference_of_squares.h"

namespace difference_of_squares
{
    long square_of_sum(int n)
    {
        if (n < 0)
        {
            throw "Invalid input.";
        }
        
        long sum = n * (n + 1) / 2;
        
        return sum * sum;
    }

    long sum_of_squares(int n)
    {
        if (n < 0)
        {
            throw "Invalid input.";
        }
        
        return (long)n * (n + 1) * (2 * n + 1) / 6;
    }

    long difference(int n)
    {
        return square_of_sum(n) - sum_of_squares(n);
    }
}
