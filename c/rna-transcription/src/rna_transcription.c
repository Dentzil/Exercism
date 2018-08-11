#include "rna_transcription.h"

char *to_rna(const char *const dna)
{
    char *rna = (char *)calloc(strlen(dna) + 1, sizeof(char));

    for (size_t i = 0; dna[i] != '\0'; i++)
    {
        if (dna[i] == 'G')
        {
            rna[i] = 'C';
        }
        else if (dna[i] == 'C')
        {
            rna[i] = 'G';
        }
        else if (dna[i] == 'T')
        {
            rna[i] = 'A';
        }
        else if (dna[i] == 'A')
        {
            rna[i] = 'U';
        }
        else
        {
            free(rna);
            rna = NULL;
            break;
        }
    }

    return rna;
}
