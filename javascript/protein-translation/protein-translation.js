const codonProteinMap = {
    "AUG": "Methionine",
    "UUU": "Phenylalanine",
    "UUC": "Phenylalanine",
    "UUA": "Leucine",
    "UUG": "Leucine",
    "UCU": "Serine",
    "UCC": "Serine",
    "UCA": "Serine",
    "UCG": "Serine",
    "UAU": "Tyrosine",
    "UAC": "Tyrosine",
    "UGU": "Cysteine",
    "UGC": "Cysteine",
    "UGG": "Tryptophan",
    "UAA": "STOP",
    "UAG": "STOP",
    "UGA": "STOP"
}

var translate = function(rna = "") {
    let polypeptide = [];
    let codons = rna.match(/[A-Z]{3}/g) || [];

    for (let i = 0; i < codons.length; i++) {
        if (codonProteinMap[codons[i]] === undefined) {
            throw new Error("Invalid codon");
        }
        else if (codonProteinMap[codons[i]] === "STOP") {
            break;
        }
        else {
            polypeptide.push(codonProteinMap[codons[i]]);
        }
    }

    return polypeptide;
};

module.exports = translate;
