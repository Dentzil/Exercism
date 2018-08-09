#include "hamming.h"

size_t compute(const char *const dna1, const char *const dna2)
{
    if (dna1 == NULL || dna2 == NULL || strlen(dna1) != strlen(dna2))
    {
        return -1;
    }

    size_t difference = 0;
    for (size_t i = 0; dna1[i] != '\0'; i++)
    {
        if (dna1[i] != dna2[i])
        {
            difference++;
        }
    }

    return difference;
}
