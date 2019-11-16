#ifndef NUCLEOTIDE_COUNT_H
#define NUCLEOTIDE_COUNT_H

#include <map>
#include <stdexcept>
#include <string>
#include <unordered_map>

namespace nucleotide_count
{
    class counter
    {
    private:
        std::unordered_map<char, int> _nucleotide_count_map;
        
        void count_nucleotides(std::string dna);
        void validate_nucleotide(char nucleotide) const;
        
    public:
        counter(std::string dna);
        
        int count(char nucleotide) const;
        std::map<char, int> nucleotide_counts() const;
    };
}

#endif
