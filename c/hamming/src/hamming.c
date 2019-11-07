#include "hamming.h"

long long compute(const char *const dna1, const char *const dna2)
{
    if (dna1 == NULL || dna2 == NULL)
    {
        return -1;
    }

    size_t difference = 0;
    size_t i = 0;
    while (dna1[i] != '\0' && dna2[i] != '\0')
    {
        if (dna1[i] != dna2[i])
        {
            difference++;
        }

        i++;
    }

    return dna1[i] == dna2[i] ? difference : -1;
}
