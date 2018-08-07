#include "hamming.h"

size_t compute(const char* dna1, const char* dna2)
{
    size_t length;
    
    if (dna1 == NULL || dna2 == NULL || (length = strlen(dna1)) != strlen(dna2))
    {
        return -1;
    }

    size_t difference = 0;
    for (size_t i = 0; i < length; i++)
    {
        if (*(dna1 + i) != *(dna2 + i))
        {
            difference++;
        }
    }

    return difference;
}
