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
        return dna
                .split('')
                .map(e => 
                {
                    if (!this.dnaRnaMap[e])
                    {
                        throw new Error("Invalid input");
                    }

                    return this.dnaRnaMap[e];
                })
                .join('');
    }
}

module.exports = DnaTranscriber;
