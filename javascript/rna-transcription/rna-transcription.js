class DnaTranscriber {
    constructor() {
        this.dnaRnaMap = {
            'G': 'C',
            'C': 'G',
            'T': 'A',
            'A': 'U'
        };
    }

    toRna(dna) {
        let rna = [];

        for (let i = 0; i < dna.length; i++) {
            let nucleotide = dna[i];

            if (this.dnaRnaMap[nucleotide] === undefined) {
                throw new Error("Invalid input");
            }

            rna.push(this.dnaRnaMap[nucleotide]);
        }

        return rna.join('');
    }
}

module.exports = DnaTranscriber;
