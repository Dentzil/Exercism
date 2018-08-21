class NucleotideCounts {
    constructor() {
        this.validNucleotides = {
            A: 0, C: 1, G: 2, T: 3
        };
    }

    parse(dna) {
        const result = Array(4).fill(0);

        for (let i = 0; i < dna.length; i++) {
            if (this.validNucleotides[dna[i]] === undefined) {
                throw new Error("Invalid nucleotide in strand");
            }

            result[this.validNucleotides[dna[i]]]++;
        }

        return result.join(' ');
    }
}

module.exports = new NucleotideCounts();
