#include "rna_transcription.h"

namespace rna_transcription
{
    char to_rna(char dna_nucleotide)
    {
        switch (dna_nucleotide)
        {
            case 'A': return 'U';
            case 'C': return 'G';
            case 'G': return 'C';
            case 'T': return 'A';

            default: throw "Invalid dna nucledotide.";
        }
    }
    
    std::string to_rna(std::string dna)
    {
        std::string rna;
        
        for(auto it = dna.begin(); it < dna.end(); it++)
        {
            rna.append(1, to_rna(*it));
        }
        
        return rna;
    }
}
