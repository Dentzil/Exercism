#include "armstrong_numbers.h"

int get_count_of_digits(int number);

int is_armstrong_number(int candidate)
{
    int count_of_digits = get_count_of_digits(candidate);
    int tmp = candidate;
    int sum = 0;

    while (tmp != 0)
    {
        sum += (int)pow(tmp % 10, count_of_digits);
        tmp /= 10;
    }
    
    return sum == candidate;
}

int get_count_of_digits(int number)
{
    int count = 0;

    while (number != 0)
    {
        number /= 10;
        count++;
    }

    return count;
}
