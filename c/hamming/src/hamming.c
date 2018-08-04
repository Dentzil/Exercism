#include "hamming.h"

int compute(const char* dna1, const char* dna2)
{
    if (dna1 == NULL || dna2 == NULL)
    {
        return -1;
    }

    int length1 = strlen(dna1);
    int length2 = strlen(dna2);
    if (length1 != length2)
    {
        return -1;
    }

    int difference = 0;
    for (int i = 0; i < length1; i++)
    {
        if (*(dna1 + i) != *(dna2 + i))
        {
            difference++;
        }
    }

    return difference;
}
