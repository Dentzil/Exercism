#include "nucleotide_count.h"

namespace dna
{
    counter::counter(std::string dna)
    {
        _nucleotide_counts = { {'G', 0}, {'C', 0}, {'T', 0}, {'A', 0} };
        
        for(auto nucleotide: dna)
        {
            check_nucleotide(nucleotide);
            _nucleotide_counts.at(nucleotide)++;
        }
    }
    
    void counter::check_nucleotide(char nucleotide) const
    {
        if (_nucleotide_counts.find(nucleotide) == _nucleotide_counts.end())
        {
            throw std::invalid_argument("Unknown nucleotide: " + std::to_string(nucleotide) + ".");
        }
    }
    
    int counter::count(char nucleotide) const
    {
        check_nucleotide(nucleotide);
        return _nucleotide_counts.at(nucleotide);
    }
    
    std::map<char, int> counter::nucleotide_counts() const
    {
        return _nucleotide_counts;
    }
}
