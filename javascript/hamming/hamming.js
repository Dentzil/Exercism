class Hamming {
    constructor() {}

    compute(dna1, dna2) {
        if (dna1.length !== dna2.length) {
            throw new Error("DNA strands must be of equal length.");
        }

        return dna1.split('').filter((e, i) => e !== dna2[i]).length;
    }
};

module.exports = Hamming;
