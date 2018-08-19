#include "rna_transcription.h"

namespace transcription
{
    std::map<char, char> rnaToDnaMap =
    {
        {'G', 'C'},
        {'C', 'G'},
        {'T', 'A'},
        {'A', 'U'}
    };
    
    char to_rna(char nucleotide)
    {
        if (rnaToDnaMap.find(nucleotide) == rnaToDnaMap.end())
        {
            throw "Invalid nucledotide";
        }
        
        return rnaToDnaMap[nucleotide];
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
