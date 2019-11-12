#ifndef RNA_TRANSCRIPTION_H
#define RNA_TRANSCRIPTION_H

#include <string>

namespace rna_transcription
{
    char to_rna(char dna_nucleotide);
    std::string to_rna(std::string dna);
}

#endif
