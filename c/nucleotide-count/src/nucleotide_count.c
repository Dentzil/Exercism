#include "nucleotide_count.h"

char *count(const char *dna_strand)
{
    size_t counts[4] = {0};
    char *output = NULL;

    output = (char *)calloc(100, sizeof(char));
    if (output == NULL)
    {
        printf("Error: memory allocation failed.");
        return NULL;
    }

    for (size_t i = 0; dna_strand[i] != '\0'; i++)
    {
        switch (dna_strand[i])
        {
        case 'A':
            counts[0]++;
            break;
        
        case 'C':
            counts[1]++;
            break;

        case 'G':
            counts[2]++;
            break;

        case 'T':
            counts[3]++;
            break;

        default:
            return output;
        }
    }

    sprintf(output, "A:%ld C:%ld G:%ld T:%ld", counts[0], counts[1], counts[2], counts[3]);

    return output;
}
