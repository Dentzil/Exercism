#include "nucleotide_count.h"

namespace nucleotide_count
{
    counter::counter(std::string dna)
    {
        _nucleotide_count_map = { {'A', 0}, {'T', 0}, {'C', 0}, {'G', 0} };
        count_nucleotides(dna);
    }

    void counter::count_nucleotides(std::string dna)
    {
        for(auto nucleotide: dna)
        {
            nucleotide = toupper(nucleotide);
            validate_nucleotide(nucleotide);
            
            _nucleotide_count_map.at(nucleotide)++;
            
        }
    }

    void counter::validate_nucleotide(char nucleotide) const
    {
        if (_nucleotide_count_map.find(nucleotide) == _nucleotide_count_map.end())
        {
            throw std::invalid_argument("Unknown nucleotide: " + std::to_string(nucleotide) + ".");
        }
    }
   
    int counter::count(char nucleotide) const
    {
        nucleotide = toupper(nucleotide);
        validate_nucleotide(nucleotide);

        return _nucleotide_count_map.at(nucleotide);
    }
    
    std::map<char, int> counter::nucleotide_counts() const
    {
        return {
                {'A', _nucleotide_count_map.at('A')},
                {'T', _nucleotide_count_map.at('T')},
                {'C', _nucleotide_count_map.at('C')},
                {'G', _nucleotide_count_map.at('G')}
               };
    }
}
