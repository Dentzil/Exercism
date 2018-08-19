#include "hamming.h"

namespace hamming
{
    size_t compute(std::string dna1, std::string dna2)
    {
        if (dna1.length() != dna2.length())
        {
            throw std::domain_error("The DNAs must be the same length.");
        }
        
        size_t difference = 0;
        for (size_t i = 0; i < dna1.length(); i++)
        {
            if (dna1[i] != dna2[i])
            {
                difference++;
            }
        }
        
        return difference;
    }
}
